<%@ Page Title="home" Language="C#" MasterPageFile="~/ppo.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ppo.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:HyperLink ID="submitLink" runat="server" NavigateUrl="~/problem/submit.aspx">way to submit</asp:HyperLink>

</asp:Content>
