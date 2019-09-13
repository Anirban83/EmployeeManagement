<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucReport.ascx.cs" Inherits="EmployeeManagement.UI.ucReport" %>

<div>
    <asp:Label ID="lblReportType" runat="server" Text=""></asp:Label>
    <br />
    <asp:GridView ID="dgvReportResult" runat="server" Width="100%">
        <HeaderStyle ForeColor="#0055aa" />
    </asp:GridView>
</div>
