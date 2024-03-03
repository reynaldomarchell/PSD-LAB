<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="Session2_lab.Views.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Insert Page</h1>
        <div>
            <asp:Label ID="lblBrand" runat="server" Text="Brand"></asp:Label>
            <asp:TextBox ID="TxtBrand" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="TxtPrice" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblClothtype" runat="server" Text="ClothType"></asp:Label>
            <asp:DropDownList ID="ListClothType" runat="server"></asp:DropDownList>
        </div>
        <asp:Button ID="BtnInsert" runat="server" Text="Insert New Cloth" OnClick="BtnInsert_Click" />
    </form>
</body>
</html>
