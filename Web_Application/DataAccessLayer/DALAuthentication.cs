using BusinessModel;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// used to compare database data and user input also to perform operations on database.
    /// </summary>
    internal class DALAuthentication : IDAL
    {
        /// <summary>
        /// This method verifies that the username in the database.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string CheckValidUser(UserInfo userObj)
        {
            string _Username = userObj.Username;
            string conString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SqlQueries.validateUsernameQuery, con);
                    cmd.Parameters.AddWithValue("username", _Username);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        con.Close();
                        return StringLiterals.userExist;
                    }
                    con.Close();
                    return StringLiterals.loginUnSuccess;
                }
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch (InvalidOperationException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// This method fetches the user's password from the database.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string GetUserPassword(UserInfo userObj)
        {
            string _Username = userObj.Username;
            string conString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(SqlQueries.SelectPasswordQuery, con);
                cmd.Parameters.AddWithValue("username", _Username);
                var EncryptedPassword = cmd.ExecuteScalar();

                if (EncryptedPassword != null)
                {
                    con.Close();
                    return EncryptedPassword.ToString();
                }
                return string.Empty;
            }

        }



        /// <summary>
        /// User password is updated to database.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string UpdatePassword(UserInfo userObj)
        {

            string _Username = userObj.Username;
            string _Email = userObj.Email;
            string password = userObj.EncryptedPassword;

            string conString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SqlQueries.validateUsernameEmailquery, con);
                    cmd.Parameters.AddWithValue("username", _Username);
                    cmd.Parameters.AddWithValue("email", _Email);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        SqlCommand cmd1 = new SqlCommand(SqlQueries.updateQuery, con);
                        cmd1.Parameters.AddWithValue("username", _Username);
                        cmd1.Parameters.AddWithValue("password", password);
                        if (cmd1.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            return StringLiterals.successfullyUpdated;
                        }
                    }
                    con.Close();
                    return StringLiterals.emailUserNameMisMatch;
                }
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch (InvalidOperationException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// User information is saved to a database.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string SaveUser(UserInfo userObj)
        {
            string conString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            string password = userObj.EncryptedPassword;
            string _Username = userObj.Username;
            string _Email = userObj.Email;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SqlQueries.validateUsernameQuery, con);
                    cmd.Parameters.AddWithValue("username", _Username);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.Read())
                    {
                        dr.Close();
                        SqlCommand cmd1 = new SqlCommand(SqlQueries.insertQuery, con);
                        cmd1.Parameters.AddWithValue("username", _Username);
                        cmd1.Parameters.AddWithValue("password", password);
                        cmd1.Parameters.AddWithValue("email", _Email);
                        if (cmd1.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            return StringLiterals.successfullRegistration;
                        }
                    }
                    con.Close();
                    return StringLiterals.userExist;
                }
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
            catch (InvalidOperationException ex)
            {
                return ex.ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
