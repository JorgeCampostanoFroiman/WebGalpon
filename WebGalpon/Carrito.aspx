<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebGalpon.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="CSS/carrito.css"  rel="Stylesheet" type="text/css" />
      
    <button id="download-button">Bajar como pdf</button>


    <div style="margin:50px 0 30px 0;text-align:center">
      <asp:Label runat="server" ID="TitleLabel" CssClass="LabelCarro">Carrito <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></asp:Label>
      <hr />
    <asp:Label runat="server" CssClass="AlertCarro" ID="AlertLabel"></asp:Label>
        <hr />
    <div style="text-align:center;" id="contenedor">
    <table class="table table-striped" style="background-color:#b6d1d4;width:80vw;" id="table">
  
          <asp:GridView ID="GridViewCarrito" CssClass="GridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridViewCarrito_RowDeleting" >
                    <Columns>
                        <asp:BoundField HeaderText="Item" DataField="Fila" ></asp:BoundField>
                        <asp:TemplateField HeaderText="Codigo"><ItemTemplate><asp:HyperLink runat="server" CssClass="TextCodigo" ID="TextCodigo"
                        Text='<%# Eval("Codigo") %>' NavigateUrl='<%# "~\\DetalleProducto.aspx?id=" + Eval("Codigo") %>'></asp:HyperLink></ItemTemplate></asp:TemplateField>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" AccessibleHeaderText="True" />
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="  Cantidad  "> <ItemTemplate><asp:TextBox type="number" min="0" CssClass="TextCant" ID="TextCant" Text='<%# Eval("Cantidad") %>' class="cantidad" runat="server"></asp:TextBox></ItemTemplate></asp:TemplateField>
                        <asp:BoundField DataField="Precio"  HeaderText="  Precio" />  
                        <asp:BoundField DataField="Subtotal"  HeaderText="Subtotal"/> 
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="Imagen"> <ItemTemplate > <asp:Image CssClass="ImgCarro" runat="server" ID="ImgCarro" ImageUrl='<%# Eval("Imagen") %>' /> </ItemTemplate></asp:TemplateField>
                        <asp:TemplateField Visible="false"><ItemTemplate><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextCant" Visible="false"
                        ValidationExpression="/^[0-9]$/"></asp:RegularExpressionValidator></ItemTemplate></asp:TemplateField>
                        <asp:CommandField ShowDeleteButton="true" DeleteImageUrl="Imagen" />
                    </Columns>
                </asp:GridView>
  </table>
        <hr />
        <asp:Button runat="server" BorderColor="White" CssClass="btn btn-dark" ID="ActualizarButton" OnClick="ActualizarButton_Click1" Text="Actualizar carro"/><asp:Button runat="server" ID="ProductosButton" CssClass="btn btn-dark " Text="Agregar productos" OnClientClick="window.open('Productos.aspx')" ></asp:Button>
        <hr />
        <div style="margin-bottom:20px;"><asp:Label runat="server" CssClass="LabelTotalProductos" ID="LabelTotalProductos">Total de productos:</asp:Label></div>
        <asp:Label runat="server" cssclass="LabelTotalPedido" ID="LabelTotalPedido">Total: </asp:Label>
        </div>
        <hr />
        <div style="text-align:center;align-content:center;align-items:center;margin-top:40px">
        <asp:Button runat="server" Text="Imprimir pedido en pdf" id="PdfButton"  CssClass="btn btn-dark" />
    <asp:Button runat="server" ID="EmailButton" Text="Enviarnos email con tu pedido"  CssClass="btn btn-dark" /></div>
        </div>
     
    
     <script>
         const button = document.getElementById("download-button");

         function generatePDF() {
             const element = document.getElementById("contenedor");
             html2pdf().from(element).save();
         }

         button.addEventListener("click", generatePDF);
     </script>
     
</asp:Content>



<%--<asp:Image Height="300px" Width="200px" ID="Imagen" ImageUrl='<%# Eval("Imagen") %>' runat="server"></asp:Image>--%>