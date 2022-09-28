<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebGalpon.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/Productos.css" rel="Stylesheet" type="text/css" />


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




