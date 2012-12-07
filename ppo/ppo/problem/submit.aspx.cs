using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.DynamicData;
using System.IO;
using System.Configuration;

namespace ppo
{
    public partial class submit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string line;
                using (StreamReader sr = new StreamReader(@"C:\Users\TOSHIBA\Documents\Visual Studio 2010\Projects\ppo\ppo\problem\Easy\Triangle\Triangle.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        Literal lit = new Literal();
                        lit.Text = line;
                        PlaceHolder1.Controls.Add(lit);
                        Literal lit2 = new Literal();
                        lit2.Text = "</br>";
                        PlaceHolder1.Controls.Add(lit2);
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("The file could not be read:");
                Response.Write(ex.Message);
            }

            //string SavePath=SavePath = ConfigurationManager.AppSettings["PatientPhotoImages"].ToString()+ GetUniqueKey() + GetFileExtension(hpf.FileName);

        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            FileUpload FileUpload1 = (FileUpload)PlaceHolder1.FindControl("FileUpload1");
            if (IsPostBack)
            {
                Boolean fileOK = false;
                //String path = Server.MapPath("~/");
                String path = @"C:/";
                if (FileUpload1.HasFile)
                {
                    String fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    String[] allowedExtensions = { ".c" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK)
                {
                    try
                    {
                        FileUpload1.PostedFile.SaveAs(path + FileUpload1.FileName);
                        Label2.Text = "File uploaded!";
                        Session["filesubmit"] = FileUpload1.FileName;
                    }
                    catch (Exception ex)
                    {
                        Label2.Text = "File could not be uploaded.";
                    }
                }
                else
                {
                    Label2.Text = "Cannot accept files of this type.";
                }
            }
        }
    }
}