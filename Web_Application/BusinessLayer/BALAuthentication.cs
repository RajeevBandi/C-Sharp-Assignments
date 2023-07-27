using BusinessModel;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    internal class BALAuthentication : IBAL
    {
        /// <summary>
        /// Checks wether the user login details are valid or not
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string Login(BusinessModel.UserInfo userObj)
        {
            if (userObj.Username != string.Empty && userObj.Password != string.Empty)
            {


                DALFactory DALFactoryObj = new DALFactory();
                IDAL DALObj = DALFactoryObj.DALObjCreation();

                string EncryptedPassword = string.Empty;
                string DecryptedPassword = string.Empty;
                string result = DALObj.CheckValidUser(userObj);

                if (result == StringLiterals.userExist)
                {
                    EncryptedPassword = DALObj.GetUserPassword(userObj);

                    EncryptDecrypt EncryptionObj = new EncryptDecrypt();
                    DecryptedPassword = EncryptionObj.StringEncryptDecrypt(EncryptedPassword);

                    if (DecryptedPassword == userObj.Password)
                    {
                        return StringLiterals.loginSuccess;
                    }
                    return StringLiterals.loginUnSuccess;
                }
                return result;
            }
            return StringLiterals.fieldsEmpty;
        }

        /// <summary>
        /// Checks wether the user forgot password details are valid or not
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string ForgotPassword(BusinessModel.UserInfo userObj)
        {
            if (userObj.Username != string.Empty && userObj.NewPassword != string.Empty && userObj.Email != string.Empty)
            {
                EncryptDecrypt EncryptObj = new EncryptDecrypt();
                userObj.EncryptedPassword = EncryptObj.StringEncryptDecrypt(userObj.NewPassword);

                DALFactory DALFactoryObj = new DALFactory();
                IDAL DALObj = DALFactoryObj.DALObjCreation();

                return DALObj.UpdatePassword(userObj);
            }
            return StringLiterals.fieldsEmpty;
        }

        /// <summary>
        /// Checks wether the user registration details valid or not
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string Registration(BusinessModel.UserInfo userObj)
        {
            if (userObj.Username != string.Empty && userObj.Password != string.Empty && userObj.Email != string.Empty)
            {
                EncryptDecrypt EncryptionObj = new EncryptDecrypt();
                userObj.EncryptedPassword = EncryptionObj.StringEncryptDecrypt(userObj.Password);

                DALFactory DALFactoryObj = new DALFactory();
                IDAL DALObj = DALFactoryObj.DALObjCreation();

                return DALObj.SaveUser(userObj);
            }
            return StringLiterals.fieldsEmpty;
        }
    }
}
