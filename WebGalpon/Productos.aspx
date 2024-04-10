<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebGalpon.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/Productos.css" rel="Stylesheet" type="text/css" />
    <hr />
       <div class="contact-title" >
      <h1>Productos</h1> 
      </div>    
    <hr />
    <div class="contact-form" style="text-align:center;">

        <asp:TextBox ID="BarraBusquedaProd" placeholder="Búsqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusquedaProd" OnClick="BotonBusquedaProd_Click" runat="server" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="RefrescarProd" OnClick="RefrescarProd_Click" runat="server" class="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
    
    </div>
    <hr />
    <div class="contact-form" style="display:flex;justify-content:center;flex-wrap:wrap;">
        <% foreach (domain.Tematica item in listaTematicas) 
            {%>
        <a class="btn btn-dark" style="margin:2px;" href="Productos.aspx?tem=<%= item.Id %>"><%=item.Nombre %> </a>
           <%  }%>
    </div>
    <hr />
   <div class="contact-form">
        <div class="cardflex" style="display:grid;grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Producto item in listaMinoristas)
        {%>
  <div class="card" style=" align-items:center; text-align:center;">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" " alt="Card image cap">
      
    <div class="card-body">
        <hr />
      <h5 class="card-title"> <% =item.Codigo %></h5>
      <%--<p class="card-text"><% =item.Descripcion %></p>
      <p style="font-weight:bold;font-size:xx-large;margin-bottom:5px;" class="card-text"> $<%=(int)Decimal.Truncate(item.PrecioVenta) %></p>--%>
      <a href="DetalleProducto.aspx?id=<% = item.Codigo%>" class="btn btn-dark btn-sm">Ver Detalle</a>
        <a href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm" target="_blank" style="margin:1vh;">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
    </div>
  </div>
      <% } %>
 </div>


   </div>
    <hr />
   


</asp:Content>




