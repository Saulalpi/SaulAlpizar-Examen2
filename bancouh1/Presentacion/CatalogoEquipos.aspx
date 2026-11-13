<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogoEquipos.aspx.cs" Inherits="bancouh1.Presentacion.CatalogoEquipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <link rel="stylesheet" type="text/css" href="/css/Estilo.css" />
    /></head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a class="active" href="Menu.aspx">Inicio</a></li>
                <li><a href="CatalogoUsuarios.aspx">Usuario</a></li>
                <li><a href="CatalogoTecnicos.aspx">Tecnico</a></li>
                <li><a href="CatalogoEquipos.aspx">Equipo</a></li>
                <li><a href="Presentacion/Contacto.aspx">Contacto</a></li>
                <li><a href="Presentacion/AcercaDe.aspx">Acerca de</a></li>
            </ul>
        </div>
        <div>
            <h2>Catalogo de Equipos</h2>
            <p>Bienvenido al catalogo de equipos.</p>
        </div>
        <br />
        <div>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>

        <div>
            <label for="txtEquipoID">ID del Equipo:</label>
            <asp:TextBox ID="txtEquipoID" runat="server"></asp:TextBox>
            <br />
            <label for="txtTipoEquipo">Tipo de Equipo:</label>
            <asp:TextBox ID="txtTipoEquipo" runat="server"></asp:TextBox>
            <br />
            <label for="txtModelo">Modelo:</label>
            <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <br />
            <label for="txtCorreo">Correo:</label>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
        </div>
            <br />
    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

    </div>
    </form>
</body>
</html>
