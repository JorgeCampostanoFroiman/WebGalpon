using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using bussiness;
using System.Drawing;
using System.Reflection;
using System.Data;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using TextBox = System.Web.UI.WebControls.TextBox;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.text;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;

namespace WebGalpon
{
    public partial class CompraRapida : System.Web.UI.Page
    {
        ProductoNegocio negocio = new ProductoNegocio();
        public List<ItemCarrito> ListaCompraRapida;
        public decimal total;
        bool bandera = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && bandera == false)
            {
                InsertRecords();
            }
        }

        public void cargarcarrito()
        {
            GridView GV = new GridView();
            GridView1.DataSource = Session["ListaCompraRapida"];
            GridView1.DataBind();
            //Button1_Click(Button1, null);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);

            DataTable dt = CreateDatatable();

            int filaNueva = 1;

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex != index)
                {
                    TextBox txtCant = row.Cells[4].FindControl("TextCant") as TextBox;
                    string cant = txtCant.Text;

                    string codigo = row.Cells[2].Text;
                    string nombre = row.Cells[3].Text;
                    string precio = row.Cells[5].Text;
                    string imagen = row.Cells[6].Text;
                    string subtotal = row.Cells[6].Text;

                    dt.Rows.Add(filaNueva, codigo, nombre, cant, precio, subtotal);
                    dt.AcceptChanges();

                    filaNueva++;
                }
                else
                {

                }
            }


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void ActualizarButton_Click(object sender, EventArgs e)
        {
            int cantidadProductos = 0;
            int totalPedido = 0;

            foreach (GridViewRow row in GridView1.Rows)
            {
                TextBox txtCodigo = row.Cells[2].FindControl("TextCodigo") as TextBox;
                string text = txtCodigo.Text;

                TextBox txtCant = row.Cells[4].FindControl("TextCant") as TextBox;


                if (negocio.ExisteProducto(text) == true)
                {
                    Producto prod = negocio.BuscarProducto(text);

                    row.Cells[3].Text = prod.NombreProducto;
                    row.Cells[5].Text = Convert.ToString(prod.PrecioVenta);

                    if (txtCant.Text != null)
                    {

                        int cant = Convert.ToInt32(txtCant.Text);
                        row.Cells[6].Text = Convert.ToString(prod.PrecioVenta * cant);

                        cantidadProductos += cant;
                        totalPedido += Convert.ToInt32(prod.PrecioVenta * cant);

                    }
                }

            }
            LabelTotalPedido.Text = "Total: $" + totalPedido.ToString();
            LabelTotalProductos.Text = "Total de Productos: " + cantidadProductos.ToString();

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
            dt.AcceptChanges();
            return dt;
        }

        public void InsertRecords()
        {
            DataTable dt = CreateDatatable();
            for (int i = 0; i < 10; i++)
            {
                dt.Rows.Add((i + 1).ToString(), "0", " ", "0", " ", " ");
                dt.AcceptChanges();
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        protected void AgregarFilaButton_Click(object sender, EventArgs e)
        {
            AgregarRow();
        }

        private void AgregarRow()
        {
            DataTable dt = CargarDataTable();
            int fila = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                fila++;
            }

            dt.Rows.Add(fila.ToString(), "0", " ", " ", " ", " ");
            dt.AcceptChanges();


            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private DataTable CargarDataTable()
        {
            DataTable dt = CreateDatatable();

            foreach (GridViewRow row in GridView1.Rows)
            {
                TextBox txtCodigo = row.Cells[2].FindControl("TextCodigo") as TextBox;
                string codigo = txtCodigo.Text;

                TextBox txtCant = row.Cells[4].FindControl("TextCant") as TextBox;
                string cant = txtCant.Text;

                string nombre = row.Cells[3].Text;
                string precio = row.Cells[5].Text;
                string subtotal = row.Cells[6].Text;
                string fila = row.Cells[1].Text;

                dt.Rows.Add(fila, codigo, nombre, cant, precio, subtotal);
                dt.AcceptChanges();
            }
            return dt;
        }

        protected void Agregar10FilasButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                AgregarRow();
            }
        }

        protected void PdfButton_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);

            DataTable dt = CargarDataTable();

            document.Open();
            Font fontTitle = FontFactory.GetFont(FontFactory.COURIER_BOLD, 25);
            Font font9 = FontFactory.GetFont(FontFactory.TIMES, 9);


            PdfPTable table = new PdfPTable(dt.Columns.Count);
            document.Add(new Paragraph(20, "Pedido!", fontTitle));
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
                    table.AddCell(new Phrase(c.ColumnName, font9));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int h = 0; h < dt.Columns.Count; h++)
                        {
                            table.AddCell(new Phrase(r[h].ToString(), font9));
                        }
                    }
                }
                    
                document.Add(table);
            document.Add(new Paragraph(20, LabelTotalProductos.Text, fontTitle));
            document.Add(new Chunk("\n"));

            document.Add(new Paragraph(20, LabelTotalPedido.Text, fontTitle));
            document.Add(new Chunk("\n"));

           
            document.Close();


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Pedido" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();

        }


        protected void EmailButton_Click(object sender, EventArgs e)
        {
            if (TextMail.Text != null)
            {
                MailMessage ms = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                ms.From = new MailAddress("j.campostano@gmail.com");
                ms.To.Add(new MailAddress(TextMail.Text));

                ms.Subject = "Hola";

                smtp.Host = "smtp.gmail.com"; // para hotmail es "smtp.live.com";
                smtp.Port = 587; //gmail, para hotmail es 25 o 465

                smtp.Credentials = new NetworkCredential("j.campostano@gmail.com", "bmjpgfxoxytqigkw");
                smtp.EnableSsl = true;

                try
                {
                    smtp.Send(ms);
                    Console.WriteLine("El correo se envío correctamente");
                }
                catch (Exception)
                {
                }
            }
            
        }
    }
}