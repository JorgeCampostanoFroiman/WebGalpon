<%@ Page Title="DetalleProducto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebGalpon.DetalleProducto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" >
    <link href="CSS/Detalleproducto.css" rel="Stylesheet" type="text/css" />
        
    <h2 class="details-title">Detalle del producto</h2>
    
    <div class="contenedor">
            <div class="product-images">
                <div class="side-images">
                    <asp:Image runat="server" ID="image4" CssClass="side-img"/>
                    <asp:Image runat="server" ID="image1" CssClass="side-img"/>
                    <asp:Image runat="server" ID="image2" CssClass="side-img"/>
                    <asp:Image runat="server" ID="image3" CssClass="side-img"/>
                    <asp:Image runat="server" ID="image5" CssClass="side-img"/>
                </div>
                <div class="principal-image">
                    <asp:Image runat="server" ID="imagenProducto" CssClass="main-img"/>
                </div>
            </div>
            <div class="product-details">
                <p class="form-button"><asp:Label runat="server" ID="labelNombre" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
                <p class="form-button"><asp:Label runat="server" ID="labelPrecio" Font-Size="X-Large" Font-Bold="true"></asp:Label></p>
                <p class="form-button"><asp:Label runat="server" ID="labelDescripcion"></asp:Label></p>
                <p class="form-button"><asp:DropDownList runat="server" ID="ddlVariantes"></asp:DropDownList></p>
                <a class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="labelVolver"></asp:Label></a>
                <a class="btn" href="Productos.aspx">Ir a productos</a>
            </div>
    
            
            </div>

     <h2 class="details-title">Recomendados</h2>

    <div class="related-images">

        <div class="related-item">
            <asp:Image runat="server" ID="image6" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related1"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp1" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>

        <div class="related-item">
            <asp:Image runat="server" ID="image7" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related2"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp2" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>

        <div class="related-item">
            <asp:Image runat="server" ID="image8" CssClass="related-img"/>
            <p class="form-button" href="Productos.aspx"><asp:Label runat="server" ID="related3"></asp:Label></p>
            <p class="form-button"><asp:Label runat="server" ID="relatedp3" Font-Bold="true"></asp:Label></p>
            <a class="hide-button"></a>
        </div>
        
    </div>

</asp:Content>
