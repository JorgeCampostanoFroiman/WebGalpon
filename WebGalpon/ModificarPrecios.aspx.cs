using bussiness;
using domain;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebGalpon
{
    public partial class ModificarPrecios : System.Web.UI.Page
    {
        TipoNegocio tipoNegocio = new TipoNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Usuario user = (Usuario)Session["usuario"];

            if ((Session["usuario"] != null) && (((domain.Usuario)Session["usuario"]).TipoUsuario == domain.TipoUsuario.ADMIN))
            {

            }
            else
            {
                Session.Add("error", "No tienes permisos para ver este sitio");
                Response.Redirect("Error.aspx");
            }

            if (!IsPostBack)
            {

                PrecioRectangular.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(1))).ToString() + ")";

                PrecioX6.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(6))).ToString() + ")";

                Precio2840.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(15))).ToString() + ")";

                Precio2030.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(14))).ToString() + ")";

                PrecioPortallaves.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(11))).ToString() + ")";

                PrecioPercheros.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(12))).ToString() + ")";

                PrecioRelojes.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(10))).ToString() + ")";

                PrecioTablitaX3.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(16))).ToString() + ")";

                PrecioTablitaX4.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(17))).ToString() + ")";

                PrecioTablitaX5.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(18))).ToString() + ")";

                PrecioTablitaX6.Text = "($" + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(19))).ToString() + ")";



                ModPre1.Text =  (Convert.ToInt32(tipoNegocio.PrecioPorTipo(1))).ToString();

                ModPre2.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(6))).ToString() ;

                ModPre3.Text =  (Convert.ToInt32(tipoNegocio.PrecioPorTipo(15))).ToString() ;

                ModPre4.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(14))).ToString();

                ModPre5.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(11))).ToString();

                ModPre6.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(12))).ToString() ;

                ModPre7.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(10))).ToString() ;

                ModPre8.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(16))).ToString() ;

                ModPre9.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(17))).ToString() ;

                ModPre10.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(18))).ToString() ;

                ModPre11.Text = (Convert.ToInt32(tipoNegocio.PrecioPorTipo(19))).ToString() ;

            }


        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ModPre1.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre1.Text), 1);
            }

            if (Convert.ToInt32(ModPre2.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre2.Text), 6);
            }

            if (Convert.ToInt32(ModPre3.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre3.Text), 15);
            }

            if (Convert.ToInt32(ModPre4.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre4.Text), 14);
            }

            if (Convert.ToInt32(ModPre5.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre5.Text), 10);
            }

            if (Convert.ToInt32(ModPre6.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre6.Text), 11);
            }

            if (Convert.ToInt32(ModPre7.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre7.Text), 12);
            }

            if (Convert.ToInt32(ModPre8.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre8.Text), 16);
            }

            if (Convert.ToInt32(ModPre9.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre9.Text), 17);
            }

            if (Convert.ToInt32(ModPre10.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre10.Text), 18);
            }

            if (Convert.ToInt32(ModPre11.Text) > 0)
            {
                tipoNegocio.ModificarPrecioMayorista(Convert.ToInt32(ModPre11.Text), 19);
            }

        }

        protected void PdfButton_Click(object sender, ImageClickEventArgs e)
        {

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, HttpContext.Current.Response.OutputStream);

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
            titulo.Add(" PRECIOS VIGENTES ");

            document.Add(titulo);
            document.Add(new Chunk("\n"));

            Paragraph Rectangular = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(1))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Escalonado = new Paragraph("Cuadro Escalonado: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(1))).ToString(), font9);
            document.Add(Escalonado);
            document.Add(new Chunk("\n"));

            Paragraph Triptico = new Paragraph("Cuadro Triptico: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(1))).ToString(), font9);
            document.Add(Triptico);
            document.Add(new Chunk("\n"));

            Paragraph X6 = new Paragraph("Cuadro XL (120cm x 55cm): " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(6))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Individual2840 = new Paragraph("Cuadro Individual 2840: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(15))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Individual2030 = new Paragraph("Cuadro Individual 2030: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(14))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Portallaves = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(11))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Percheros = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(12))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Relojes = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(10))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Tablitax3 = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(16))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Tablitax4 = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(17))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Tablitax5 = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(18))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));

            Paragraph Tablitax6 = new Paragraph("Cuadro Rectangular: " + (Convert.ToInt32(tipoNegocio.PrecioPorTipo(19))).ToString(), font9);
            document.Add(Rectangular);
            document.Add(new Chunk("\n"));


            //foreach (DataColumn c in cell.)
            //{
            //    PdfPCell celdatitulo = new PdfPCell();
            //    celdatitulo.VerticalAlignment = Element.ALIGN_MIDDLE;
            //    celdatitulo.HorizontalAlignment = Element.ALIGN_CENTER;
            //    Phrase phrase = new Phrase(c.ColumnName, font9);
            //    celdatitulo.BackgroundColor = new BaseColor(91, 203, 223);
            //    celdatitulo.Phrase = phrase;

            //    table.AddCell(celdatitulo);
            //}

            //foreach (DataRow r in dt.Rows)
            //{
            //    if (dt.Rows.Count > 0)
            //    {

            //        for (int h = 0; h < dt.Columns.Count; h++)
            //        {
            //            if (Convert.ToString(r[1]) == "0")
            //            {
            //            }
            //            else
            //            {
            //                PdfPCell celda = new PdfPCell();
            //                celda.BackgroundColor = new BaseColor(180, 214, 220);

            //                if (h == 6)
            //                {
            //                    iTextSharp.text.Image producto = iTextSharp.text.Image.GetInstance(r[h].ToString());
            //                    producto.ScaleToFit(500f, 30f);
            //                    celda.Image = producto;
            //                    table.AddCell(celda);
            //                }
            //                else
            //                {
            //                    celda.VerticalAlignment = Element.ALIGN_MIDDLE;
            //                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
            //                    Phrase phrase = new Phrase(r[h].ToString(), font9);
            //                    celda.Phrase = phrase;
            //                    table.AddCell(celda);
            //                }
            //            }

            //        }
            //    }
            //}
            //document.Add(table);




            document.Close();


            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Pedido" + ".pdf");
            HttpContext.Current.Response.Write(document);
            Response.Flush();
            Response.End();
        }
    }
}