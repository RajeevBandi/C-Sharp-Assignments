using BusinessModel;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    /// <summary>
    /// check the user input
    /// </summary>
    internal class BALValidation
    {
        /// <summary>
        /// checks whether the information entered by the user is accurate.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public string ValidRegisteration(User usersObj)
        {
            // Verification of Username
            if (!Regex.IsMatch(usersObj.Username, "^[A-Za-z0-9]{8,15}$"))
            {
                return Literals.invalidUsername;
            }

            // Verification of Password
            if (!Regex.IsMatch(usersObj.Password, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}"))
            {
                return Literals.invalidPassword;
            }

            // Verification of name
            if (!Regex.IsMatch(usersObj.Name, "^[A-Za-z]{6,8}$"))
            {
                return Literals.invalidName;
            }

            // Verification of phone number
            if (!Regex.IsMatch(usersObj.PhoneNo, "^[0-9]{10}$"))
            {
                return Literals.invalidPhoneNo;
            }
            return Literals.registerSuccessful;
        }
    }
}