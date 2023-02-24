<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica_02_BML_ADZR_FXNO.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center><asp:Label ID="Label1" runat="server" Font-Size="24pt" Font-Strikeout="False" Text="Practica 2"></asp:Label></center>
        <div>
        </div>
        <asp:GridView ID="gvLibros" runat="server" AutoGenerateColumns="False">
             <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                <asp:BoundField DataField="TITULO" HeaderText="TITULO" />
                <asp:BoundField DataField="NUMERO_EDICION" HeaderText="NUMERO DE EDICION" />
                <asp:BoundField DataField="ANO_PUBLICACION" HeaderText="AÑO DE PUBLICACION" />
                <asp:BoundField DataField="NOMBRE_AUTORES" HeaderText="NOMBRE DE AUTORES" />
                <asp:BoundField DataField="PAIS_PUBLICACION" HeaderText="PAIS DE PUBLICACION" />
                <asp:BoundField DataField="SINOPSIS" HeaderText="SINOPSIS" />
                <asp:BoundField DataField="CARRERA" HeaderText="CARRERA" />
                <asp:BoundField DataField="MATERIA" HeaderText="MATERIA" />
                <asp:TemplateField>
                    <ItemTemplate>
                         <asp:LinkButton ID="lbtnEliminar" runat="server" OnClick="lbtnEliminar_Click">ELIMINAR</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
             </Columns>
        </asp:GridView>
        <p>
        <asp:LinkButton ID="lbtnAgregar" runat="server" OnClick="lbtnAgregar_Click">AGREGAR</asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <center><asp:Label ID="Label2" runat="server" Text="Brian, Francisco Xavier, Angel David"></asp:Label></center>
        </p>
    </form>
</body>
</html>
