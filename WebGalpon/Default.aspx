<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebGalpon._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
                    
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" style="margin-top:15px">                     
                      <div class="carousel-inner">
                        <div class="carousel-item active">
                          <img class="d-block w-100" src="https://markepymes.com/wp-content/uploads/2018/05/como-vender-mas-en-una-tienda-de-pequenos-electrodomesticos.jpg" alt="First slide"
                              style="height:500px;">
                        </div>
                        <div class="carousel-item">
                          <img class="d-block w-100" src="https://www.cronista.com/files/image/292/292304/5ffe051166608.jpg" alt="Second slide"
                             style="height:500px;">
                        </div>
                        <div class="carousel-item">
                          <img class="d-block w-100" src="https://www.themarkethink.com/wp-content/uploads/2017/01/el-aro-3.jpg" alt="Third slide"
                              style="height:500px;">
                        </div>
                      </div>
                      <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                      </a>
                      <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                      </a>
                    </div>

    <div class="jumbotron">
    <div class="input-group rounded" style="display:flex;align-items:center;justify-content:center;">
  <asp:TextBox ToolTip="Ingrese su busqueda"  Placeholder="Ingrese busqueda aqui" runat="server" style="width:700px"  />
  <asp:Button runat="server" style="width:100px" Text="Search" />
    </div>
  <hr class="my-4">
  <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
  <p class="lead">
    <a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a>
  </p>
</div>



  <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Producto item in lista)
        {%>
  <div class="card" style="height:250px; align-items:center">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" style="height: 100px; width:100px;" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title"> <% =item.NombreProducto %></h5>
      <p class="card-text"><% =item.Descripcion %></p>
      <p class="card-text"><% =item.PrecioVenta %></p>
    </div>
  </div>
      <% } %>
 </div>
 

</asp:Content>