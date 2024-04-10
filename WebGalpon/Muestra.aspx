<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Muestra.aspx.cs" Inherits="WebGalpon.Muestra" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="CSS/muestra.css" rel="Stylesheet" type="text/css" />
    <hr />
       <div id="titulo" class="contact-title" >
      <h1>Muestras</h1> 
      </div>    
    <hr />
   <div class="contact-form" style="text-align:center;">

        <asp:TextBox ID="BarraBusquedaProd" placeholder="Búsqueda" runat="server"></asp:TextBox>
        <asp:Button ID="BotonBusquedaProd" OnClick="BotonBusquedaProd_Click" runat="server" class="btn btn-dark btn-sm" Text="Buscar" AutoPostBack="true"/>
        <asp:Button ID="RefrescarProd"  runat="server" class="btn btn-dark btn-sm" Text="Refrescar" AutoPostBack="true"/>
    
    </div>
    <hr />
    <div class="contact-title" >
      <h3>Categorias</h3> 
      </div>    
    <hr />
    <div class="contact-form" style="text-align:center"   >
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=1000" >Paisajes</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=2000" >Fútbol</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=3000" >Series y peliculas</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=4000" >Varios</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=5000" >Animales</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=6000" >Música</a>
        <a class="btn btn-dark" style="margin:2px;" href="Muestra.aspx?cat=7000" >Autos</a>
    </div>
    <hr />
   <div class="contact-form">
       <div id="hiddencard" class="hidden-card"   style="z-index:1000; left: 50%; visibility: hidden; top: 50%;transform: translate(-50%, -50%);display:flex;flex-direction:row;  background-color: white; margin:auto; text-align:center; position:fixed;">
                <div class="left-hidden-card" style="object-fit: contain;">
                    <img id="hiddenimg" onclick="zoomimg('hiddenimg')" src="https://www.gravatar.com/avatar/55dffef5e8d9c847d734c96cd824f38e?s=64&d=identicon&r=PG"     class="hidden-card-img-top" style="margin-top: 1vw;object-fit: contain;width:44vh;"alt="Card image cap">
    
    <div class="hidden-card-body">
        <hr />
        <label id="cerrarlabel" class="btn btn-danger" onclick="cerrarhidden()">Cerrar</label>
    </div>

                </div>
                <div class="right-hidden-card;" style="display:flex;flex-direction:column;align-items:center;justify-content: space-evenly;">
                    <img id="hiddenimg2" onclick="zoomimg('hiddenimg2')" src="https://i.postimg.cc/LXsmtZrL/1001-copia.jpg" width="200px"/>
                    
                    <label id="hiddencode" style="font-size:xxx-large;font-weight:bold" ></label>
                    <select name="medida" id="selectmedida">
  <option value="">Rectangular</option>
  <option value="e">Escalonado</option>
  <option value="x6">X6</option>
  <option value="g">Individual 2840</option>
  <option value="c">Individual 2030</option>
</select>

                    <div>
                        <input id="inputcantidad" type="number" autopostback="false" min="1" max="99" value="1" required="required" style="width:8vh"/>
                    <asp:Label runat="server">Unidades</asp:Label>

                    </div>  
                    <a id="anchorcarrito" onclick="agregarAlCarro()" href="Muestra.aspx" class="btn btn-dark btn-sm"  style="margin:1vh;">Agregar <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></a>                    
                </div>
  </div>
        <div id="cardflex" class="cardflex" style="display:grid;grid-template-columns: repeat( auto-fill, minmax(16rem, 1fr) ); " >

            
            

    <% foreach (domain.Muestra item in listaMuestras)
        {%>
  <div class="card" id="cardmuestra" style=" align-items:center; text-align:center;">
    <img id="cardimg"  class="card-img-top" src="<%=item.ImagenUrl %>" alt="Card image cap">
      
    <div class="card-body">
        <hr/>
        <label id="labelprueba" class="btn btn-dark" onclick="cargarhidden(<%=item.Codigo %>, '<%=item.ImagenUrl %>')">Ver detalle</label>
        <%--<Asp:Button runat="server" CommandName="imagenUrl" CommandArgument="cardimg" cssclass="btn btn-dark" OnClick="Unnamed_Click" Text="PressMe"/>--%>
    </div>
  </div>
      <% } %>
 </div>

  
 </div>
     
    <hr />

    <script>
        function cargarhidden(codigo, imagen) {

            document.getElementById("hiddencard").style.visibility = "visible";

            var y = document.getElementById("hiddencode");
            y.textContent = codigo;

            document.getElementById('hiddenimg').src = imagen;
            document.getElementById('hiddenimg2').src = imagen;

            document.getElementById('cardflex').style.opacity = "0.2";

            const btns = document.getElementsByClassName('card-body');

            btns.forEach((btn) => {
                btn.style["visibility"] = "hidden"
                console.log(btn.style["visibility"])
            });
        }

        function cerrarhidden() {

            document.getElementById("hiddencard").style.visibility = "hidden";

            document.getElementById('cardflex').style.opacity = "1";

            const btns = document.getElementsByClassName('card-body');

            btns.forEach((btn) => {
                btn.style["visibility"] = "visible"
                console.log(btn.style["visibility"])
            });

        }

        function agregarAlCarro() {


            let string = "Carrito.aspx?id=" + document.getElementById('hiddencode').textContent + document.getElementById('selectmedida').value + "&cant=" + document.getElementById('inputcantidad').value;
            document.getElementById('anchorcarrito').href = string;



            /*OPCION 1?*/
            /*window.open(string, "Carrito Web", "width=900, height=7000")*/



            /*OPCION 2?*/
            //carritowindow = window.open(string, "carritoWindow", "width=900, height=700")
            //carritowindow.document.write("<p>Producto agregado al carrito. La pestaña se cerrará en 3 segundos</p>");
            //tmot = setTimeout(function () { window.open(string, "carritoWindow") }, 2000);
            //tmot = setTimeout(function () { carritowindow.close() }, 5000);






        }

        function zoomimg(idimagen) {
            if (document.getElementById(idimagen).style.transform == "scale(1.4)") {
                document.getElementById(idimagen).style.transform = "scale(1.0)"
            }
            else {
                document.getElementById(idimagen).style.transform = "scale(1.4)"
            }
        }


    </script>
    

</asp:Content>
