<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Interface.aspx.cs" Inherits="PicoPlaca.Interface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;
        <div>
            <asp:Label ID="Label4" runat="server" Text="PICO Y PLACA PREDICTOR" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="Blue"></asp:Label>
        </div>
        
        <br />
&nbsp;<div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="License plate (ej. pbb2021):" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtLicense" runat="server" Font-Size="Large"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Date (dd/mm/yyy) (ej. 13/03/2021):" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDate" runat="server" Font-Size="Large" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Hour (24h)(ej. 13:00):" Font-Size="Large"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtHour" runat="server" Font-Size="Large"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPredict" runat="server" Height="36px" OnClick="Button1_Click" Text="PREDICT" Width="184px" BorderStyle="Double" />
            <br />
        </div>
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="44px" style="margin-top: 0px">
            &nbsp;
            <asp:Label ID="lblResultado" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        </asp:Panel>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
