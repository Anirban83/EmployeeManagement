using System;
using System.Security.Principal;

namespace EmployeeManagement.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Application code executed using: ");
            Response.Write(WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is User Authenticated: ");
            Response.Write(User.Identity.IsAuthenticated + "<br/>");

            Response.Write("Authentication type: ");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("User Name: ");
            Response.Write(User.Identity.Name + "<br/>");

            Response.Write("<hr/>");
            Response.Write("Application Starttime: " + Application["AppStartTime"] + "<br/>");
            Response.Write("UserCount: " + Application["UserCount"] + "<br/>");

            Response.Write("Random Session Number: " + Session["RandomNumber"] + "<br/>");
            
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Response.Write("You Typed: " + name);
            //Session["UserName"] = txtName.Text;
            //Session["UserEmail"] = txtEmail.Text;
            ////Write Cookie  
            //HttpCookie cookie = new HttpCookie("Democookie");
            ////Response.Cookies["userinfo"]["UserName"] = txtName.Text;
            ////Response.Cookies["userinfo"]["UserEmail"] = txtEmail.Text;
            //cookie["UserName"] = txtName.Text;
            //cookie["UserEmail"] = txtEmail.Text;
            //Response.Cookies.Add(cookie);
            //cookie.Expires = DateTime.Now.AddDays(1);

            //Response.Redirect("~/Home2.aspx");
        }
    }
}