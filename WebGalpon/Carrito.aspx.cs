using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using bussiness;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Org.BouncyCastle.Asn1.Ocsp;
using iTextSharp.text;
using Image = System.Web.UI.WebControls.Image;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace WebGalpon
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ItemCarrito> items;
        public decimal total;
        DataTable dt = new DataTable();
        ProductoNegocio negocio = new ProductoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlertLabel.Text = " ";
                try
                {
                    dt = Session["items"] as DataTable;
                    if (dt == null)
                        dt = CreateDatatable();
                        
                    GridViewCarrito.DataSource = dt;
                    GridViewCarrito.DataBind();

                     //&& ProductExists("Id") == true

                    if (ProductExists(Request.QueryString["Id"]))
                    {
                       
                        ActualizarButton.Visible = true;

                        if (ExisteProdEnDt(Request.QueryString["Id"]) == false)
                        {
                            AgregarRow(negocio.BuscarProducto(Request.QueryString["Id"]));
                            SumarUnidades(Request.QueryString["Id"], Request.QueryString["cant"]);
                            AlertLabel.Text = "Producto agregado correctamente";
                        }
                        else // sumamos unidades si ya estaba? yo creo que no
                        {
                            //SumarUnaUnidad(Request.QueryString["Id"]);
                            //AlertLabel.Text = "El producto ya estaba en el carrito, se le sumó una unidad

                            AlertLabel.Text = "El producto ya estaba en el carrito...";
                        }
                        CalcularTotales();
                    }
                    else if (dt != null)
                    {
                        ActualizarButton.Visible = false;

                        ProductosButton.Visible = true;

                        AlertLabel.Text = "El producto no existe o no pudo agregarse... ";

                        TitleLabel.Text = " ";
                    }
                    else if (Request.QueryString["Id"] == null)
                    {
                        ActualizarButton.Visible = false;

                        ProductosButton.Visible = true;

                        AlertLabel.Text = " ";

                        TitleLabel.Text = " ";
                    }
                }
                catch(Exception)
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        private bool ProductExists(string Codigo)
        {
            ProductoNegocio prodNeg = new ProductoNegocio();
            List<Producto> Aux = prodNeg.Listar();

            foreach (Producto prod in Aux)
            {
                if (Codigo == prod.Codigo)
                {
                    return true;
                }
            }
            return false;
        }

        private void CalcularTotales()
        {
            int cantidadProductos = 0;
            int totalPedido = 0;

            foreach (GridViewRow row in GridViewCarrito.Rows)
            {
                HyperLink txtLink = row.Cells[1].FindControl("TextCodigo") as HyperLink;
                string codigo = Convert.ToString(txtLink.Text);

                TextBox txtCant = row.Cells[3].FindControl("TextCant") as TextBox;


                if (negocio.ExisteProducto(codigo) == true)
                {
                    Producto prod = negocio.BuscarProducto(codigo);

                    row.Cells[2].Text = prod.NombreProducto;
                    row.Cells[4].Text = "$" + Convert.ToString((int)Decimal.Truncate(prod.PrecioVenta));

                    if (txtCant.Text != null)
                    {
                        int cant = Convert.ToInt32(txtCant.Text);
                        row.Cells[5].Text = "$" +  Convert.ToString((int)Decimal.Truncate(prod.PrecioVenta * cant));

                        cantidadProductos += cant;
                        totalPedido += Convert.ToInt32(prod.PrecioVenta * cant);

                    }
                }

                DataTable Guardar = CargarDataTable();


                Session.Add("items", Guardar);

            }
            LabelTotalPedido.Text = "Total: $" + totalPedido.ToString();
            LabelTotalProductos.Text = "Total de Productos: " + cantidadProductos.ToString();
        }

        private void SumarUnidades(string id, string cantSumar)
        {
            DataTable dt = CreateDatatable();

            foreach (GridViewRow row in GridViewCarrito.Rows)
            {

                TextBox txtCant = row.Cells[3].FindControl("TextCant") as TextBox;
                string cant = txtCant.Text;

                Image imgen = row.Cells[6].FindControl("ImgCarro") as Image;
                string imagen = imgen.ImageUrl;

                HyperLink txtLink = row.Cells[1].FindControl("TextCodigo") as HyperLink;
                string codigo = Convert.ToString(txtLink.Text); 

                string fila = row.Cells[0].Text;
                string nombre = row.Cells[2].Text;
                string precio = row.Cells[4].Text;
                string subtotal = row.Cells[5].Text;
                
                if (codigo == id)
                {
                    int cantidad = Convert.ToInt32(cant);
                    cantidad = cantidad + Convert.ToInt32(cantSumar);
                    dt.Rows.Add(fila, codigo, nombre, Convert.ToString(cantidad), precio, subtotal, imagen);
                    dt.AcceptChanges();
                }
                else
                {
                    dt.Rows.Add(fila, codigo, nombre, cant, precio, subtotal, imagen);
                    dt.AcceptChanges();
                }
                
            }
            Session.Add("items", dt);
            GridViewCarrito.DataSource = dt;
            GridViewCarrito.DataBind();
        }

        private void AgregarRow(Producto prod)
        {
            DataTable dt = CargarDataTable();
            int fila = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fila++;
            }

            dt.Rows.Add(fila.ToString(), prod.Codigo, prod.NombreProducto, Convert.ToString(prod.Cantidad), Convert.ToString(prod.PrecioVenta), Convert.ToString(prod.Cantidad * prod.PrecioVenta), prod.ImagenUrl);
            dt.AcceptChanges();

            GridViewCarrito.DataSource = dt;
            GridViewCarrito.DataBind();

            Session.Add("items", dt);
        }

        public void InsertRecords()
        {
            DataTable dt = CreateDatatable();
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add((i + 1).ToString(), "0", " ", "0", " ", " ", " ");
                dt.AcceptChanges();
            }

            GridViewCarrito.DataSource = dt;
            GridViewCarrito.DataBind();
        }

        private bool ExisteProdEnDt(string cod)
        { 
            foreach (GridViewRow row in GridViewCarrito.Rows)
            {
                HyperLink txtLink = row.Cells[1].FindControl("TextCodigo") as HyperLink;
                string codigo = Convert.ToString(txtLink.Text);

                if (cod == codigo){
                    return true;
                }
            }
            return false;
        }

        private DataTable CargarDataTable()
        {
            DataTable dt = CreateDatatable();

            foreach (GridViewRow row in GridViewCarrito.Rows)
            {
                TextBox txtCant = row.Cells[3].FindControl("TextCant") as TextBox;
                string cant = txtCant.Text;

                Image imgen = row.Cells[6].FindControl("ImgCarro") as Image;
                string imagen = imgen.ImageUrl;

                HyperLink txtLink = row.Cells[2].FindControl("TextCodigo") as HyperLink;
                string codigo = Convert.ToString(txtLink.Text);

                string fila = row.Cells[0].Text;
                string nombre = row.Cells[2].Text;
                string precio = row.Cells[4].Text;
                string subtotal = row.Cells[5].Text;

                dt.Rows.Add(fila, codigo, nombre, cant, precio, subtotal, imagen);
                dt.AcceptChanges();
            }
            return dt;
        }

        private DataTable CreateDatatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fila");
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Subtotal");
            dt.Columns.Add("Imagen");
            dt.AcceptChanges();
            return dt;
        }

        protected void ActualizarButton_Click1(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        protected void GridViewCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);

            DataTable dt = CreateDatatable();

            int filaNueva = 1;

            foreach (GridViewRow row in GridViewCarrito.Rows)
            {
                if (row.RowIndex != index)
                {
                    TextBox txtCant = row.Cells[3].FindControl("TextCant") as TextBox;
                    string cant = txtCant.Text;

                    Image imgen = row.Cells[6].FindControl("ImgCarro") as Image;
                    string imagen = imgen.ImageUrl;

                    HyperLink txtLink = row.Cells[1].FindControl("TextCodigo") as HyperLink;
                    string codigo = Convert.ToString(txtLink.Text);

                    string nombre = row.Cells[2].Text;
                    string precio = row.Cells[4].Text;
                    string subtotal = row.Cells[5].Text;

                    dt.Rows.Add(filaNueva, codigo, nombre, cant, precio, subtotal, imagen);
                    dt.AcceptChanges();

                    filaNueva++;
                }
                else
                {

                }
            }

            Session.Add("items", dt);
            GridViewCarrito.DataSource = dt;
            GridViewCarrito.DataBind();
        }

        protected void PdfButton1_Click(object sender, ImageClickEventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);


            DataTable dt = CargarDataTable();

            document.Open();

            document.SetMargins(100, 100, 100, 100);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("https://i.postimg.cc/qqyk5S7f/logo-Galpon.png");
            logo.ScaleToFit(500f, 30f);

            document.Add(logo);

            Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
            Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);

            Paragraph titulo = new Paragraph();
            titulo.Font = new Font(FontFactory.GetFont("Georgia", 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;

            if (Convert.ToString(Session["nombreusuario"]) == "Ruben")
            {
                titulo.Add(" Pedido de Rubencito Deté ");
            }
            else
            {
                titulo.Add(" Pedido de " + Session["nombreusuario"]);
            }

            PdfPCell cell2 = new PdfPCell();

            PdfPTable table = new PdfPTable(dt.Columns.Count);

            document.Add(titulo);
            document.Add(new Chunk("\n"));


            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;


            table.SetWidths(widths);
            table.WidthPercentage = 90;


            PdfPCell cell = new PdfPCell(new Phrase("columns"));
            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                PdfPCell celdatitulo = new PdfPCell();
                celdatitulo.VerticalAlignment = Element.ALIGN_MIDDLE;
                celdatitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                Phrase phrase = new Phrase(c.ColumnName, font9);
                celdatitulo.BackgroundColor = new BaseColor(91, 203, 223);
                celdatitulo.Phrase = phrase;

                table.AddCell(celdatitulo);
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {

                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        if (Convert.ToString(r[1]) == "0")
                        {
                        }
                        else
                        {
                            PdfPCell celda = new PdfPCell();
                            celda.BackgroundColor = new BaseColor(230, 240, 240);

                            if (h == 6)
                            {
                                iTextSharp.text.Image producto = iTextSharp.text.Image.GetInstance(r[h].ToString());
                                producto.ScaleToFit(500f, 30f);
                                celda.Image = producto;
                                table.AddCell(celda);
                            }
                            else
                            {
                                celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                                Phrase phrase = new Phrase(r[h].ToString(), font9);
                                celda.Phrase = phrase;
                                table.AddCell(celda);
                            }
                        }

                    }
                }
            }
            document.Add(table);

            document.Add(new Chunk("\n"));
            document.Add(new Chunk("\n"));

            Paragraph totalProductos = new Paragraph();
            totalProductos.Font = new Font(FontFactory.GetFont("Helvetica", 13, Font.BOLD));
            totalProductos.Alignment = Element.ALIGN_CENTER;
            totalProductos.Add(LabelTotalProductos.Text);
            document.Add(totalProductos);


            document.Add(new Chunk("\n"));

            Paragraph totalPedido = new Paragraph();
            totalPedido.Font = new Font(FontFactory.GetFont("Arial", 13, Font.BOLD));
            totalPedido.Alignment = Element.ALIGN_CENTER;
            totalPedido.Add(LabelTotalPedido.Text);
            document.Add(totalPedido);

            document.Add(new Chunk("\n"));


            document.Close();


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Pedido" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();
        }


        protected void CodeButton_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);


            DataTable dt = CargarDataTable();

            document.Open();

            //document.SetMargins(100, 100, 100, 100);

            //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("https://i.postimg.cc/qqyk5S7f/logo-Galpon.png");
            //logo.ScaleToFit(30f, 12f);

            //document.Add(logo);

            Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
            Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);

            PdfPTable table = new PdfPTable(4);

            document.Add(new Chunk("\n"));

            float[] widths = new float[4];
            for (int i = 0; i < 4; i++)
                widths[i] = 8f;

            table.SetWidths(widths);
            table.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase("columns"));
            cell.Colspan = 30;

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    int cantidad = 1;
                    int cuenta = 0;

                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        if (Convert.ToString(r[1]) == "0")
                        {
                        }
                        else
                        {
                            PdfPCell celda = new PdfPCell();
                            celda.BackgroundColor = new BaseColor(230, 240, 240);
                            PdfPCell celdaRelleno = new PdfPCell();
                            celdaRelleno.BackgroundColor = new BaseColor(230, 240, 240);

                            if (h == 3)
                            {
                                cantidad = Convert.ToInt32(r[h]);
                            }

                            if (h == 6)
                            {
                                
                                iTextSharp.text.Image producto = iTextSharp.text.Image.GetInstance(r[h].ToString());
                                producto.ScaleToFit(30f, 12f);
                                celda.Image = producto;

                                if (r == dt.Rows[dt.Rows.Count - 1])
                                {

                                    for (int c = 0; c < cantidad; c++)
                                    {
                                        table.AddCell(celda);
                                        cuenta++;
                                    }


                                    int complete = cuenta % 4;

                                    if (complete == 1)
                                    {
                                        table.AddCell(celdaRelleno);
                                        table.AddCell(celdaRelleno);
                                        table.AddCell(celdaRelleno);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < complete; i++)
                                        {
                                            table.AddCell(celdaRelleno);
                                        }
                                    }
                                }
                                else
                                {
                                    for (int c = 0; c < cantidad; c++)
                                    {
                                        table.AddCell(celda);
                                        cuenta++;
                                    }
                                }

                            }
                        }

                    }
                }
            }
            document.Add(table);

            document.Close();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Pedido" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();
        }
    }
}