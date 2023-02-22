<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewImport.aspx.cs" Inherits="WCFWebClient.ViewImport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>List Import</h1><asp:GridView ID="gv_LstImport" runat="server" Height="318px" Width="851px" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br></br>
        <asp:TextBox ID="txt_Id" runat="server" Height="44px" Width="460px"></asp:TextBox>
        <asp:Button ID="btn_Call" runat="server" OnClick="btn_Call_Click" Text="CallService" />
    </form>
</body>
</html>
