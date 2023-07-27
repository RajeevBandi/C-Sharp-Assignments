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
        /// This method verifies that the username and password match those in the database.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        public string CheckValidLoginDetails(UserInfo userObj)
        {
            string _Username = userObj.Username;
            string password = userObj.EncryptedPassword;

            string conString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            try
            {

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SqlQueries.validateUsernamePasswordQuery, con);
                    cmd.Parameters.AddWithValue("username", _Username);
                    cmd.Parameters.AddWithValue("password", password);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        con.Close();
                        return StringLiterals.loginSuccess;
                    }
                    con.Close();
                    return StringLiterals.loginUnSuccess;
                }
            }
            catch (SqlException)
            {
                return StringLiterals.sqlException;
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
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
            catch (SqlException)
            {
                return StringLiterals.sqlException;
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
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
            catch (SqlException)
            {
                return StringLiterals.sqlException;
            }
            catch (InvalidOperationException)
            {
                return StringLiterals.inValidOperationException;
            }
            catch (Exception)
            {
                return StringLiterals.unExpectedException;
            }
        }
    }
}
