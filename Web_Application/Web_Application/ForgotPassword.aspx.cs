using System;
using System.Configuration;
using System.Data.SqlClient;
using BusinessLogicLayer;
using BusinessModel;

namespace Web_Application
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnSavePassword_Click(object sender, EventArgs e)
        {
            UserInfo userObj = new UserInfo();
            userObj.Username = txtUsername.Text;
            userObj.Email = txtEmail.Text;
            userObj.NewPassword = txtNewPassword.Text;
            string _ConfirmPassword = txtConfirmPassword.Text;

            if (userObj.NewPassword != _ConfirmPassword)
            {
                Response.Write("<script>alert('Error!! Confirm password dosent match')</script>");
            }
            else
            {
                BALFactory BALFactoryObj = new BALFactory();
                IBAL BALObj = BALFactoryObj.BALObjCreation();
                string response = BALObj.ForgotPassword(userObj);

                if (response == StringLiterals.successfullyUpdated)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('" + response + "')</script>");
                }
            }
        }
    }
}