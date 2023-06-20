using BusinessModel;
namespace DataLayer
{
    /// <summary>
    /// used to access the methods in DAL 
    /// </summary>
    public interface IDAL
    {
        public bool IsValidLoginDetails(User usersObj);
        public bool UpdatePassword(User usersObj);
        public void SaveUser(User usersObj);
        public bool IsUsernameExists(User usersObj);
    }
}
