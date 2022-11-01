<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="WebGalpon.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        
        <table class="table table-dark table-striped mt-5 ">
            <thead>
                <tr>
                   <th style="text-align:right"><h1>Pedido de Usuario</h1> </th> 
                </tr>
                <tr>
                    <th>Código</th>
                    <th>Nombre</th>
                    <th>Cantidad</th>
                    <th>Precio Unitario</th>
                    <th>SubTotal</th>
                    <th>Imagen</th>
                    <th></th>
                </tr>
            </thead>
      
            <tbody>

                <asp:Repeater runat="server" ID="repetidor">
                    <ItemTemplate>
                        <tr>
                            <th scope="row"><%#Eval("ItemArt.Codigo")%></th>
                            <td><%#Eval("ItemArt.NombreProducto")%></td>
                            <td>
                                <%#Eval("Cantidad") %>
                                <a href="Carrito.aspx?id=<%#Eval("ItemArt.ImagenUrl")%>&c=a" class="btn btn-light btn-sm">+</a>
                                <a href="Carrito.aspx?id=<%#Eval("ItemArt.ImagenUrl")%>&c=r" class="btn btn-dark btn-sm">-</a>
                            </td>
                            <td>$<%#Eval("ItemArt.PrecioVenta")%></td>
                            <td>
                                $<%#Eval("Subtotal") %>
                                
                            </td>
                            <td>
                                <img src="<%#Eval("ItemArt.ImagenUrl")%>"alt="..." style="height: 8rem; width: 8rem;">
                            </td>
                            <td><a href="DetalleProducto.aspx?id=<%#Eval("ItemArt.ImagenUrl")%>"class="btn btn-info btn-sm"target="_blank" rel="noopener noreferrer">Detalle</a>
                               
                            </td>
                           <td><a href="Carrito.aspx?id=<%#Eval("ItemArt.ImagenUrl")%>&c=d" class="btn btn-danger btn-sm">Eliminar</a>
                            </td>

                       </tr>
                    </ItemTemplate>
                </asp:Repeater>
                        
           </tbody>

          <tfoot>
              <th></th>
              <th></th>
              <th></th>
              <th></th>
              <th></th>
              
              <th>$<%= total %></th>
              <th>Total</th>
          </tfoot>
        </table>
    </div>
</asp:Content>