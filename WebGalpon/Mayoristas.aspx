<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mayoristas.aspx.cs" Inherits="WebGalpon.Mayoristas" MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

     <div class="container" style="text-align:center;align-items:center;width:60vw;">
    <link href="CSS/faq.css" rel="Stylesheet" type="text/css" />

         <hr />
       <div class="contact-title">
           
           <h1> Listado de Productos </h1> 

       </div>
        <hr />
         <div class="contact-subtitle">
              <div class="searchbar" style="text-align:center;align-content:center;align-items:center">
        <asp:TextBox ID="BarraBusqueda" placeholder="Ingrese la busqueda" Width="400px" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server"  Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server"  Text="Refrescar" AutoPostBack="true"/>
    </div>
         </div>
        <hr />

        <div style="text-align:center;">

            <asp:Label runat="server" ID="LabelBusqueda" Font-Size="XX-Large"  Visible="false"></asp:Label>

             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Cuadros Rectangulares
          
      <% foreach (domain.Categoria item in listaCategorias)
        {%>
          
      <div class="content"><a class="content-anchor" style="font-size:large" href="Productos.aspx?cat=<%= item.Id %>"><%= item.Nombre%></a> </div>

       <% } %>
        </div>
    </div>
</div>


  </div>

            <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Cuadros Escalonados
          
       <% foreach (domain.Categoria item in listaCategorias)
        {%>
          
       <div class="content"><a class="content-anchor" style="font-size:large" href="Productos.aspx?cat=<%= item.Id %>"><%= item.Nombre%></a> </div>

       <% } %>
        </div>
    </div>
</div>


  </div>

             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Cuadros Individuales (una pieza)
          
      <% foreach (domain.Categoria item in listaCategorias)
        {%>
          
       <div class="content"><a class="content-anchor" style="font-size:large" href="Productos.aspx?cat=<%= item.Id %>"><%= item.Nombre%></a> </div>

       <% } %>
        </div>
    </div>
</div>


  </div>

             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Portallaves
          <div class="content"><a class="content-anchor" href="Productos.aspx?tipo=8">Ir a la sección </a> </div>
     
        </div>
    </div>
</div>


  </div>


             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Percheros
          <div class="content"><a class="content-anchor" href="Productos.aspx?tipo=9">Ir a la sección </a> </div>
    
        </div>
    </div>
</div>


  </div>


             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Relojes   
          <div class="content"><a class="content-anchor" href="Productos.aspx?tipo=10">Ir a la sección </a> </div>
      
        </div>
    </div>
</div>


  </div>

             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Bastidores
          <div class="content"><a class="content-anchor" href="Productos.aspx?tipo=16">Ir a la sección </a> </div>
     
        </div>
    </div>
</div>


  </div>
             <div class="accordion-body">
  <div class="accordion">

      <div class="container">
      <div class="label"> Tablas con frases
          <div class="content"><a class="content-anchor" href="Productos.aspx?tipo=14">Ir a la sección </a> </div>
     
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