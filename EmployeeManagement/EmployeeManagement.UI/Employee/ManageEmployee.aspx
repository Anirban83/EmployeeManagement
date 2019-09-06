<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageEmployee.aspx.cs" Inherits="EmployeeManagement.UI.ManageEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <legend>Employee Info</legend>
                <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id: "></asp:Label>
                <asp:TextBox ID="txtEmployeeId" runat="server" ReadOnly="true" BackColor="Wheat"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Bonus: "></asp:Label>
                <asp:TextBox ID="txtBonus" runat="server" ReadOnly="true" BackColor="Wheat"></asp:TextBox>

            </fieldset>
            <br />
            <fieldset>
                <legend>Employee Details</legend>
                <asp:Label ID="Label4" runat="server" Text="Address: "></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </fieldset>
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>
