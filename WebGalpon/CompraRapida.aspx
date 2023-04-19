<%@ Page Title="CompraRapida" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CompraRapida.aspx.cs" Inherits="WebGalpon.CompraRapida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="CSS/CompraRapida.css" rel="Stylesheet" type="text/css" />

        <div class="contact-title" style="margin:50px 0 30px 0;text-align:center">
      <h1> Sección de compra rápida  </h1> 
      </div>



    <hr />
    <div class="contact-subtitle"><h3>Debes conocer los códigos del catálogo para usar esta sección</h3></div>
    <hr />
    <div style="text-align:center;" id="tabla">
    <table class="table table-striped mt-5" style="background-color:#b6d1d4;text-align:center;" id="table">
  
          <asp:GridView ID="GridView1" CssClass="GridView" runat="server"  AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" >
                    <Columns>
                        
                        <asp:BoundField HeaderText="Fila" DataField="Fila" ></asp:BoundField>
                        
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="Codigo"> <ItemTemplate><asp:TextBox CssClass="TextCant" ID="TextCodigo" Text='<%# Eval("Codigo") %>' class="codigo" runat="server"></asp:TextBox></ItemTemplate></asp:TemplateField>
                        
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" AccessibleHeaderText="True" />
                        
                        
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="Cantidad"> <ItemTemplate><asp:TextBox CssClass="TextCant" type="number" min="0" ID="TextCant" Text='<%# Eval("Cantidad") %>' class="cantidad" runat="server"></asp:TextBox></ItemTemplate></asp:TemplateField>
                       
                        
                        <asp:BoundField DataField="Precio" HeaderText="Precio" />  
                       

                        <asp:BoundField  DataField="Subtotal" HeaderText="Subtotal"/>
                        <asp:TemplateField AccessibleHeaderText="true" HeaderText="Imagen"> <ItemTemplate > <asp:Image CssClass="ImgCarro" runat="server" ID="ImgCarro" ImageUrl='<%# Eval("Imagen") %>' /> </ItemTemplate></asp:TemplateField>
                        
                        <asp:CommandField ShowDeleteButton="true" DeleteImageUrl="Imagen" />
                        <asp:TemplateField Visible="false"><ItemTemplate><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="TextCant" Visible="false"
                        ValidationExpression="/^[0-9]$/"></asp:RegularExpressionValidator></ItemTemplate></asp:TemplateField> 
                    </Columns>
                </asp:GridView>
        
  </table>
        </div>
    <hr />
    <asp:Button ID="ActualizarButton" runat="server" CssClass="btn btn-dark" Text="Actualizar" OnClick="ActualizarButton_Click"/>
        <asp:Button ID="AgregarFilaButton" runat="server" CssClass="btn btn-dark" Text="AgregarFila" OnClick="AgregarFilaButton_Click"/>
        <asp:Button ID="Agregar10FilasButton" runat="server" CssClass="btn btn-dark" Text="Agregar 10 Filas" OnClick="Agregar10FilasButton_Click"/>
    <hr />
        <asp:Label runat="server" ID="LabelTotalProductos">Total de productos:</asp:Label>
        <asp:Label runat="server" ID="LabelTotalPedido">Total del pedido:</asp:Label>
    <hr />
    

    <div style="text-align:center;align-content:center;align-items:center;margin-top:40px">

        <asp:ImageButton runat="server" ImageUrl="https://i.ibb.co/85SRg6P/Logo-archivo-PDF.png" ID="PdfButton1" ToolTip="Imprimir pedido en Pdf" OnClick="PdfButton1_Click" CssClass="Buttons"/>
        <asp:ImageButton runat="server" ImageUrl="https://i.ibb.co/6ycB13Z/Excel-microsoft.png" ID="ExcelButton1" ToolTip="Imprimir pedido en Excel" OnClick="ExcelButton1_Click" CssClass="Buttons"/>

        <hr />
    <asp:Button runat="server" Text="Necesito ayuda para hacer el pedido" CssClass="btn btn-danger" /> </div>

    <hr />
    
    <asp:Panel runat="server" ></asp:Panel>
    <asp:Button runat="server" ID="EmailButton" Text="Enviarnos email con tu pedido" OnClick="EmailButton_Click" CssClass="btn btn-dark" />
   
    <hr />
  <script type="text/javascript">

      function asignarPrecio(control, precio, seleccionado) {
          if (seleccionado) {
              control.value = precio;
              control.disabled = false;
          } else {
              control.value = '';
              control.disabled = true;
          }
      }

  </script>


    <script type="text/javascript">

        function openModal() {
            $('#myModal').modal('show');
        }

    </script>
</asp:Content>

<%--<%for (int i = 0; i < 10; i++)
            {%>
            
          <tr>
      <th scope="row"> <%=i+1%> </th>
      <td> <asp:TextBox runat="server" ID="TextoCodigo" OnTextChanged="TextoCodigo_TextChanged" ></asp:TextBox></td> 
      <td> <asp:Label runat="server" ID="LabelNombre"></asp:Label> </td>
      <td> <asp:TextBox runat="server" ID="TextoCantidad" OnTextChanged="TextoCantidad_TextChanged" > </asp:TextBox></td>
      <td> <asp:Label runat="server" ID="LabelPrecio"></asp:Label></td> 
      <td> <asp:Label runat="server" ID="LabelSubtotal"></asp:Label></td>
      <td> <asp:ImageButton runat="server" Visible="false" CssClass="BotonEliminar"/> <img src="https://i.ibb.co/VQrL8FP/png-transparent-icon-design-trash-red-line-area-material-rectangle-removebg-preview.png" style="height:40px" /></td>
     
          </tr>


          <%  }%>--%>

<%-- <%for (int i = 0; i < 10; i++)
            {%>
            
          <tr>
      <th scope="row"> <%=i+1%> </th>
      <td> <input type="text" id="inputName" required minlength="4" maxlength="12" size="15" > </td> 
      <td> <textbox id="nombre<%=i %>"></textbox></td>
      <td> <input type="text" id="inputCant<%=i %>" required minlength="4" maxlength="12" size="15"></td>    
      <td> <textbox id="precio<%=i %>"></textbox></td> 
      <td> <textbox id="subtotal<%=i %>"></textbox></td>
      <td> <asp:ImageButton runat="server" Visible="false" CssClass="BotonEliminar" OnClick="Unnamed_Click"/> <img src="https://i.ibb.co/VQrL8FP/png-transparent-icon-design-trash-red-line-area-material-rectangle-removebg-preview.png" style="height:40px" /></td>
      
          </tr>


          <%  }%>--%>