<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebGalpon.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="CSS/login.css" rel="stylesheet" type="text/css" />

       <body class="main-bg">
        <div class="login-container text-c animated flipInX">
                                  
                    <p class="text" color="red" >Ingreso de usuarios</p>
                <div class="container-content">
                    <form class="margin-t">
                        <div class="form-group">
                            <input style="text-align:center; margin:auto" type="text" class="form-control"  placeholder="Usuario" required="">
                        </div>
                        <div class="form-group">
                            <input style="text-align:center; margin:auto" type="password" class="form-control" placeholder="*****" required="">
                        </div>
                        <button type="submit" class="form-button button-l margin-b">Ingresar</button>
        
                        <a class="text-darkyellow" href="#">¿Olvidaste tu contraseña?</></a>
                        <p class="text-whitesmoke text-center">¿No tenés una cuenta?</></p>
                        <a class="text-darkyellow" href="Registro.aspx"">Registrarse!</></a>
                    </form>
                    <p class="margin-t text-whitesmoke"> El Galpón de los Cuadros &copy; 2022</> </p>
                </div>
            </div>
</body>

    </asp:Content>