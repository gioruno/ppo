using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ppo.profile
{
    public partial class level : System.Web.UI.Page
    {
        String constr;
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = "Server=.;Database=ppo;User Id=sa;Password=cs1234;";
            con = new SqlConnection(constr);
            string sql = "SELECT * From problem where lvl=@lvl";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@lvl", SqlDbType.VarChar, 50).Value = Request.QueryString["lid"];
            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int pid = (int)reader["prob_id"];
                string pname = (string)reader["probname"];
                Literal lit = new Literal();
                lit.Text = "<br/>";
                Literal lit2 = new Literal();
                lit2.Text = "<br/>";
                HyperLink idlink = new HyperLink();
                idlink.ID = pid + "link";
                idlink.Text = pid.ToString();
                idlink.NavigateUrl = "~/problem/submit.aspx?prob_id=" + pid + "&probname=" + pname;
                PlaceHolder2.Controls.Add(idlink);
                 PlaceHolder2.Controls.Add(lit);
                HyperLink pnamelink = new HyperLink();
                pnamelink.ID = pname + "link";
                pnamelink.Text = ""+pname;
                pnamelink.NavigateUrl = "~/problem/submit.aspx?prob_id=" + pid + "&probname=" + pname;
                PlaceHolder3.Controls.Add(pnamelink);
                PlaceHolder3.Controls.Add(lit2);

            }
            reader.Close();
            string sql2 = "SELECT lvldetail FROM lvl where lvl=@lv";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            cmd2.Parameters.Add("@lv", SqlDbType.VarChar, 50).Value = Request.QueryString["lid"];
            cmd2.ExecuteNonQuery();
            reader = cmd2.ExecuteReader();
            reader.Read();
            Label2.Text = (string)reader["lvldetail"];
            reader.Close();

        }
    }
}