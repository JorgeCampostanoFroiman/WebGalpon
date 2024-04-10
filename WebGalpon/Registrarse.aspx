<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="WebGalpon.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <link href="CSS/login.css" rel="stylesheet" type="text/css" />

     <body class="main-bg">
        <div class="login-container text-c animated flipInX">
                                  
                    <p class="text-black">Registro de usuarios</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group" style="text-align:center">
                            
                        <asp:TextBox runat="server" placeholder="Nombre de Usuario" ID="textUsuario" class="form-control"></asp:TextBox>
                        
                        <asp:TextBox runat="server" placeholder="Contraseña" ID="textContraseña" class="form-control"></asp:TextBox>

                            <asp:TextBox runat="server" placeholder="Dirección de correo" ID="Email" class="form-control"></asp:TextBox>

                            <asp:Label runat="server" ID="labelLogueado" Visible="false" ></asp:Label>
             
                        </div>
                        <asp:Button runat="server" class="btn btn-dark btn-sm" id="btnRegistro" Text="Registrarse"/>
                        
                        <a class="btn btn-dark btn-sm" href="RecuperarContraseña.aspx">¿Olvidaste tu contraseña?</a>
                        <%--<a class="btn btn-dark btn-sm" href="Registrarse.aspx"">Registrarse!</a>--%>
                    </form>
                    <p class="margin-t text-whitesmoke"><small> El galpón de los Cuadros &copy; 2024</small> </p>
                </div>
            </div>
</body>


</asp:Content>
