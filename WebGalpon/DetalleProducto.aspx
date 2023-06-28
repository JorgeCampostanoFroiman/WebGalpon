<%@ Page Title="DetalleProducto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebGalpon.DetalleProducto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
   
    <div class="container" style="text-align:center;align-content:center;align-items:center;">
    <link href="CSS/DetalleProducto.css" rel="Stylesheet" type="text/css" />
        <hr />
        <div class="content-title">
            
    <h2>Detalle del producto</h2>


        </div>
    <hr />

        <div class="content-form">
 <div >
    <div class="breadcrumb" style="background-color:white">
        <a class="link" href="Home.aspx">Inicio</a> 
        <a class="link" href="Productos.aspx">Productos</a>
        <asp:HyperLink CssClass="link" runat="server" ID="HL2"></asp:HyperLink>
        <asp:HyperLink CssClass="link" runat="server" ID="HL3"></asp:HyperLink> 
        <a class="link"  id="linkwpp" href="https://api.whatsapp.com/send?text=[text]"><label>Compartir </label><svg id="s3" xmlns="http://www.w3.org/2000/svg" style="padding:10px 15px;color: #25D366" width="90" height="90" fill="|Color" class="bi bi-whatsapp" viewBox="0 0 16 16">
  <path d="M13.601 2.326A7.854 7.854 0 0 0 7.994 0C3.627 0 .068 3.558.064 7.926c0 1.399.366 2.76 1.057 3.965L0 16l4.204-1.102a7.933 7.933 0 0 0 3.79.965h.004c4.368 0 7.926-3.558 7.93-7.93A7.898 7.898 0 0 0 13.6 2.326zM7.994 14.521a6.573 6.573 0 0 1-3.356-.92l-.24-.144-2.494.654.666-2.433-.156-.251a6.56 6.56 0 0 1-1.007-3.505c0-3.626 2.957-6.584 6.591-6.584a6.56 6.56 0 0 1 4.66 1.931 6.557 6.557 0 0 1 1.928 4.66c-.004 3.639-2.961 6.592-6.592 6.592zm3.615-4.934c-.197-.099-1.17-.578-1.353-.646-.182-.065-.315-.099-.445.099-.133.197-.513.646-.627.775-.114.133-.232.148-.43.05-.197-.1-.836-.308-1.592-.985-.59-.525-.985-1.175-1.103-1.372-.114-.198-.011-.304.088-.403.087-.088.197-.232.296-.346.1-.114.133-.198.198-.33.065-.134.034-.248-.015-.347-.05-.099-.445-1.076-.612-1.47-.16-.389-.323-.335-.445-.34-.114-.007-.247-.007-.38-.007a.729.729 0 0 0-.529.247c-.182.198-.691.677-.691 1.654 0 .977.71 1.916.81 2.049.098.133 1.394 2.132 3.383 2.992.47.205.84.326 1.129.418.475.152.904.129 1.246.08.38-.058 1.171-.48 1.338-.943.164-.464.164-.86.114-.943-.049-.084-.182-.133-.38-.232z"/>
</svg></a></div>

  <div class="card2" style=" align-items:center; line-height:3vw; padding:10px; display:flex; margin-right:15px; margin:15px 0; text-align:center; border: 2px solid;  border-color:var(--violeta1);border-radius:10px ">
   
      <div class="imgcard" >
          <asp:Image runat="server" ID="imagenProducto"  CssClass="main-img" />
      </div>
      

    <div class="card-body2" style="padding-left:30px;border: 2px SOLID grey; width:50%; border-radius:10px">
                <p class="form-button"><asp:Label runat="server" ID="labelNombre" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
        <hr />
                <p class="form-button"><asp:Label runat="server" ID="labelPrecio" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
                <hr />
                <p class="form-button"><asp:Label runat="server" ID="labelDescripcion"></asp:Label></p>
                 <hr />
                
                <asp:Button CssClass="btn btn-dark btn-sm" runat="server" ID="btnCarrito" Text="Agregar" OnClick="btnCarrito_Click" />
                <a class="btn btn-dark btn-sm" href="Productos.aspx"><asp:Label runat="server" ID="labelVolver"></asp:Label></a>
           </div>
      </div>
  </div>


        </div>


   
            




    <hr />
    <h2 class="content-title">Otras medidas </h2>
    <hr />

        <div class="content-form">
            <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(20rem, 1fr) ); " >
    <% foreach (domain.Producto item in listaMedidas)
        {%>
  <div class="card" style=" align-items:center; margin-right:15px; margin-bottom:15px; text-align:center; ">
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
        </div>
    


    
    <hr />

     <h2 class="content-title">Recomendados</h2>
    <hr />
        <div class="content-form">
            <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(20rem, 1fr) ); " >
    <% foreach (domain.Producto item in listaRecomendados)
        {%>
  <div class="card" style=" align-items:center; margin-right:15px; margin-bottom:15px; text-align:center; ">
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
    </div>

        <hr />
        </div>
        
    

</asp:Content>
