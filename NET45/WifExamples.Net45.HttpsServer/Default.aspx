﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WifExamples.Net45.HttpsServer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome!</h1>
        <h3>These are your claims:</h3>
        <asp:GridView ID="ClaimsGridView" AutoGenerateColumns="false" runat="server">
            <Columns> 
            <asp:BoundField DataField="Type" HeaderText="Type" ReadOnly="True" /> 
            <asp:BoundField DataField="Value" HeaderText="Value" ReadOnly="True" /> 
        </Columns> 
        </asp:GridView>
        <a href="Managers.aspx">Go to Managers' page</a>
        <hr />
        Server time: <%= DateTime.Now %>
    </div>
    </form>
</body>
</html>
