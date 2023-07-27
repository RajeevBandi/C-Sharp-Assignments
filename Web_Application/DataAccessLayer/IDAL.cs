using BusinessModel;
namespace DataAccessLayer
{
    /// <summary>
    /// used to access the methods in DAL
    /// </summary>
    public interface IDAL
    {
        string CheckValidLoginDetails(UserInfo userObj);
        string UpdatePassword(UserInfo userObj);
        string SaveUser(UserInfo userObj);

    }
}
