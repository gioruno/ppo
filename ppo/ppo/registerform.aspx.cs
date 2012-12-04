using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ppo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string constr;
        SqlConnection con;
        SqlCommand cmd;
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
            string path = "C:\\Users\\TOSHIBA\\Documents\\Visual Studio 2010\\Projects\\ppo\\ppo\\user";
            string fname = TextBox4.Text;
            string lname = TextBox5.Text;
            string email = TextBox6.Text;
            string institute = TextBox7.Text;
            string adr = TextBox8.Text;
            string userpath = "";
            //Response.Write(user + " " + password); 
            string sql = "INSERT INTO [ppo].[dbo].[user] VALUES('" + user + "','" + password + "','" + type + "','" + path + "','" + fname + "','" + lname + "','" + email + "','" + institute + "','" + adr + "')";
            cmd = new SqlCommand(sql, con);
            if (!user.Equals("") && password.Equals(cnfpass) && !password.Equals(""))
            {
                Label2.Text = "";
                Label3.Text = "";
                Label4.Text = "";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("~/home.aspx");
            }
            else if (user.Equals(""))
            {
                Label2.Text="กรุณากรอกข้อมูล";
            }
            else if (!password.Equals(cnfpass) || password.Equals(""))
            {
                Label3.Text = "พาสเวิร์ดไม่ถูกต้อง";
            }
        }

      
    }
}