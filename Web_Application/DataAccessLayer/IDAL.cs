using BusinessModel;
namespace DataAccessLayer
{
    /// <summary>
    /// used to access the methods in DAL
    /// </summary>
    public interface IDAL
    {
        string CheckValidUser(UserInfo userObj);
        string GetUserPassword(UserInfo userObj);
        string UpdatePassword(UserInfo userObj);
        string SaveUser(UserInfo userObj);

    }
}
