using BusinessModel;

namespace BusinessLayer
{
    /// <summary>
    /// used to access the methods in BAL 
    /// </summary>
    public interface IBAL
    {
        public bool Login(User usersObj);
        public bool ForgotPassword(User usersObj);
        public string Registration(User usersObj);
    }
}