﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace ppo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string constr;
        SqlConnection con;
        SqlCommand cmd,cmd2;
        SqlDataReader datareader;
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = "Server=.;Database=ppo;User Id=sa;Password=cs1234;";
            con = new SqlConnection(constr);
            Label2.Text = "*";
            Label3.Text = "*";
            Label4.Text = "*";
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string password = TextBox2.Text;
            string cnfpass = TextBox3.Text;
            string type = "u";
            string status = "active";
            string path = "C:\\Users\\TOSHIBA\\Documents\\Visual Studio 2010\\Projects\\ppo\\ppo\\user";
            string fname = TextBox4.Text;
            string lname = TextBox5.Text;
            string email = TextBox6.Text;
            string institute = TextBox7.Text;
            string adr = TextBox8.Text;
            string userpath = "C:\\Users\\TOSHIBA\\Documents\\Visual Studio 2010\\Projects\\ppo\\ppo\\user\\"+user;
            //Response.Write(user + " " + password); 
            string sql = "INSERT INTO [ppo].[dbo].[user] VALUES('" + user + "','" + password + "','" + type + "','"+ status +"','" + path + "','" + fname + "','" + lname + "','" + email + "','" + institute + "','" + adr + "')";
            string sql2 = "SELECT username FROM [user] where username=@username";
            cmd = new SqlCommand(sql, con);
            cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = user;
            con.Open();
            datareader = cmd2.ExecuteReader();
            if (!user.Equals("") && password.Equals(cnfpass) && !password.Equals("") && !datareader.HasRows)
            {
                datareader.Close();
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                cmd.ExecuteNonQuery();
                if (!Directory.Exists(userpath))
                {
                    Directory.CreateDirectory(userpath);
                }
                msgBox.Show("Register success");
                Response.Redirect("~/home.aspx");

            }          
            else if (user.Equals(""))
            {
                Label2.Text="กรุณากรอกข้อมูล";
            }
            else if (datareader.HasRows)
            {
                Label2.Text = "มีผู้ใช้ชื่อนี้แล้ว";
            }
            else if (!password.Equals(cnfpass) || password.Equals(""))
            {
                Label3.Text = "พาสเวิร์ดไม่ถูกต้อง";
            }
            
        }

      
    }
}