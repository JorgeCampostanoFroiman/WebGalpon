<%@ Page Title="DetalleProducto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebGalpon.DetalleProducto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <link href="CSS/detalleproducto.css" rel="Stylesheet" type="text/css" />
        <hr />
    <h2 class="details-title">Detalle del producto</h2>
    <hr />
    <div class="cardflex2" >
    
  <div class="card2" style=" align-items:center; margin-right:15px; margin-bottom:15px; text-align:center;border: 2px solid;  background-color: var(--crema1); border-color:var(--violeta1) ">
    <asp:Image runat="server" ID="imagenProducto" CssClass="main-img"/>

    <div class="card-body2">
                <p class="form-button"><asp:Label runat="server" ID="labelNombre" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
                <p class="form-button"><asp:Label runat="server" ID="labelPrecio" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
               
                <p class="form-button"><asp:Label runat="server" ID="labelDescripcion"></asp:Label></p>
                <p class="form-button"><asp:DropDownList runat="server" ID="ddlVariantes" OnSelectedIndexChanged="ddlVariantes_SelectedIndexChanged" AutoPostBack="true" ></asp:DropDownList></p>
                
                <asp:Button runat="server" ID="btnCarrito" Text="Agregar" OnClick="btnCarrito_Click" />
                <a class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="labelVolver"></asp:Label></a>
                <a class="btn" href="Productos.aspx">Ir a productos</a>
                </div>
      </div>
  </div>
            




    <hr />
    <h2 class="details-title">Otras medidas </h2>
    <hr />

    <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Producto item in listaMedidas)
        {%>
  <div class="card" style=" align-items:center; margin-right:15px; margin-bottom:15px; text-align:center;border: 2px solid;  background-color: var(--crema1); border-color:var(--violeta1) ">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" style="height: 100px; width:100px; margin-top:5px;" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title"> <% =item.NombreProducto %></h5>
      <p class="card-text"><% =item.Descripcion %></p>
      <p style="margin-bottom:5px;" class="card-text"> $<% =item.PrecioVenta %></p>
      <a href="DetalleProducto.aspx?id=<% = item.Codigo%>" class="btn btn-dark btn-sm">Ver Detalle</a>
        <a href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
    </div>
  </div>
      <% } %>
 </div>


    
    <hr />

     <h2 class="details-title">Recomendados</h2>
    <hr />
    <div class="related-images">

        <div class="related-item">
            <asp:Image runat="server" ID="image11" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related1"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp1" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>

        <div class="related-item">
            <asp:Image runat="server" ID="image12" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related2"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp2" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>

        <div class="related-item">
            <asp:Image runat="server" ID="image13" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related3"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp3" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>
        
    </div>

</asp:Content>
