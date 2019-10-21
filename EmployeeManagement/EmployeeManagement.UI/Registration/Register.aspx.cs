using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.BL;
using System.Web.Security;

namespace EmployeeManagement.UI.Registration
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            IAuthenticateBL authBL = new AuthenticateBL();
            string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text,"SHA1");
            int statusCode = authBL.RegisterUser(txtUserName.Text, encryptedPassword, txtEmail.Text);

            if (statusCode == -1)
            {
                lblMessage.Text = "User Name already in use, please choose another user name";
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }
    }
}