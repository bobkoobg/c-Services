<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArchersCalculator.aspx.cs" Inherits="CS4BoykoSurlev1.ArchersCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculating Archers Info</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Make calculation for the points scored by different archers"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Write someone's alias :"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonTotal" runat="server" Text="Total Points" OnClick="ButtonTotal_Click" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonAverage" runat="server" Text="Average Points" OnClick="ButtonAverage_Click" />
&nbsp;&nbsp;
        <asp:Button ID="ButtonSortedNumbers" runat="server" Text="Sorted Numbers" OnClick="ButtonSortedNumbers_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Your result:"></asp:Label>
        <br />
        <asp:ListBox ID="ListBoxResult" runat="server" Height="107px" Width="450px"></asp:ListBox>
    </form>
</body>
</html>
