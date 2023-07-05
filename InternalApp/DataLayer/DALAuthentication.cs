using BM = BusinessModel;
using DM = DataModel;

namespace DataLayer
{
    /// <summary>
    /// used to compare database data and user input also to perform operations on database.
    /// </summary>
    internal class DALAuthentication : IDAL
    {
        /// <summary>
        /// This method verifies that the username and password match those in the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidLoginDetails(BM.User usersObj)
        {
            DM.User findUser = DataSource.userDetails.Find(findUser => findUser.Username == usersObj.Username);
            if (findUser != null && findUser.Password == usersObj.Password)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// User password is updated to database.
        /// </summary>
        /// <param name="usersObj"></param>
        /// <returns></returns>
        public bool UpdatePassword(BM.User usersObj)
        {
            DM.User findUser = DataSource.userDetails.Find(findUser => findUser.Username == usersObj.Username);
            if (findUser != null)
            {
                findUser.Password = usersObj.Password;
                return true;
            }
            return false;
        }


        /// <summary>
        /// User information is saved to a database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="phoneNo"></param>
        public void SaveUser(BM.User usersObj)
        {
            DM.User User = new DM.User();
            User.Username = usersObj.Username;
            User.Password = usersObj.Password;
            User.PhoneNo = usersObj.PhoneNo;
            User.Name = usersObj.Name;

            DataSource.userDetails.Add(User);
        }

        /// <summary>
        /// This method verifies that the username match those in the database.
        /// </summary>
        /// <param name="usersObj"></param>
        /// <returns></returns>
        public bool IsUsernameExists(BM.User usersObj)
        {
            DM.User findUser = DataSource.userDetails.Find(findUser => findUser.Username == usersObj.Username);
            if (findUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
