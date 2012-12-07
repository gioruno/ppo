using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ppo
{
    public partial class statistic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                string qry = Page.Title.ToString();
                Response.Redirect("/loginform.aspx?prepage=" + qry);
            }
        }
    }
}