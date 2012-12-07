using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ppo
{
    public partial class profileMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                validateUser();
            }
        }
        protected Boolean checkLogin()
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
                return false;
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
                return true;
            }
        }
        protected void validateUser()
        {
            if (Session["type"].ToString().Equals("a"))
            {
                linkUser.NavigateUrl = "/profile.aspx";
                Literal lit01 = new Literal();
                Literal lit02 = new Literal();
                Literal lit03 = new Literal();
                HyperLink h1 = new HyperLink();
                HyperLink h2 = new HyperLink();
                HyperLink h3 = new HyperLink();
                h1.Text = "Edit News";
                h1.NavigateUrl = "";
                h2.Text = "Manage User";
                h2.NavigateUrl = "/profile/manageUser.aspx";
                h3.Text = "Upload Problem";
                h3.NavigateUrl = "/profile/uploadProblem.aspx";

                lit01.Text = "</br>";
                lit02.Text = "</br>";
                lit03.Text = "</br>";
                PlaceHolder1.Controls.Add(h1);
                PlaceHolder1.Controls.Add(lit01);
                PlaceHolder1.Controls.Add(h2);
                PlaceHolder1.Controls.Add(lit02);
                PlaceHolder1.Controls.Add(h3);
                PlaceHolder1.Controls.Add(lit03);
            }
            else
            {
                linkUser.NavigateUrl = "/profile.aspx";
                
                Literal lit01 = new Literal();
                HyperLink h1 = new HyperLink();
                HyperLink h2 = new HyperLink();
                HyperLink h3 = new HyperLink();
                h1.Text = "Edit Profile";
                h1.NavigateUrl = "";
                h2.Text = "View Statistic";
                h2.NavigateUrl = "/profile/manageUser.aspx";
                h3.Text = "....";
                h3.NavigateUrl = "";

                lit01.Text = "</br>";
                PlaceHolder1.Controls.Add(h1);
                PlaceHolder1.Controls.Add(lit01);
                PlaceHolder1.Controls.Add(h2);
                PlaceHolder1.Controls.Add(lit01);
                PlaceHolder1.Controls.Add(h3);
            }
        }
    }
}