using BusinessModel;
using DataLayer;

namespace BusinessLayer
{
    /// <summary>
    /// user information authentication in business layer
    /// </summary>
    internal class BALAuthentication : IBAL
    {

        /// <summary>
        /// Checks wether the user login details are valid or not
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(User usersObj)
        {
            DALFactory DALObj = new DALFactory();
            IDAL DALFactoryObj = DALObj.DALObjCreation();
            return DALFactoryObj.IsValidLoginDetails(usersObj);
        }

        /// <summary>
        /// Checks wether the user forgot password details are valid or not
        /// </summary>
        /// <param name="usersObj"></param>
        /// <returns></returns>
        public bool ForgotPassword(User usersObj)
        {
            DALFactory DALObj = new DALFactory();
            IDAL DALFactoryObj = DALObj.DALObjCreation();
            return DALFactoryObj.UpdatePassword(usersObj);
        }

        /// <summary>
        /// Checks wether the user registration details valid or not
        /// </summary>
        /// <param name="usersObj"></param>
        /// <returns></returns>
        public string Registration(User usersObj)
        {
            BALValidation valObj = new BALValidation();
            DALFactory DALObj = new DALFactory();
            IDAL DALFactoryObj = DALObj.DALObjCreation();
            string validationStatus = valObj.ValidRegisteration(usersObj);

            if (validationStatus == Literals.registerSuccessful)
            {
                if (!DALFactoryObj.IsUsernameExists(usersObj))
                {
                    DALFactoryObj.SaveUser(usersObj);
                    return Literals.registerSuccessful;
                }
                else
                {
                    return Literals.userExists;
                }
            }
            return validationStatus;
        }
    }
}
