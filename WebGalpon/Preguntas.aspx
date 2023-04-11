<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Preguntas.aspx.cs" Inherits="WebGalpon.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <div class="container" style="text-align:center;align-items:center;width:60vw;">
    <link href="CSS/FAQ.css" rel="Stylesheet" type="text/css" />


       <div style="margin:50px 0 30px 0;text-align:center;background-color:white;width:60vw;padding:10px;border: 2px solid grey;">
     
      <h1 >Preguntas Frecuentes</h1> 
        <hr />

    <div class="searchbar" style="text-align:center;align-content:center;align-items:center">
        <asp:TextBox ID="BarraBusqueda" placeholder="Ingrese la busqueda" Width="400px" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusqueda" OnClick="BotonBusqueda_Click" runat="server"  Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="Refrescar" OnClick="Refrescar_Click" runat="server"  Text="Refrescar" AutoPostBack="true"/>
    </div>
           <hr />
    <h2> Si no encontrás la respuestas que buscas... </h2>
      <h2>...podes contactarnos por <a class="whatsanchor" href="https://wa.me/1133467922">Aquí</a></h2>
 
        
        <hr />
           </div>
        <div style="text-align:center;">

            <asp:Label runat="server" ID="LabelBusqueda" Font-Size="XX-Large"  Visible="false"></asp:Label>

     <div class="accordion-body">
  <div class="accordion">
      <hr>
      <% foreach (domain.PreguntaFrecuente item in listaPreguntas)
        {%>


    
    <div class="container">
      <div class="label"><%= item.Pregunta %></div>
      <div class="content"><%= item.Respuesta  %></div>
    </div>
      <hr>
       <% } %>

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
</asp:Content>