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
                Encryption EncryptionObj = new Encryption();
                userObj.EncryptedPassword = EncryptionObj.StringEncryption(userObj.Password);

                DALFactory DALFactoryObj = new DALFactory();
                IDAL DALObj = DALFactoryObj.DALObjCreation();

                return DALObj.CheckValidLoginDetails(userObj);
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
                Encryption EncryptObj = new Encryption();
                userObj.EncryptedPassword = EncryptObj.StringEncryption(userObj.NewPassword);

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
                Encryption EncryptionObj = new Encryption();
                userObj.EncryptedPassword = EncryptionObj.StringEncryption(userObj.Password);

                DALFactory DALFactoryObj = new DALFactory();
                IDAL DALObj = DALFactoryObj.DALObjCreation();

                return DALObj.SaveUser(userObj);
            }
            return StringLiterals.fieldsEmpty;
        }
    }
}
