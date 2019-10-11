using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement.UI
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] != null)
                    lblUserName.Text = "UserName passed from home page in Session State: " + Session["UserName"].ToString();              
                else
                    lblUserName.Text = "UserName passed from home page in Application State: " + Application["UserName"].ToString();
                
                if (Session["UserEmail"] != null)
                    lblEmail.Text = "UserEmail passed from home page in Session State: " + Session["UserEmail"].ToString();               
                else
                    lblEmail.Text = "UserEmail passed from home page in Application State: " + Application["UserEmail"].ToString();

                HttpCookie cookie = Request.Cookies["userinfo"];

                if (cookie != null)
                    lblUserName2.Text = "UserName passed from home page in cookie: " + cookie["UserName"].ToString();
                else
                    lblUserName2.Text = "UserName passed from home page in Application State: " + Application["UserName"].ToString();

                if (cookie != null)
                    lblEmail2.Text = "UserEmail passed from home page in cookie: " + cookie["UserEmail"].ToString();
                else
                    lblEmail2.Text = "UserEmail passed from home page in Application State: " + Application["UserEmail"].ToString();
            }
        }
    }
}