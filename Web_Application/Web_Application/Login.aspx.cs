using System;
using BusinessLogicLayer;
using BusinessModel;

namespace Web_Application
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserInfo userObj = new UserInfo();
            userObj.Username = txtUsername.Text;
            userObj.Password = txtPassword.Text;

            BALFactory BALFactoryObj = new BALFactory();
            IBAL BALObj = BALFactoryObj.BALObjCreation();
            string response = BALObj.Login(userObj);
            if (response == StringLiterals.loginSuccess)
            {
                Response.Redirect("LoginSuccess.aspx");
            }
            else
            {
                Response.Write("<script>alert('" + response + "')</script>");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}