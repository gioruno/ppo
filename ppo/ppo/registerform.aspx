<%@ Page Title="" Language="C#" MasterPageFile="~/ppo.Master" AutoEventWireup="true" CodeBehind="registerform.aspx.cs" Inherits="ppo.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
         <fieldset>
        <p>
          <label>ชื่อผู้ใช้งาน</label>  
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <!-- add .align-right to align the input elements to the right -->
          <span style="color: #000; margin-left: 10px;" class="">
          <span style="color: #000; " class="">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="*"></asp:Label>
            </span></span></p>
        <p>
          <label>	รหัสผ่าน</label>&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span style="color: #000; margin-left: 10px;" class="">
            <span style="color: #000; " class="">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="*"></asp:Label>
            </span></span></p>
        <p>
          <label>	ยืนยันรหัสผ่าน&nbsp;&nbsp; </label>
&nbsp;<!-- add .align-right to align the input elements to the right --><span style="color: #000; margin-left: 10px;" class=""><span style="color: #000; " class=""><asp:TextBox 
                ID="TextBox3" runat="server" TextMode="Password" Width="126px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="*"></asp:Label>
            </span></span></p>
        <p>
          <label>	ชื่อ </label>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <!-- the value-attribute overwrites the <label>Username</label> -->
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
             </p>
        <p>สกุล&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
             </p>
        <p>
          <label>อีเมลล์&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <!-- add .align-right to align the input elements to the right --><span style="color: #000; margin-left: 10px;" class="">
            <span style="color: #000; " class="">
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </span*</span></p>
        <p>
            สถาบัน&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            ที่อยู่&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server" Height="74px" TextMode="MultiLine" 
                Width="236px"></asp:TextBox>
        </p>
        <p> <small>* ข้อมูลที่ต้องกรอกก>
        <p>
          
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<label><span 
                style="color: #000; " class=""><small><asp:Button ID="submit" 
                runat="server" Text="ยืนยัน" onclick="submit_Click" />
            </small></span>
            </label>
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;
          <input type="reset" name="reset" id="reset" value="ล้าง" onclick="return reset_onclick()" />
         
        </p>
             </small></span></span>
             </label>
</fieldset>
    </div>
</asp:Content>
