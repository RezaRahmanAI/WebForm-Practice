<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="Test.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Name:
        <asp:TextBox ID="txtName" CssClass="ml-2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClick="btnSubmit_Click" />
        </p>
        <asp:TextBox ID="showName" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
