<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InfoMayoristas.aspx.cs" Inherits="WebGalpon.InfoMayoristas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/Infomayoristas.css" rel="Stylesheet" type="text/css" />

        <div>
      <h1> ¿Cómo funciona la compra mayorista? </h1> 
       <h2> En esta página está toda la info que necesitas saber</h2>
      </div>

    <div class="contenedor">

        <div class="mayoristas-cards">
            <div class="mayo-card">
                <h3>Monto mínimo de compra</h3>
                <p>$20000</p>
                <p>Hace click para ir al listado mayorista</p>
                <a class="btn btn-dark btn-sm" >Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Personalizados mayoristas</h3>
                <p>Mínimo 4 cuadros del modelo personalizado</p>
                <p>Para info personalizados, click debajo</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Métodos de pago</h3>
                <p>Mercado Pago</p>
                <p>Efectivo</p>
            </div>

        </div>

        <div class="mayoristas-cards">
             <div class="mayo-card">
                <h3>Como hacer un pedido?</h3>
                <p>Debes tener una cuenta</p>
                <p>Agregas al carrito todos los productos que deseas pedir</p>
                <p>Ingresando al carrito, tenes la opcion de descargar un pdf con el listado</p>
            </div>

            <div class="mayo-card">
                <h3>Podes ver los productos en más detalle</h3>
                <p>Tenes toda la información necesaria y fotos de muestra</p>
                <p>Click debajo para ver todos los productos</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>

            <div class="mayo-card">
                <h3>Recomendaciones</h3>
                <p>Tenes dudas de que productos vender?</p>
                <p>Necesitas ayuda para comenzar?</p>
                <p>Haciendo click abajo podes ver nuestras sugerencias</p>
                <a class="btn btn-dark btn-sm">Saber más</a>
            </div>
        </div>

       
    </div>
        
    <div class="banner-info">
           <h1>Si te queda alguna duda acerca de la compra mayorista...</h1>
           <h2>¡Podes contactarte con nosotros! </h2>
           <a class="btn btn-dark btn-sm">Saber más</a>
       </div>




</asp:Content>
