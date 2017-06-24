<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="WebUserControl1.ascx.vb" Inherits="WebApplication1.WebUserControl1" %>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Timer ID="Timer1" runat="server" Interval="1000">
        </asp:Timer>
<br />
        <asp:Label ID="Label1" runat="server" Text="Numero Alumnos Logueados: "></asp:Label>
        <asp:Label ID="LabelAlumnosLogueados" runat="server" Text="0"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Numero Profesores Logueados: "></asp:Label>
        <asp:Label ID="LabelProfesoresLogueados" runat="server" Text="0"></asp:Label>
        <br />
        <asp:ListBox ID="ListBoxAlumnos" runat="server" Height="85px" Width="228px"></asp:ListBox>
        &nbsp;&nbsp;
        <asp:ListBox ID="ListBoxProfesores" runat="server" Height="84px" Width="242px"></asp:ListBox>
        <br />
<br />
    </ContentTemplate>
</asp:UpdatePanel>