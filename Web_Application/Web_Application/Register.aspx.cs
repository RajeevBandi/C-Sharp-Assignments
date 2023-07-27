using System;
using BusinessModel;
using BusinessLogicLayer;

namespace Web_Application
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            UserInfo userObj = new UserInfo();
            userObj.Username = txtUsername.Text;
            userObj.Password = txtPassword.Text;
            userObj.Email = txtEmail.Text;

            BALFactory BALFactoryObj = new BALFactory();
            IBAL BALObj = BALFactoryObj.BALObjCreation();
            string response = BALObj.Registration(userObj);
            if (response == StringLiterals.successfullRegistration)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('" + response + "')</script>");
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}