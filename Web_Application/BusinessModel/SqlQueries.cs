
namespace BusinessModel
{
    public static class SqlQueries
    {
        public static string validateUsernamePasswordQuery = "SELECT * FROM LoginTable WHERE Username =@username and Password =@password ";
        public static string validateUsernameQuery = "SELECT Username FROM LoginTable WHERE Username =@username";
        public static string insertQuery = "INSERT INTO LoginTable VALUES (@username, @password, @email)";
        public static string updateQuery = "UPDATE LoginTable SET Password =@password WHERE Username=@username ";
        public static string validateUsernameEmailquery = "SELECT * FROM LoginTable WHERE Username =@username and Email=@email ";

    }
}
