
namespace BusinessModel
{
    /// <summary>
    /// This class contains Log messages
    /// </summary>
    public static class Literals
    {
        public static string pageInfo = "\n----------------------------------------------------------- \n" +
                                        "For login page enter : 1 \nFor Registration page enter : 2 \nFor Exit Application enter : 3\n";
        public static string loginSuccess = "\nLogin Successful \nFor Logout Enter : 3\n";
        public static string logoutSuccess = "\nLogout Successful\n";
        public static string invalidCredentials = "\nInvalid Credentials \nFor forgot password page enter : 4\n";
        public static string passwordUpdated = "\nPassword Updated successfully\n";
        public static string passwordUpdateFailed = "\nInvalid Credentials\n";
        public static string emptyDB = "\nNobody Registered yet, so Register now \nData Base is empty\n";
        public static string invalidPage = "\nPlease Enter Valied Page\n";
        public static string inputUsername = "\nNOTE: Username length should be between 8 and 15 characters.\n\n" +
                                             "Enter Username : ";
        public static string inputPassword = "\nNOTE : Password length should be between 8 and 15 characters.\n" +
                                             "       The password must include at least one or more integers.\n" +
                                             "       Only one special character is allowed in a password.\n\nEnter Password : ";
        public static string inputNewPassword = "\nNOTE : Password length should be between 8 and 15 characters.\n" +
                                             "       The password must include at least one or more integers.\n" +
                                             "       Only one special character is allowed in a password.\n\nEnter New Password : ";
        public static string inputName = "\nEnter Name : ";
        public static string inputPhoneNo = "\nEnter PhoneNumber : ";
        public static string registerSuccessful = "\nSuccessfuly Registered\n";
        public static string userExists = "\nUsername already exists Registration Failed!!\n";
        public static string invalidName = "\nInvalid Name Registration Failed!!\n";
        public static string invalidPhoneNo = "\nInvalid Phone number Registration Failed!!\n";
        public static string invalidPassword = "\nEnter valid password Registration Failed!!\n";
        public static string invalidUsername = "\nEnter valid username Registration Failed!!\n";
    }
}