using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WebGalpon
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void SendButton_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text != null)
            {

                MailMessage ms = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                ms.From = new MailAddress("galponspam@gmail.com");
                ms.To.Add(new MailAddress("j.campostano@hotmail.com"));
                
                ms.Subject = SubjectBox.Text;
                ms.Body = "Mail que envía el mensaje: " + EmailBox.Text + " - " + MessageBox.Text;

                smtp.Host = "smtp.gmail.com"; // para hotmail es "smtp.live.com";
                smtp.Port = 587; //gmail, para hotmail es 25 o 465

                smtp.Credentials = new NetworkCredential("galponcitospam@gmail.com", "iijeranolrwmmtnk");
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