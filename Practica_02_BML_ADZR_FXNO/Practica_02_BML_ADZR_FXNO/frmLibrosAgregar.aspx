<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLibrosAgregar.aspx.cs" Inherits="Practica_02_BML_ADZR_FXNO.frmLibrosAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Regresar" />
        </div>
        <asp:Label ID="Label1" runat="server" Font-Size="20pt" Text="Agregar Libros"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="ISBN:     "></asp:Label>
        <asp:TextBox ID="txtISBN" runat="server" Height="23px" Width="351px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="TITULO:     "></asp:Label>
        <asp:TextBox ID="txtTitulo" runat="server" Width="331px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="NUMERO DE EDICION:  "></asp:Label>
        <asp:TextBox ID="txtNEdicion" runat="server" Width="225px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="AÑO DE PUBLICACION:  "></asp:Label>
        <asp:TextBox ID="txtAnoPublicacion" runat="server" Width="216px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="AUTOR(ES):  "></asp:Label>
        <asp:TextBox ID="txtAutor" runat="server" Width="301px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="PAIS DE PUBLICACION:  "></asp:Label>
        <asp:TextBox ID="txtPais" runat="server" Width="218px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="SINOPSIS:  "></asp:Label>
        <asp:TextBox ID="txtSinopsis" runat="server" Width="312px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="CARRERA:  "></asp:Label>
        <asp:TextBox ID="txtCarrera" runat="server" Width="308px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="MATERIA:  "></asp:Label>
        <asp:TextBox ID="txtMateria" runat="server" Width="313px" Height="23px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="AGREGAR" />
    </form>
</body>
</html>
