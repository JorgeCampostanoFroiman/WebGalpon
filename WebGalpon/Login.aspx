<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebGalpon.Login" EnableEventValidation="false" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="CSS/login.css" rel="stylesheet" type="text/css" />

     <body class="main-bg">
        <div class="login-container text-c animated flipInX">
                                  
                    <p class="text-black">Ingreso de usuarios</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group" style="text-align:center">
                            
                        <asp:TextBox runat="server" placeholder="Usuario" ID="textUsuario" class="form-control"></asp:TextBox>
                        
                        <asp:TextBox runat="server" placeholder="*****" ID="textContraseña" class="form-control"></asp:TextBox>

                            <asp:Label runat="server" ID="labelLogueado" Visible="false" ></asp:Label>
             
                        </div>
                        <asp:Button runat="server" class="btn btn-dark btn-sm" id="btnIngreso" OnClick="btnIngreso_Click" Text="Ingresar"/>
                        
                        <a class="btn btn-dark btn-sm" href="RecuperarContraseña.aspx">¿Olvidaste tu contraseña?</a>
                        <a class="btn btn-dark btn-sm" href="Registrarse.aspx"">Registrarse!</a>
                        <asp:Button runat="server" class="btn btn-dark btn-sm" ID="btnDesloguear" AutoPostBack="true" OnClick="btnDesloguear_Click" style="margin-top:10px" Visible="false" Text="Desloguearse" />
                    </form>
                    <p class="margin-t text-whitesmoke"><small> El galpón de los Cuadros &copy; 2024</small> </p>
                </div>
            </div>
</body>

    </asp:Content>