<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageEmployee.aspx.cs" Inherits="EmployeeManagement.UI.ManageEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .column {
            float: left;
            width: 50%;
            height: 223px;
        }

        .row:after {
            content: "";
            display: table;
            clear: both;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="column">
                <table>
                    <tr>
                        <th>Employee Details</th>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Phone Number: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtNumber" runat="server" TextMode="Number" Width="170px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Address: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Text="Mail ID: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtMail" runat="server" TextMode="Email" Width="170px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label11" runat="server" Text="Gender: "></asp:Label></td>
                        <td>
                            <asp:RadioButtonList ID="rbtnGender" runat="server">
                                <asp:ListItem Text="Male" Value="M" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="Female" Value="F"></asp:ListItem>
                                <asp:ListItem Text="Others" Value="O"></asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Text="Country ID: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtCountryID" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
            <div class="column">
                <table>
                    <tr>
                        <th>Employee Info</th>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblEmployeeId" runat="server" Text="Employee Id: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtEmployeeId" runat="server" ReadOnly="true" BackColor="Wheat" Width="174px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server" Width="175px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Last Name: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtLastName" runat="server" Width="173px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Dept ID: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtDeptID" runat="server" Width="174px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Salary: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtSalary" runat="server" Width="175px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Bonus: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtBonus" runat="server" ReadOnly="true" BackColor="Wheat" Width="176px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label7" runat="server" Text="Manager ID: "></asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtManagerID" runat="server" Width="175px"></asp:TextBox></td>
                    </tr>
                </table>
            </div>
        </div>
    <br />
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /></div>
    </form>
</body>
</html>
