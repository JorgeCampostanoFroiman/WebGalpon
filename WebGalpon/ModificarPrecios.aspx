<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModificarPrecios.aspx.cs" Inherits="WebGalpon.ModificarPrecios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="contenedor" style="text-align:center;">

    <h1 style="margin:10px;">Modificación de precios</h1>

    <hr /> <%------------------------------%>

    <div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">
    <asp:Label runat="server" Text="Producto (Precio actual)"></asp:Label>
    <hr/>
    <asp:Label Text="Cuadro triptico/Rectangular/Escalonado" runat="server" />
    <asp:Label ID="PrecioRectangular" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre1"></asp:TextBox>
    <hr/>
    <asp:Label Text="Cuadro X6" runat="server" />
    <asp:Label ID="PrecioX6" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre2"></asp:TextBox>
    <hr/>
    <asp:Label Text="2840" runat="server" />
    <asp:Label ID="Precio2840" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre3"></asp:TextBox>
    <hr/>
    <asp:Label Text="2030" runat="server" />
    <asp:Label ID="Precio2030" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre4"></asp:TextBox>
    <hr/>
    <asp:Label Text="Relojes" runat="server" />
    <asp:Label ID="PrecioRelojes" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre5"></asp:TextBox>
    <hr/>
    <asp:Label Text="Portallaves" runat="server" />
    <asp:Label ID="PrecioPortallaves" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre6"></asp:TextBox>
    <hr/>
    <asp:Label Text="Percheros" runat="server" />
    <asp:Label ID="PrecioPercheros" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre7"></asp:TextBox>
    <hr/>
    <asp:Label Text="Tablita con frases x3" runat="server" />
    <asp:Label ID="PrecioTablitaX3" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre8"></asp:TextBox>
    <hr/>
    <asp:Label Text="Tablita con frases x4" runat="server" />
    <asp:Label ID="PrecioTablitaX4" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre9"></asp:TextBox>
    <hr/>
    <asp:Label Text="Tablita con frases x5" runat="server" />
    <asp:Label ID="PrecioTablitaX5" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre10"></asp:TextBox>
    <hr/>
    <asp:Label Text="Tablita con frases x6" runat="server" />
    <asp:Label ID="PrecioTablitaX6" runat="server" />
    <asp:TextBox runat="server" required="required" Text="" ID="ModPre11" ></asp:TextBox>
    <hr/>


        <asp:Button runat="server" OnClick="BtnModificar_Click" Text="Modificar Precios" ID="BtnModificar" />
        <asp:ImageButton runat="server" ImageUrl="https://i.ibb.co/85SRg6P/Logo-archivo-PDF.png" ID="PdfButton" ToolTip="Imprimir Carrito en PDF" OnClick="PdfButton_Click" CssClass="Buttons"/>


       </div>
    <hr/> <%------------------------------%>

        </div>

</asp:Content>
