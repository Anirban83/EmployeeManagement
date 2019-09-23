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
        }
    }
}