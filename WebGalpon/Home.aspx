<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebGalpon.Home" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="css/Home.css" rel="Stylesheet" type="text/css" />
    <hr />
    <section id="productos">
        

            <div class="content-title" style="margin:50px 0 30px 0;text-align:center">
                <h1 class="section-title">¡Bienvenido al Galpón de los Cuadros!</h1>
            <p>¡A continuación podés ver todos los productos que realizamos!</p>

            </div>
            <div class="content-form">
            <hr />
            <ul style="display:grid;">
                <li>
                    <img src="https://i.ibb.co/nL5NGLb/Basti2-removebg-preview.png">
                    <p margin-top="5px">Bastidores</p>
                    <a href="Productos.aspx?tipo=16">Ver más</a>
                </li>
                <li>
                    <img src="https://i.ibb.co/ZxNkbqd/Cuadro-removebg-preview.png">
                    <p>Cuadros Rectangulares</p>
                    <a href="Productos.aspx?tipo=51">Ver más</a>
                    
                </li>
                <li>
                    <img src="https://i.ibb.co/ZxNkbqd/Cuadro-removebg-preview.png">
                    <p>Cuadros Escalonados</p>
                    <a href="Productos.aspx?tipo=52">Ver más</a>
                    
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Relojes</p>
                    <a href="Productos.aspx?tipo=10">Ver más</a>
                </li>
                <li>
                    <img src="https://i.ibb.co/yqW0pWv/perchero-removebg-preview.png">
                    <p>Percheros</p>
                    <a href="Productos.aspx?tipo=9">Ver más</a>
                </li>
                <li>
                    <img src="https://i.ibb.co/Gsfy1qR/portash-removebg-preview.png">
                    <p>Portallaves</p>
                    <a href="Productos.aspx?tipo=8">Ver más</a>
                </li>
                <li>
                    <img src="https://i.ibb.co/gg81Gr6/Frases-removebg-preview.png">
                    <p>Tablas con frases</p>
                    <a href="Productos.aspx?tipo=15">Ver más</a>
                </li>
                <li>
                    <img src="https://i.ibb.co/n75c1x6/Indi.png">
                    <p>Tablas individuales</p>
                    <a href="Productos.aspx?tipo=11">Ver más</a>
                </li>
                
            </ul>
        </div>
    </section>

    <hr />

    <section id="servicios">
        <div class="content-form">
            <h1 class="section-title" style="margin-bottom:40px;">¿Qué hacemos?</h1>
            <hr />
            <div class="trabajos" id="trabajos">

                <div class="trabajos-card">
                    <a href="https://www.elgalpondeloscuadros.com.ar/">
                    <div class="n1">
                        <h3>Venta Minorista</h3>
                    </div>
                    <div class="n2">
                        <p>Vendemos directamente al público a precios increíbles! Brindamos una excelente atención y servicio al cliente</p>
                    </div>
                     <div class="icono">
                        <img src="https://i.ibb.co/C7p90HR/minorista.png" style="height:100px;width:100px"/>
                    </div>
                    <div class="n3">
                        <span>Ver Página Minorista</span>
                    </div>
                    
                </a>
                </div>

                <div class="trabajos-card">
                    <a href="Mayoristas.aspx">
                    <div class="n1">
                        <h3>Venta Mayorista</h3>
                    
                    </div>
                    <div class="n2">
                        <p>Realizamos pedidos al por mayor, con precios diseñados para conseguir un gran márgen de ganancia! </p>
                    </div>
                        <div class="icono">
                            <img src="https://i.ibb.co/m9dvr9S/mayorista.png" style="height:100px;width:100px"/>
                    </div>
                    <div class="n3">
                        <span>Ver página Mayorista</span>
                    </div>
                    
                </a>
                </div>

                <div class="trabajos-card">
                    <a href="Personalizados.aspx">
                    <div class="n1">
                        <h3>Cuadros personalizados</h3>
                    </div>
                    <div class="n2">
                        <p>Personalizamos la imágen que vos quieras! Trabajamos con imágenes de buena definición para lograr productos de gran calidad! </p>
                    </div>
                        <div class="icono">
                        <img src="https://i.ibb.co/68Jd5Mp/Blanco-y-negro-minimalista-monograma-tipografico-logotipo-1.png" style="height:100px;width:100px"/>
                    </div>
                    <div class="n3">
                        <span>Ver página de Personalizados</span>
                    </div>
                    
                </a>
                </div>

            
            </div>
        </div>
    </section>

    <section class="envios">
        <div class="content-form">
            <hr/>
           <h1 class="section-title" style="margin-bottom:30px">¿De dónde sos?</h1>
            <hr />

            <div class="envios-box">
                <div class="envios-capital">
                <div><img src="https://http2.mlstatic.com/storage/cx-support-fcm-api/fcm-pub-os-prod/cx-support-mario-frontend/jcastiglione/flex_mla_mapa%20(no%20obligatorio).png" style="width:200px;height:200px;"/></div>
                <div>
                    <div><p>Envíos a Capital y GBA</p></div>
                    <div><p>Realizamos envíos a través de una logística, consulta <a href="https://www.mercadolibre.com.ar/ayuda/28048" target="_blank">acá</a></p></div>
                </div>
            </div>

            <div class="envios-interior">
                <div><img src="https://i.ibb.co/2v3q589/R001-1.png"></div>
                <div>
                    <div><p>Envíos a todo el país</p></div>
                    <div><p>Realizamos envíos a todo el país, para eso tenes que ir a cualquier publicación </p></div>
                </div>
            </div>

            </div>

        </div>
    </section>

    <section class="mas-vendidos">
        <div class="content-form">
            <hr/>
           <h1 class="section-title">Productos destacados!</h1>
            <hr />

            <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Producto item in ListaProductosPopulares)
        {%>
  <div class="card" style="height:250px; align-items:center; margin-right:15px; margin-bottom:15px; text-align:center;">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" style="height: 100px; width:100px; margin-top:5px;" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title"> <% =item.NombreProducto %></h5>
      <a href="DetalleProducto.aspx?id=<% = item.Codigo%>" class="btn btn-dark btn-sm">Ver Detalle</a>
        <a href="Carrito.aspx?id=<% = item.ImagenUrl %>"class="btn btn-dark btn-sm">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>
    </div>
  </div>
      <% } %>
 </div>


 </div>

    </section>





    <section class="novedades">
        <div class="content-form">
            <hr />
           <h1 class="section-title">Novedades</h1>
        <hr />
            <div class="cardflex" style="display:grid; grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >
    <% foreach (domain.Novedad item in ListaNovedades)
        {%>
  <div class="card" style="height:250px; align-items:center; margin-right:15px; margin-bottom:15px; text-align:center;">
    <img class="card-img-top" src="<%=item.ImagenUrl %>" style="height: 100px; width:100px; margin-top:5px;" alt="Card image cap">
    <div class="card-body">
      <h5 class="card-title"> <% =item.Titulo %></h5>
      <a href="DetalleProducto.aspx?id=<% = item.Descripcion%>" class="btn btn-dark btn-sm">Ver Detalle</a>
        
    </div>
  </div>
      <% } %>
 </div>
        

</div>

    </section>


</asp:Content>
<%--  
<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src="https://i.ibb.co/fFpQ6Pf/T109.jpg" alt="First slide" style="height:800px;object-fit:contain">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="https://i.ibb.co/fFpQ6Pf/T109.jpg" alt="Second slide" style="height:800px;object-fit:contain">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src="https://i.ibb.co/fFpQ6Pf/T109.jpg" alt="Third slide" style="height:800px;object-fit:contain">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true" ></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>--%>