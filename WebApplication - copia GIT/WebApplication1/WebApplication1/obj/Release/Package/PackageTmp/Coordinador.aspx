<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Coordinador.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
        <div>
    
         <table style="width:100%; height: 209px;">
            <tr>
                <td class="auto-style2" colspan="2">
                    <p style="text-align: center; font-size: 40px; font-style: normal; font-variant: small-caps; color: #0000FF; background-color: #C0C0C0; font-weight: bold; width: 1475px;"> 
                        <br />
                        Coordinador:        
                    <asp:Label ID="LabelUsuario" runat="server"></asp:Label>=&gt; HORAS MEDIAS NO PRESENCIALES
                        <br /><br />
                    </p>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                        <asp:LinkButton ID="LinkButtonCerrarSesion" runat="server">Cerrar Sesion</asp:LinkButton>
                </td>
                <td class="auto-style1">                                   
                        <br />        
                        <br />        
                </td>
            </tr>

        </table>
    
    </div>




    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo" >
        </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BaseDatosConnectionString3 %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
      
        <asp:Button ID="Button1" runat="server" Text="Mostrar Dedicaciones" />

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>


         




    </form>
</body>
</html>
