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
    public partial class manageUser : System.Web.UI.Page
    {
        String constr;
        SqlConnection con;
        SqlDataReader reader;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = "Server=.;Database=ppo;User Id=sa;Password=cs1234;";
            con = new SqlConnection(constr);
            showDataGridview();
        }
        protected void showDataGridview()
        {
            DataTable dt = new DataTable();
            String sql01 = "SELECT * FROM [user]";
            cmd = new SqlCommand(sql01, con);
            con.Open();
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            reader.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String sql01 = "SELECT * FROM [user] WHERE USER=@username";
            cmd = new SqlCommand(sql01, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text;
            con.Open();
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            reader.Close();
            Response.Write("Textbox1");
        }
    }
}