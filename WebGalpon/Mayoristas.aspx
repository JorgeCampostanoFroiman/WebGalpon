<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mayoristas.aspx.cs" Inherits="WebGalpon.Mayoristas" MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/Mayoristas.css" rel="Stylesheet" type="text/css" />

        <div style="margin:50px 0 30px 0;text-align:center">
      <h1>NUESTROS PRODUCTOS      </h1> 
      </div>
    <div class="searchbar">
        <asp:TextBox ID="BarraBusqueda" placeholder="Búsqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" runat="server" OnClick="BotonBusqueda_Click" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" runat="server" OnClick="Refrescar_Click" class="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
    </div>
    

    <table class="table table-striped mt-5" style="background-color:#b6d1d4" id="">
  <thead class="thead-dark">

    <tr>
      <th scope="col">Codigo</th>
      <th scope="col">Nombre</th>
      <th scope="col">Imagen</th>
      <th scope="col">Tipo</th>
      <th scope="col">Precio</th>
      <th scope="col">Carrito</th>
      <th scope="col">Detalle</th>

    </tr>
  </thead>
  <tbody>
      <% foreach (domain.Producto item in listaMayoristas)
          {%>
      <tr>
      <th scope="row"><% = item.Codigo %></th>
      <td><% = item.NombreProducto %></td> 
      <td id="tdimg" class="tdimg"> <img style="width:33px;" src="<% = item.ImagenUrl %>"/></td>
      <td><% = item.Tipo %></td>
      <td><% = item.PrecioVenta %></td> 
      <td><a href="Carrito.aspx?id=<% = item.ImagenUrl%>" style="color:mintcream;" target="_blank" rel="noopener noreferrer"  class="btn btn-dark btn-sm">Agregar al carrito</a></td>
      <td><a class="btn btn-dark btn-sm" href="DetalleProducto.aspx?id=<% = item.Codigo%>" style="color:mintcream;" target="_blank" rel="noopener noreferrer"> Ver detalle</a></td>
      </tr>
      
       <% } %>
      </tbody>

  

   </table>

    <script>
        function databind() {
            alert(document.getElementById('.tdimg'));
        }

    </script>

</asp:Content>
