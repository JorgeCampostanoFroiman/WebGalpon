<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebGalpon.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="CSS/CONTACT.css" rel="Stylesheet" type="text/css" />

    

    <body class="main-bg">
        <hr />
        <div class="contact-title"><h1>Contacto</h1></div>
        <hr />
        <div class="contact-form">
            <div class="contact-subtitle">
                <h3 style="width:80%;margin:auto;">Dejanos tu nombre y mensaje y responderemos a la brevedad!</h3>
            </div>

            <div class="contact-name">
                <asp:TextBox runat="server" ID="NameBox" type="text" CssClass="form-control" placeholder="Nombre" required=""></asp:TextBox>
            </div>

            <div class="contact-email">
                <asp:TextBox runat="server" ID="EmailBox" type="email" CssClass="form-control" placeholder="Email" required=""></asp:TextBox>
            </div>

            <div class="contact-subject" style="text-align:center; margin:auto">
                 <asp:TextBox runat="server" ID="SubjectBox" type="text" CssClass="form-control" placeholder="Asunto" required=""></asp:TextBox>       
            </div>

            <div class="contact-text">
                <asp:TextBox runat="server" ID="MessageBox" type="text" CssClass="form-control" placeholder="Mensaje" required=""></asp:TextBox>
            </div>  
            
            <div class="contact-submit">
                <asp:Button type="submit" CssClass="form-button" runat="server" ID="SendButton" Text="Enviar" OnClick="SendButton_Click" />
            </div>  
        </div>

       
         <div class="info-contacto">
             <hr />
        <div class="info"><svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor" class="bi bi-whatsapp" viewBox="0 0 16 16">
  <path d="M13.601 2.326A7.854 7.854 0 0 0 7.994 0C3.627 0 .068 3.558.064 7.926c0 1.399.366 2.76 1.057 3.965L0 16l4.204-1.102a7.933 7.933 0 0 0 3.79.965h.004c4.368 0 7.926-3.558 7.93-7.93A7.898 7.898 0 0 0 13.6 2.326zM7.994 14.521a6.573 6.573 0 0 1-3.356-.92l-.24-.144-2.494.654.666-2.433-.156-.251a6.56 6.56 0 0 1-1.007-3.505c0-3.626 2.957-6.584 6.591-6.584a6.56 6.56 0 0 1 4.66 1.931 6.557 6.557 0 0 1 1.928 4.66c-.004 3.639-2.961 6.592-6.592 6.592zm3.615-4.934c-.197-.099-1.17-.578-1.353-.646-.182-.065-.315-.099-.445.099-.133.197-.513.646-.627.775-.114.133-.232.148-.43.05-.197-.1-.836-.308-1.592-.985-.59-.525-.985-1.175-1.103-1.372-.114-.198-.011-.304.088-.403.087-.088.197-.232.296-.346.1-.114.133-.198.198-.33.065-.134.034-.248-.015-.347-.05-.099-.445-1.076-.612-1.47-.16-.389-.323-.335-.445-.34-.114-.007-.247-.007-.38-.007a.729.729 0 0 0-.529.247c-.182.198-.691.677-.691 1.654 0 .977.71 1.916.81 2.049.098.133 1.394 2.132 3.383 2.992.47.205.84.326 1.129.418.475.152.904.129 1.246.08.38-.058 1.171-.48 1.338-.943.164-.464.164-.86.114-.943-.049-.084-.182-.133-.38-.232z"/>
</svg> <div class="texto">11-3684-6793</div></div>
             <hr />
        <div class="info"><svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor" class="bi bi-envelope" viewBox="0 0 16 16">
  <path d="M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4Zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1H2Zm13 2.383-4.708 2.825L15 11.105V5.383Zm-.034 6.876-5.64-3.471L8 9.583l-1.326-.795-5.64 3.47A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.741ZM1 11.105l4.708-2.897L1 5.383v5.722Z"/>
</svg> <div class="texto">elgalpondeloscuadros@gmail.com</div></div>
             <hr />
        <div class="info"><svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor" class="bi bi-clock" viewBox="0 0 16 16">
  <path d="M8 3.5a.5.5 0 0 0-1 0V9a.5.5 0 0 0 .252.434l3.5 2a.5.5 0 0 0 .496-.868L8 8.71V3.5z"/>
  <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm7-8A7 7 0 1 1 1 8a7 7 0 0 1 14 0z"/>
</svg> <div class="texto">Lunes a Viernes 10hs a 17hs</div></div>
             <hr />
        </div>
    
                       
        </body>
    </asp:Content> 
<%--<div class="login-container text-c animated flipInX">            
                    <p class="form-text" color="red">Contactanos!</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group">
                            <input style="text-align:center; margin:auto" type="email" class="form-control"  placeholder="E-mail" required="">
                        </div>
                        <div class="form-group">
                            <input style="text-align:center; margin:auto" type="text" class="form-control" placeholder="Ingrese su mensaje aquí" required="">
                        </div>
                        <button type="submit" class="form-button button-l margin-b">Enviar!</button>
                    </form>
                </div>
            </div>--%>