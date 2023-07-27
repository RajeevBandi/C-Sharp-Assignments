
namespace BusinessModel
{
    /// <summary>
    /// Contains the input Properties
    /// </summary>
    public class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
        public string NewPassword { get; set; }

    }
}
