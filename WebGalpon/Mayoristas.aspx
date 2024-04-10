<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mayoristas.aspx.cs" Inherits="WebGalpon.Mayoristas" MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

     <div class="container" style="text-align:center;align-items:center">
    <link href="CSS/MAYORISTA.css" rel="Stylesheet" type="text/css" />

         <hr />
       <div class="contact-title">
           
           <h1> Listado de Productos </h1> 

       </div>
        <hr />
         <div class="contact-subtitle">
             <div class="contact-form">

        <asp:TextBox ID="BarraBusqueda" placeholder="Ingrese la busqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server" CLASS="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server" CLASS="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
             </div>
              
         </div>
        <hr />

        <div style="text-align:center;">

            <asp:Label runat="server" ID="LabelBusqueda" Font-Size="XX-Large"  Visible="false"></asp:Label>

             <div class="accordion-body">
  <div class="accordion">
      <div class="container">
      <div class="label"> <h1>Cuadros Rectangulares</h1>
       <div class="content">
           <h3>Codigo</h3>
           <h3 style="width:16vh">Nombre</h3>
           <h3>Imagen</h3>
           <h3>Ver detalle</h3>
           <h3>Agregar</h3>
       </div>
      <% foreach (domain.Producto item in listaProductos)
          { if (item.Tipo == "Cuadro Rectangular" || item.Tipo == "Cuadro triptico") 
              { %>
          
      <div class="content" style="">
          <p><%= item.Codigo %></p>
          <p style="width:16vh"><%= item.NombreProducto%></p>
          <img class="card-img-top" style="height:6vh;width:auto" src="<%= item.ImagenUrl %>"></>
          <a class="content-anchor" style="font-size:large" target="_blank" href="DetalleProducto.aspx?id=<%= item.Codigo %>">Ver más</a>
          <a target="_blank" href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
      </div>
       <% }
           } %>
        </div>
    </div>
</div>
  </div>

            <div class="accordion-body">
  <div class="accordion">
      <div class="container">
      <div class="label"><h1>Portallaves</h1> 
       <div class="content">
           <h3>Codigo</h3>
           <h3 style="width:16vh">Nombre</h3>
           <h3>Imagen</h3>
           <h3>Ver detalle</h3>
           <h3>Agregar</h3>
       </div>
      <% foreach (domain.Producto item in listaProductos)
          { if (item.Tipo == "Portallaves")
              { %>
          
      <div class="content" style="">
          <p><%= item.Codigo %></p>
          <p style="width:16vh"><%= item.NombreProducto%></p>
          <img class="card-img-top" style="height:6vh;width:auto" src="<%= item.ImagenUrl %>"></>
          <a class="content-anchor" style="font-size:large" target="_blank" href="DetalleProducto.aspx?cat=<%= item.IdProducto %>">Ver más</a>
          <a target="_blank" href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
      </div>
       <% }
           } %>
        </div>
    </div>
</div>
  </div>


            <div class="accordion-body">
  <div class="accordion">
      <div class="container">
      <div class="label"><h1> Percheros</h1>
       <div class="content">
           <h3>Codigo</h3>
           <h3 style="width:16vh">Nombre</h3>
           <h3>Imagen</h3>
           <h3>Ver detalle</h3>
           <h3>Agregar</h3>
       </div>
      <% foreach (domain.Producto item in listaProductos)
          { if (item.Tipo == "Perchero")
              { %>
          
      <div class="content" style="">
          <p><%= item.Codigo %></p>
          <p style="width:16vh"><%= item.NombreProducto%></p>
          <img class="card-img-top" style="height:6vh;width:auto" src="<%= item.ImagenUrl %>"></>
          <a class="content-anchor" style="font-size:large" target="_blank" href="DetalleProducto.aspx?cat=<%= item.IdProducto %>">Ver más</a>
          <a target="_blank" href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
      </div>
       <% }
           } %>
        </div>
    </div>
</div>
  </div>

<div class="accordion-body">
  <div class="accordion">
      <div class="container">
      <div class="label"> <h1>Relojes</h1>
       <div class="content">
           <h3>Codigo</h3>
           <h3 style="width:16vh">Nombre</h3>
           <h3>Imagen</h3>
           <h3>Ver detalle</h3>
           <h3>Agregar</h3>
       </div>
      <% foreach (domain.Producto item in listaProductos)
          { if (item.Tipo == "Relojes")
              { %>
          
      <div class="content" style="">
          <p><%= item.Codigo %></p>
          <p style="width:16vh"><%= item.NombreProducto%></p>
          <img class="card-img-top" style="height:6vh;width:auto" src="<%= item.ImagenUrl %>"></>
          <a class="content-anchor" style="font-size:large" target="_blank" href="DetalleProducto.aspx?cat=<%= item.IdProducto %>">Ver más</a>
          <a target="_blank" href="Carrito.aspx?id=<% = item.Codigo %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
      </div>
       <% }
           } %>
        </div>
    </div>
</div>
  </div>



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

    <script>
        var acc = document.getElementsByClassName("accordion");
        var i;

        for (i = 0; i < acc.length; i++) {
            acc[i].addEventListener("click", function () {
                this.classList.toggle("active");
                var panel = this.nextElementSibling;
                if (panel.style.display === "block") {
                    panel.style.display = "none";
                } else {
                    panel.style.display = "block";
                }
            });
        }
    </script>

    <script>
        function databind() {
            alert(document.getElementById('.tdimg'));
        }

    </script>
    <script>
        const accordion = document.getElementsByClassName('container');

        for (i = 0; i < accordion.length; i++) {
            accordion[i].addEventListener('click', function () {
                this.classList.toggle('active')
            })
        }
    </script>




   
    <hr />





</asp:Content>
<%-- <div class="accordion-body">
  <div class="accordion">
      <hr>
      <% foreach (domain.Producto item in listaMayoristas)
        {%>


    
    <div class="container">
      <div class="label"><%= item.NombreProducto%></div>
      <div class="content"><%= item.Tipo  %></div>
    </div>
      <hr>
       <% } %>

  </div>
  </div>--%>