<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Session8FrontEnd.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="FoodGV" runat="server"></asp:GridView>
        </div>

        <div>
            <asp:TextBox ID="IdTxt" placeholder="Id" runat="server"></asp:TextBox>
        </div>        
        <div>
            <asp:TextBox ID="NameTxt" placeholder="Name" runat="server"></asp:TextBox>
        </div>        
        <div>
            <asp:TextBox ID="PriceTxt" placeholder="Price" TextMode="Number" runat="server"></asp:TextBox>
        </div>
       
        <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click1" />
    </form>
</body>
</html>
