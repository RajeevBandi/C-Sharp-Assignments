
namespace BusinessLogicLayer
{
    /// <summary>
    /// used to access the methods in BAL 
    /// </summary>
    public interface IBAL
    {
        string Login(BusinessModel.UserInfo userObj);
        string ForgotPassword(BusinessModel.UserInfo userObj);
        string Registration(BusinessModel.UserInfo userObj);
    }
}
