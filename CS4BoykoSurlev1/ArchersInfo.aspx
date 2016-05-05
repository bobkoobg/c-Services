<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArchersInfo.aspx.cs" Inherits="CS4BoykoSurlev1.ArchersInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ArchersInfo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Get Alias and Awards by Filling in Real Name"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Write someone's real name:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxRealName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonInfo" runat="server" OnClick="ButtonInfo_Click" Text="get info" />
        <br />
        <asp:TextBox ID="TextBoxResult" runat="server" Enabled="False" Width="808px"></asp:TextBox>
    </form>
</body>
</html>
