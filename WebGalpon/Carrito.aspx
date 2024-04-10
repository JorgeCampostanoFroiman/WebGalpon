<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebGalpon.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <link href="CSS/carrito.css"  rel="Stylesheet" type="text/css" />
      


    <div style="margin:50px 0 30px 0;text-align:center" id="container">
      <asp:Label runat="server" ID="TitleLabel" CssClass="LabelCarro">Carrito <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart-plus" viewBox="0 0 16 16">
  <path d="M9 5.5a.5.5 0 0 0-1 0V7H6.5a.5.5 0 0 0 0 1H8v1.5a.5.5 0 0 0 1 0V8h1.5a.5.5 0 0 0 0-1H9V5.5z"/>
  <path d="M.5 1a.5.5 0 0 0 0 1h1.11l.401 1.607 1.498 7.985A.5.5 0 0 0 4 12h1a2 2 0 1 0 0 4 2 2 0 0 0 0-4h7a2 2 0 1 0 0 4 2 2 0 0 0 0-4h1a.5.5 0 0 0 .491-.408l1.5-8A.5.5 0 0 0 14.5 3H2.89l-.405-1.621A.5.5 0 0 0 2 1H.5zm3.915 10L3.102 4h10.796l-1.313 7h-8.17zM6 14a1 1 0 1 1-2 0 1 1 0 0 1 2 0zm7 0a1 1 0 1 1-2 0 1 1 0 0 1 2 0z"/>
</svg></asp:Label> 
      <hr />
        <input type="button" value="Página anterior" onClick="history.go(-1);">
        <hr />
    <asp:Label runat="server" CssClass="AlertCarro" ID="AlertLabel"></asp:Label>
        <hr />
    <div style="text-align:center;" id="contenedor">
    <table class="table table-striped" style="background-color:#b6d1d4;width:80vw;">
  
          <asp:GridView ID="GridViewCarrito" CssClass="GridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridViewCarrito_RowDeleting" >
                    <Columns>
                        <asp:BoundField HeaderText="Item" DataField="Fila" ></asp:BoundField>
                        <asp:TemplateField HeaderText="Codigo"><ItemTemplate><asp:HyperLink runat="server" CssClass="TextCodigo" ID="TextCodigo"
                        Text='<%# Eval("Codigo") %>' NavigateUrl='<%# "~\\DetalleProducto.aspx?id=" + Eval("Codigo") %>'></asp:HyperLink></ItemTemplate></asp:TemplateField>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" AccessibleHeaderText="True" />
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="  Cantidad  "> <ItemTemplate><asp:TextBox type="number" min="1" CssClass="TextCant" ID="TextCant" Text='<%# Eval("Cantidad") %>'  runat="server"></asp:TextBox></ItemTemplate></asp:TemplateField>
                        <asp:BoundField DataField="Precio"  HeaderText="Precio" />  
                        <asp:BoundField DataField="Subtotal" HeaderText="Subtotal"/> 
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="Imagen"> <ItemTemplate > <asp:Image CssClass="ImgCarro" runat="server" ID="ImgCarro" ImageUrl='<%# Eval("Imagen") %>' /> </ItemTemplate></asp:TemplateField>
                        <asp:TemplateField Visible="false"><ItemTemplate><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextCant" Visible="false"
                        ValidationExpression="/^[0-9]$/"></asp:RegularExpressionValidator></ItemTemplate></asp:TemplateField>
                        <asp:CommandField ShowDeleteButton="true" DeleteImageUrl="Imagen" />
                    </Columns>
                </asp:GridView>
  </table>
        <hr />
        <asp:Button runat="server" BorderColor="White" CssClass="btn btn-dark" ID="ActualizarButton" OnClick="ActualizarButton_Click1" Text="Actualizar carro"/>

        <asp:Button runat="server" ID="ProductosButton" CssClass="btn btn-dark " Text="Agregar productos" OnClientClick="window.open('Muestra.aspx')" ></asp:Button>
        
        <hr />
        <div style="margin-bottom:20px;"><asp:Label runat="server" CssClass="btn btn-dark" ID="LabelTotalProductos" Text="Total de productos:"></asp:Label> <asp:Label runat="server" cssclass="btn btn-dark" ID="LabelTotalPedido">Total: </asp:Label>
        </div>
        <hr />
        <div style="text-align:center;align-content:center;align-items:center;margin-top:40px;display:flex;justify-content:space-evenly">
            <asp:ImageButton runat="server" ImageUrl="https://i.ibb.co/85SRg6P/Logo-archivo-PDF.png" ID="PdfButton1" ToolTip="Imprimir Carrito en PDF" OnClick="PdfButton1_Click" CssClass="Buttons"/>
           <%-- <asp:ImageButton runat="server" ImageUrl="https://i.postimg.cc/fTJXHwh6/Gmail.png" ID="EmailButton1" CssClass="Buttons"/>--%>
            <asp:Button runat="server" CssClass="btn btn-dark" OnClick="CodeButton_Click" ID="CodeButton" Text="Generar Códigos" />
            <label id="buttonCopy" class="btn btn-dark">Copiar tu Pedido</label>
            
        </div>
     

        <script>

            let button = document.getElementById('buttonCopy');

            const quotePrice = document.getElementById('idprecio');

            const quoteCode = document.getElementsByClassName('TextCodigo');
            
            const quoteCant = document.getElementsByClassName('TextCant');

            let quote = new String();

            //    quoteCode.forEach((quo) => {
            //        quote = quote + quo.text + " "
            //        console.log(quo.text)
            //    });


            //quoteCant.forEach((que) => {
            //    quote = quote + que.value + " \n "
            //    console.log(que.value)
            //});

            for (var i = 0; i < quoteCode.length; i++) {
                quote = quote + quoteCode[i].text + " " + quoteCant[i].value + "\n"
                /*quote = quote + quoteCant[i].value + " " + quoteCode[i].text + "\n"*/
            }

            const copyToClipboard = async str => {
                try {
                    await navigator.clipboard.writeText(str);
                    console.log("copied");
                } catch (error) {
                    console.log(error);
                }
            };

            button.addEventListener("click", () => {
                copyToClipboard(quote);
            });


        </script>
     
</asp:Content>



<%--<asp:Image Height="300px" Width="200px" ID="Imagen" ImageUrl='<%# Eval("Imagen") %>' runat="server"></asp:Image>--%>