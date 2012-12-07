<%@ Page Title="manageUser" Language="C#" MasterPageFile="~/profileMaster.Master" AutoEventWireup="true" CodeBehind="manageUser.aspx.cs" Inherits="ppo.profile.manageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center"><asp:TextBox ID="TextBox1" runat="server" Width="165px" 
            ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
</div>
</asp:Content>
