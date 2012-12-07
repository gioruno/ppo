using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ppo
{
    public partial class problem1 : System.Web.UI.MasterPage
    {
        String constr;
        SqlConnection con;
        SqlDataReader sreader;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = "Server=.;Database=ppo;User Id=sa;Password=cs1234;";
            con = new SqlConnection(constr);
            Label1.Text = "";

            if (Session["user"] == null)
            {
                Label1.Text = "";
                linkUser.Text = "";
                this.logLink.Text = "Login";
                this.logLink.NavigateUrl = "~/loginform.aspx";
                this.logLink.Target = "blank";
                this.regLink.Text = "Register";
                this.regLink.NavigateUrl = "~/registerform.aspx";
                this.regLink.Target = "blank";
            }
            else
            {
                Label1.Text = "Welcome ";
                if (Session["type"].ToString().Equals("u"))
                    linkUser.Text = Session["user"].ToString();
                else
                {
                    Label1.Text += "Admin";
                    linkUser.Text = "" + Session["user"].ToString();
                }
                if (Session["type"].ToString().Equals("a"))
                {
                    linkUser.NavigateUrl = "/profile.aspx";
                }
                else
                {
                    linkUser.NavigateUrl = "/profile.aspx";
                }
                this.regLink.Text = "";
                this.logLink.Text = "Logout";
                this.logLink.NavigateUrl = "~/logout.aspx";
                this.logLink.Target = "blank";
            }
         
            try
            {
                string sql = "SELECT * FROM lvl";
                cmd = new SqlCommand(sql, con);
                con.Open();
                sreader = cmd.ExecuteReader();
                while (sreader.Read())
                {
                    int lid=(int)sreader["lvl"];
                    string lvlname = (String)sreader["lvldetail"];
                    Literal lit = new Literal();
                    lit.Text = "<br/>";
                    //int lvl = Convert.ToInt32(lidread);
                    string qry01 = "lvlname="+lvlname;
                    string qry02 = "lid="+lid;
                    
                    HyperLink hlink = new HyperLink();
                    hlink.ID = ""+lvlname;
                    hlink.Text = ""+lvlname;
                    hlink.NavigateUrl = "~/problem/level.aspx?" + qry02 + "&" + qry01;
                    PlaceHolder1.Controls.Add(hlink);
                    PlaceHolder1.Controls.Add(lit);
                    
                }
            }
           finally
            {
                if (sreader != null)
                {
                    sreader.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
            
        }
    }
}