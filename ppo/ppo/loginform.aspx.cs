using System;

using System.Data;

using System.Configuration;

using System.Collections;

using System.Web;

using System.Web.Security;

using System.Web.UI;

using System.Web.UI.WebControls;

using System.Web.UI.WebControls.WebParts;

using System.Web.UI.HtmlControls;

using System.Data.SqlClient;

namespace ppo
{
    public partial class loginform : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataReader reader;
        string constr = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = "Server=.;Database=ppo;User Id=sa;Password=cs1234;";
            con = new SqlConnection(constr);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string type;
            string user = txtUserName.Value.ToString();
            string password = txtUserPass.Value.ToString();
            string strqry = "SELECT [username],[password],[type] from [ppo].[dbo].[user] where username=@username and password=@password";
            SqlCommand cmd = new SqlCommand(strqry, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = user;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                //Response.Write("<script type='text/javascrip'>alert('Hello Sir');</script>");
                msgBox.Show("Welcome " + user);
                reader.Read();
                type = reader["type"].ToString();
                Session["type"] = type;
                Session["user"] = user;
                Session.Timeout = 32;
                lblMsg.Text = "Login Success";
                Response.Redirect("~/home.aspx");
                con.Close();
            }
            else
            {
                lblMsg.Text = "Login failed";
            }

        }

    }
}