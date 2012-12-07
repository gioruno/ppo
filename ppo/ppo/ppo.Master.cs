using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ppo
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkLogin();
        }
        protected void checkLogin()
        {
            Label1.Text = "";
            //HttpContext.Current.Session["user"]
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
                this.regLink.Text = "";
                this.logLink.Text = "Logout";
                this.logLink.NavigateUrl = "~/logout.aspx";
                this.logLink.Target = "blank";
            }
        }
    }
}