using AutoMapper;
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
            DataSource.userDetails.Add(ConvertModel<BM.User, DM.User>(usersObj));
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


        /// <summary>
        /// Conversion of business models object to data models object.
        /// </summary>
        /// <param name="usersObj"></param>
        /// <returns></returns>
        //public DM.User UserConverter(BM.User usersObj)
        //{
        //    DM.User User = new DM.User();
        //    User.Username = usersObj.Username;
        //    User.Password = usersObj.Password;
        //    User.PhoneNo = usersObj.PhoneNo;
        //    User.Name = usersObj.Name;
        //    return User;
        //}

        //public U UserConverter<T, U>(T usersObj) where U : DM.User, new() where T : BM.User, new()
        //{
        //    U convertedUser = new U();
        //    convertedUser.Username = usersObj.Username;
        //    convertedUser.Password = usersObj.Password;
        //    convertedUser.PhoneNo = usersObj.PhoneNo;
        //    convertedUser.Name = usersObj.Name;
        //    return convertedUser;
        //}

        //public T UserConverter<B, D, T>(dynamic usersObj) where B : BM.User, new() where D : DM.User, new() 
        //{
        //    if (usersObj is BM.User)
        //    {
        //        D newUserObj = new D();
        //        newUserObj.Username = usersObj.Username;
        //        newUserObj.Password = usersObj.Password;
        //        newUserObj.Name = usersObj.Name;
        //        newUserObj.PhoneNo = usersObj.PhoneNo;
        //        return (dynamic)newUserObj;
        //    }
        //    else
        //    {
        //        B newUserObj = new B();
        //        newUserObj.Username = usersObj.Username;
        //        newUserObj.Password = usersObj.Password;
        //        newUserObj.Name = usersObj.Name;
        //        newUserObj.PhoneNo = usersObj.PhoneNo;
        //        return (dynamic)newUserObj;
        //    }
        //}

        /// <summary>
        /// implementing object conversion using GetProperties
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="userObj"></param>
        /// <returns></returns>
        //public U ConvertModel<T, U>(T userObj) where U : new()
        //{
        //    var resultObj = new U();

        //    var TProperties = typeof(T).GetProperties();
        //    var UProperties = typeof(U).GetProperties();

        //    foreach (var iterator in TProperties)
        //    {
        //        var property = UProperties.FirstOrDefault(findProperty => findProperty.Name == iterator.Name && findProperty.PropertyType == iterator.PropertyType);

        //        if (property != null)
        //        {
        //            var value = iterator.GetValue(userObj);
        //            property.SetValue(resultObj, value);
        //        }
        //        else
        //        {
        //            property.SetValue(resultObj, null);
        //        }
        //    }
        //    return resultObj;
        //}

        /// <summary>
        /// implementing object conversion using automapper 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public U ConvertModel<T, U>(T userObj) where U : new()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<T, U>());
            var mapper = new Mapper(config);
            return mapper.Map<U>(userObj);
        }

    }
}
