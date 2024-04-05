<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Session7.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtName" runat="server" placeHolder="Name"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" placeHolder="Price"></asp:TextBox>
        <asp:Button ID="btnCreate" runat="server" Text="Button" OnClick="btnCreate_Click" />

        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="Id" SortExpression="id"></asp:BoundField>
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name"></asp:BoundField>
                    <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price"></asp:BoundField>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
