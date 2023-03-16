<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InfoMayoristas.aspx.cs" Inherits="WebGalpon.InfoMayoristas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <link href="CSS/Preguntas.css" rel="Stylesheet" type="text/css" />
    <div style="text-align:center;align-items:center;width:60vw;">

        <div style="margin:50px 0 30px 0;text-align:center;background-color:white;width:60vw;padding:10px;border: 2px solid grey;">
     <div>
      <h1> ¿Cómo funciona la compra mayorista? </h1> 
         <hr />
       <h2> En esta página está toda la info que necesitas saber</h2>
      </div>
      
        <hr />

    <div class="searchbar" style="text-align:center;align-content:center;align-items:center">
        <asp:TextBox ID="BarraBusqueda" placeholder="Ingrese la busqueda" Width="400px" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server"  Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server"  Text="Refrescar" AutoPostBack="true"/>
    </div>
           <hr />
           </div>
        <div style="text-align:center;">

            <asp:Label runat="server" ID="LabelBusqueda" Font-Size="XX-Large"  Visible="false"></asp:Label>

    <% foreach (domain.InfoMayorista item in listaMayo)
        {%>
      <h3 style="color:slategrey;width:60vw;height:5vh;text-align:left" class="card-title"> <% =item.Titulo %></h3>
        <hr />
      <p style="width:60vw;height:5vh;text-align:right;align-content:center;margin-bottom:10px" class="card-text"><% =item.Descripcion %></p>
      <p style="width:60vw;height:5vh;text-align:right;align-content:center;margin-bottom:10px" class="card-text"><% =item.Descripcion2 %></p>
      <% } %>
            </div>
       <hr />
    
        
    <div class="banner-info">
           <h1 style="color:slategrey">Si te queda alguna duda acerca de la compra mayorista...</h1>
           <h2 style="color:slategrey">...podes contactarnos con nosotros... <a class="whatsanchor" href="https://wa.me/1133467922">Acá</a></h2>
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
