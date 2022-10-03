<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebGalpon.Productos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/productos.css" rel="Stylesheet" type="text/css" />
       <div style="margin:50px 0 30px 0;text-align:center">
      <h1>Productos por menor</h1> 
      </div>    

    <div class="searchbar">
        <asp:TextBox ID="BarraBusquedaProd" placeholder="Búsqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusquedaProd" OnClick="BotonBusquedaProd_Click" runat="server" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="RefrescarProd" OnClick="RefrescarProd_Click" runat="server" class="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
    </div>

    <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Producto item in listaMinoristas)
        {%>
  <div class="card" style="height:250px; align-items:center; margin-right:15px; margin-bottom:15px; text-align:center;">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" style="height: 100px; width:100px; margin-top:5px;" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title"> <% =item.NombreProducto %></h5>
      <p class="card-text"><% =item.Descripcion %></p>
      <p style="margin-bottom:5px;" class="card-text"> $<% =item.PrecioVenta %></p>
    </div>
  </div>
      <% } %>
 </div>


</asp:Content>




