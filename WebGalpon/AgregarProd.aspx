<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarProd.aspx.cs" Inherits="WebGalpon.AgregarProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <div class="contenedor" style="text-align:center;">

    <h1 style="margin:10px;">Modificaciones: Productos</h1>

    <hr /> <%------------------------------%>

    <div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">

    <hr/>
    <h4>Agregar Producto</h4>
    <asp:TextBox runat="server" Text="Codigo" ID="Codigo"></asp:TextBox>
    <asp:TextBox runat="server" Text="Nombre" ID="Nombre"></asp:TextBox>
    <asp:TextBox runat="server" Text="IdTipo" ID="IdTipo"></asp:TextBox>
    <asp:TextBox runat="server" Text="ImagenUrl"  ID="ImagenUrl"></asp:TextBox>
    <asp:TextBox runat="server" Text="IdCategoria"  ID="IdCategoria"></asp:TextBox>
    <asp:Button runat="server" Text="Agregar Producto" ID="AgregarProducto" />
    <hr/>


    <h4>Modificar Producto</h4>
    <asp:TextBox runat="server" Text="Codigo" ID="ModCodigo"></asp:TextBox>
    <asp:TextBox runat="server" Text="Nombre" ID="ModNombre"></asp:TextBox>
    <asp:TextBox runat="server" Text="IdTipo" ID="ModTipo"></asp:TextBox>
    <asp:TextBox runat="server" Text="ImagenUrl"  ID="ModImagen"></asp:TextBox>
    <asp:TextBox runat="server" Text="IdCategoria"  ID="ModCategoria"></asp:TextBox>
        <asp:Button runat="server" Text="Modificar Producto" ID="ModificarProducto" />
    <hr/>


    <h4>Eliminar Producto</h4>
    <asp:TextBox runat="Server" Text="Id del producto a eliminar" ID="EliminarProd"> </asp:TextBox>
    <asp:Button runat="server" Text="Eliminar Producto" ID="ButtonEliminar" />
        <hr />
        <asp:Label runat="server" ID="prueba" ></asp:Label>
       </div>
    <hr/> <%------------------------------%>
        </div>

</asp:Content>
