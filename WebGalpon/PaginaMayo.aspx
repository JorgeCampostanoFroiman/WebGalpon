<%@ Page Title="PaginaMayo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaMayo.aspx.cs" Inherits="WebGalpon.PaginaMayo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        
        <table class="table table-dark table-striped mt-5 ">
            <thead>
                <tr>
                   <th style="text-align:right"><h1>Pedido de Usuario</h1> </th> 
                </tr>
                <tr>
                    <th>CANTIDAD</th>
                    <th>Nombre</th>
                    <th>Codigo</th>
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
                            <th scope="row"><%#Eval("Cantidad")%></th>
                            <td><%#Eval("NombreProducto")%></td>
                            <td>$<%#Eval("Codigo")%></td>
                            <td>$<%#Eval("PrecioVenta") %></td>
                            <td>$<%#Eval("Subtotal") %></td>
                            <td><img src="<%#Eval("ImagenUrl")%>"alt="..." style="height: 2rem; width: 2rem;">
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

    <https://www.instagram.com/p/CnDkDM6MmujsB3isXyPVF_S3ieghbSAT6-QNbA0/?igshid=YmMyMTA2M2Y=
</asp:Content>