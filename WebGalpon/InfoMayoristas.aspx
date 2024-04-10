<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InfoMayoristas.aspx.cs" Inherits="WebGalpon.InfoMayoristas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <link href="CSS/infoMayorista.css" rel="Stylesheet" type="text/css" />
        <hr />
        <div class="contact-title">
      <h1 class="title"> ¿Cómo funciona la compra mayorista? </h1> 
         </div>
            <hr />
        <div class="contact-form">
            <h2 class="title"> En esta página está toda la info que necesitas saber</h2>
        </div>

       
     
      <hr />
        <div class="contact-form" style="text-align:center;">

        <asp:TextBox ID="BarraBusqueda" placeholder="Ingrese la busqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server" CLASS="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>

            
        </div>
       <hr />
           
        <div class="contact-form" style="text-align:center;">

            
            <asp:Label runat="server" ID="LabelBusqueda"  Visible="false"></asp:Label>
    
           <div class="accordion-body">
  <div class="accordion">   
      <% foreach (domain.InfoMayorista item in listaMayo)
        {%>


    
    <div class="container">
      <div class="label" style="font-weight:bold;font-size:xx-large;"><%= item.Titulo %></div>
      <div class="content"><%= item.Descripcion + " " + item.Descripcion2 %></div>
        <hr>
    </div>
      
       <% } %>

  </div>
  </div>

 




     <script src="index.js" type="text/javascript"></script>
        <script>
            const accordion = document.getElementsByClassName('container');

            for (i = 0; i < accordion.length; i++) {
                accordion[i].addEventListener('click', function () {
                    this.classList.toggle('active')
                })
            }
        </script>
    <div class="banner-info" style="margin:30px;">
           <h1 class="title" style="color:slategrey;">Si te queda alguna duda acerca de la compra mayorista...</h1>
           <h2 class="title" style="color:slategrey">...podes contactarnos con nosotros... <a class="whatsanchor" href="https://wa.me/1133467922">Acá</a></h2>
       </div>


        </div>
</asp:Content>


<%--<div class="mayoristas-cards">
            <div class="mayo-card">
                <h3>Monto mínimo de compra</h3>
                <p>$20000</p>
                <p>Hace click para ir al listado mayorista</p>
                <a class="btn btn-dark btn-sm" >Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Personalizados mayoristas</h3>
                <p>Mínimo 4 cuadros del modelo personalizado</p>
                <p>Para info personalizados, click debajo</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Métodos de pago</h3>
                <p>Mercado Pago</p>
                <p>Efectivo</p>
            </div>

        </div>

        <div class="mayoristas-cards">
             <div class="mayo-card">
                <h3>Como hacer un pedido?</h3>
                <p>Debes tener una cuenta</p>
                <p>Agregas al carrito todos los productos que deseas pedir</p>
                <p>Ingresando al carrito, tenes la opcion de descargar un pdf con el listado</p>
            </div>

            <div class="mayo-card">
                <h3>Podes ver los productos en más detalle</h3>
                <p>Tenes toda la información necesaria y fotos de muestra</p>
                <p>Click debajo para ver todos los productos</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Recomendaciones</h3>
                <p>Tenes dudas de que productos vender?</p>
                <p>Necesitas ayuda para comenzar?</p>
                <p>Haciendo click abajo podes ver nuestras sugerencias</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>
        </div>--%>
