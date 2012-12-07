<%@ Page Title="" Language="C#" MasterPageFile="~/problem.Master" AutoEventWireup="true" CodeBehind="level.aspx.cs" Inherits="ppo.profile.level" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style6
        {
            width: 109px;
        }
        .style9
        {
            width: 280px;
        }
        .style10
        {
            width: 126px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div align="center">

    <asp:Label ID="Label2" runat="server" Text="Label" Font-Bold="True"></asp:Label>
    <br />
    <br />
    <table style="width:90%;" frame="vsides">
        <tr>
            <td class="style10" style="width:10%;">
                ID</td>
            <td class="style9" style="width:40%;">
                Name</td>
            <td class="style6" style="width:20%;">
                Submit</td>
            <td class="style6" style="width:20%;">
                Submit Passed</td>
        </tr>
        <tr>
            <td class="style10">
                <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
            </td>
            <td class="style9">
                <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
            </td>
            <td class="style6">
                <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
            </td>
            <td>
                <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
            </td>
        </tr>
        </table>
</div>
</asp:Content>
