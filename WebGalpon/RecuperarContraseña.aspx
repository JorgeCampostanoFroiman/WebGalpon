<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits="WebGalpon.RecuperarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="CSS/login.css" rel="stylesheet" type="text/css" />

     <body class="main-bg">
        <div class="login-container text-c animated flipInX">
                                  
                    <p class="text-black">Colocá tu dirección de correo asociado a tu cuenta y presioná el botón para recuperar la contraseña</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group" style="text-align:center">
                            

                            <asp:TextBox runat="server" placeholder="Dirección de correo" ID="Email" class="form-control"></asp:TextBox>

             
                        </div>
                        <asp:Button runat="server" class="btn btn-dark btn-sm" id="btnOlvido" Text="Aceptar"/>
                        
                        <a class="btn btn-dark btn-sm" href="Registrarse.aspx"">Registrarse!</a>
                    </form>
                    <p class="margin-t text-whitesmoke"><small> El galpón de los Cuadros &copy; 2024</small> </p>
                </div>
            </div>
</body>

</asp:Content>
