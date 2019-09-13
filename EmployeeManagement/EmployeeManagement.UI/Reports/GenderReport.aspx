<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenderReport.aspx.cs" Inherits="EmployeeManagement.UI.GenderReport" %>

<%@ Register Src="~/UserControls/ucReport.ascx" TagPrefix="uc1" TagName="ucReport" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:ucReport runat="server" id="ucReport" />
    </form>
</body>
</html>
