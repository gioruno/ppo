<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="loginControl.ascx.cs" Inherits="ppo.loginControl" %>

<fieldset>
    <table><tr>
<td>Username:</td>
<td><input id="txtUserName" type="text" runat="server"/></td>
<td><ASP:RequiredFieldValidator ControlToValidate="txtUserName"

Display="Static" ErrorMessage="*" runat="server"
ID="vUserName" /></td>

</tr>

<tr>

<td>Password:</td>

<td><input id="txtUserPass" type="password" runat="server"/></td>

<td><ASP:RequiredFieldValidator ControlToValidate="txtUserPass"

Display="Static" ErrorMessage="*" runat="server"
ID="vUserPass" />

</td>

</tr>

<tr>


<td colspan="2"><ASP:CheckBox id="checkbox1" runat="server" autopostback="false" 
        Text="Don't forget me" />&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;
  
    &nbsp;<asp:Button ID="Button1" runat="server" Text="Login" 
        onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/registerform.aspx">Register</asp:HyperLink>
    </td></tr>
    </table>
    </fieldset>
    <p>
    &nbsp; 
    <asp:Label ID="lblMsg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server" Text="" /> </p>
    