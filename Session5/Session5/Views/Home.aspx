<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Session5.Views.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewCloth" runat="server" OnSelectedIndexChanged="GridViewCloth_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Detail"></asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>        
        <div>
            <asp:Label ID="CountLbl" runat="server" Text="Count Label"></asp:Label>
        </div>      
        <div>
            <asp:Label ID="PriceLbl" runat="server" Text="Total Price Label"></asp:Label>
        </div>
    </form>
</body>
</html>
