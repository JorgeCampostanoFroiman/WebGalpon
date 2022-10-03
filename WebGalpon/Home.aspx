<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebGalpon.Home" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >

    <link href="CSS/home.css" rel="Stylesheet" type="text/css" />
    <hr />
    <section id="productos">
        <div class="contenedor">
            <h1 class="section-title">Nuestros productos</h1>
            <hr />
            <ul>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p margin-top="5px">Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                    
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
                <li>
                    <img src="https://i.ibb.co/h7SkM2q/R001.png">
                    <p>Reloj</p>
                    <a>Ver más</a>
                    <p>Descripcion</p>
                </li>
            </ul>
        </div>
    </section>

    <hr />

    <section id="servicios">
        <div class="contenedor">
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
        <div class="contenedor">
            <hr/>
           <h1 class="section-title">¿De dónde sos?</h1>
            <hr />

            <div class="envios-box">
                <div class="envios-capital">
                <div><img src="https://http2.mlstatic.com/secure/salesforce-resources/faqs-images/200227104000_FLEX_MLA_Mapa.png" style="width:200px;height:200px;"/></div>
                <div>
                    <div><p>Envíos a Capital y GBA</p></div>
                    <div><p>Realizamos envíos a través de una logística, consultanos costos!</p></div>
                </div>
            </div>

            <div class="envios-interior">
                <div><img src="https://paintmaps.com/vector_png/11vs.png" style="width:200px;height:200px;"/></div>
                <div>
                    <div><p>Envíos a todo el país</p></div>
                    <div><p>Realizamos envíos a todo el país, a través de Mercado envíos! </p></div>
                </div>
            </div>

            </div>

            

        </div>
    </section>

    <section class="mas-vendidos">
        <div class="container">
            <hr/>
           <h1 class="section-title">Productos destacados!</h1>
            <hr />

        </div>
    </section>


    <section class="novedades">
        <div class="container">
           <h1 class="section-title">Novedades</h1>
        </div>
    </section>


</asp:Content>
  