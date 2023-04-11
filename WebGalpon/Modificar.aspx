<%@ Page Title="Modificar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Modificar.aspx.cs" Inherits="WebGalpon.Modificar"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="contenedor" style="text-align:center;">

    <h1 style="margin:10px;">Modificaciones de la página</h1>

    <hr /> <%------------------------------%>

    <div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">
    <h3>Info mayoristas</h3>

    <hr/>
    <h4>Agregar info</h4>
    <asp:TextBox runat="server" Text="Titulo" ID="Titulo"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="Desc1"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion2" ID="Desc2"></asp:TextBox>
    <asp:Button runat="server" Text="Agregar Info Mayorista" OnClick="AgregarInfo_Click" ID="AgregarInfo" />
    <hr/>
    <h4>Modificar info</h4>
    <asp:DropDownList runat="server" AutoPostBack="True" ID="DDLModInfo"></asp:DropDownList>
    <asp:TextBox runat="server" Text="Titulo" ID="ModTitulo"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="ModDesc1"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion2" ID="ModDesc2"></asp:TextBox>
    <asp:Button runat="server" OnClick="ModificarInfo_Click" Text="Modificar Info Mayorista" ID="ModificarInfo" />
    <hr/>
    <h4>Eliminar info</h4>
    <asp:DropDownList runat="server" ID="DDLEliminarInfo"></asp:DropDownList>
    <asp:Button runat="server" OnClick="EliminarInfo_Click" Text="Eliminar Info Mayorista" ID="EliminarInfo" />

        <asp:Label runat="server" ID="prueba" ></asp:Label>
       </div>
    <hr/> <%------------------------------%>










        <div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">
    <h3>Preguntas frecuentes</h3>
            <hr />

    <h4>Agregar Preguntas</h4>
    <asp:TextBox runat="server" Text="Pregunta" ID="Preg"></asp:TextBox>
    <asp:TextBox runat="server" Text="Respuesta" ID="Res"></asp:TextBox>
    <asp:Button runat="server" OnClick="AgregarPregunta_Click" ID="AgregarPregunta" Text="Agregar pregunta"/>
    <hr />
    <h4>Modificar Preguntas</h4>
    <asp:DropDownList runat="server" ID="DDLModPreg"></asp:DropDownList>
    <asp:TextBox runat="server" Text="Pregunta" ID="ModPreg"></asp:TextBox>
    <asp:TextBox runat="server" Text="Respuesta" ID="ModRes"></asp:TextBox>
    <asp:Button runat="server" OnClick="ModPregunta_Click" ID="ModPregunta" Text="Modificar pregunta" />
        <hr />
    <h4>Eliminar Preguntas</h4>
    <asp:DropDownList runat="server" ID="DDLElimPreg"></asp:DropDownList>
    <asp:Button runat="server" OnClick="ElimPreg_Click" ID="ElimPreg" Text="Eliminar pregunta" />
            </div>
    <hr />  <%------------------------------%>





            <div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">
    <h3>Novedades</h3>
    <hr />

    <h4>Agregar Novedades</h4>
    <asp:TextBox runat="server" Text="Titulo" ID="TituloNov"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="DescNov"></asp:TextBox>
    <asp:TextBox runat="server" Text="Url Imagen" ID="ImgNov"></asp:TextBox>
    <asp:Button runat="server" ID="AgregarNov" OnClick="AgregarNov_Click" Text="Agregar Novedades" />
        <hr />
    <h4>Modificar Novedades</h4>
    <asp:DropDownList runat="server" ID="DDLModNov"></asp:DropDownList>
    <asp:TextBox runat="server" Text="Titulo" ID="ModTitNov"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="ModDescNov"></asp:TextBox>
    <asp:TextBox runat="server" Text="Url Imagen" ID="ModImgNov"></asp:TextBox>
    <asp:Button runat="server" ID="ModNov" OnClick="ModNov_Click" Text="Modificar novedades" />
        <hr />
    <h4>Eliminar Novedades</h4>
    <asp:DropDownList runat="server" ID="DDLElimNov"></asp:DropDownList>
    <asp:Button runat="server" ID="ElimNov" OnClick="ElimNov_Click" Text="Eliminar novedades" />
</div>
    <hr /> <%------------------------------%>

















<div style="background-color:#FBF9F8;margin:10px;padding:10px;border-radius:10px;">
    <h3>Productos destacados</h3>
    <hr />

    <h4>Agregar destacados</h4>
    <asp:TextBox runat="server" Text="Nombre" ID="NombreDest"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="DescDest"></asp:TextBox>
    <asp:TextBox runat="server" Text="Url Imagen" ID="ImgDest"></asp:TextBox>
    <asp:Button runat="server" OnClick="AgregarDest_Click" ID="AgregarDest" Text="Agregar destacados" />
        <hr />
    <h4>Modificar destacados</h4>
    <asp:DropDownList runat="server" ID="DDLModDest"></asp:DropDownList>
    <asp:TextBox runat="server" Text="Nombre" ID="ModNombreDest"></asp:TextBox>
    <asp:TextBox runat="server" Text="Descripcion" ID="ModDescDest"></asp:TextBox>
    <asp:TextBox runat="server" Text="Url Imagen" ID="ModImgDest"></asp:TextBox>
    <asp:Button runat="server" OnClick="ModDest_Click" ID="ModDest" Text="Modificar destacados" />
        <hr />
    <h4>Eliminar destacados</h4>
    <asp:DropDownList runat="server" ID="DDLElimDest"></asp:DropDownList>
    <asp:Button runat="server" OnClick="ElimDest_Click" ID="ElimDest" Text="Eliminar destacados" />
<hr/>
    </div>
    </div>


</asp:Content>
