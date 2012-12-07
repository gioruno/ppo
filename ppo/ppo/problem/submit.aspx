<%@ Page Title="submit" Language="C#" MasterPageFile="~/ppo.Master" AutoEventWireup="true" CodeBehind="submit.aspx.cs" Inherits="ppo.submit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="subButton_Click" 
        Text="Submit" />
    </asp:Content>
