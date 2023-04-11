<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mayoristas.aspx.cs" Inherits="WebGalpon.Mayoristas" MaintainScrollPositionOnPostback="true"  %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/mayoristas.css" rel="Stylesheet" type="text/css" />
   <style>
      
   </style>
    <div class="searchbar">
        <asp:TextBox ID="BarraBusqueda" placeholder="Búsqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server" class="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
    </div>
        
    <div class="accordion-body">
  <div class="accordion">
    <h1>Productos</h1>

      <% foreach (domain.Tipo item in listaTipos)
          {%>

    <hr>
    <div class="container">
      <div class="label"><% = item.Nombre %></div>

         <% foreach (domain.Producto prod in listaMayoristas)
             {%>

      <div class="content"><% = prod.Codigo + " " +  prod.Tipo + " " + prod.NombreProducto %> <img src="<%= prod.ImagenUrl %>" style="height:10vw;" /></div>
    
        <% } %>
    
    </div>

      
       <% } %>

      </div></div>




     

      

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
