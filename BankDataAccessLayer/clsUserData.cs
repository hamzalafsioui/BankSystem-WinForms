using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsUserData
    {
        public static bool getUserInfoByUserName(string  UserName,ref string FirstName,ref string LastName,ref string Phone,
            ref string Email,ref string Password,ref int Permissions) {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            

            return IsFound;
        
        }

        public static bool FindByUserNameAndPassword(ref int ID,string UserName, ref string FirstName, ref string LastName, ref string Phone,
            ref string Email,string Password, ref int Permissions)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    UserName = (string)reader["UserName"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }


            return IsFound;

        }


        public static int AddNewUser(string UserName,string FirstName,string LastName,string Phone,string Email ,
            string Password,int Permissions)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Users(UserName,FirstName,LastName,Phone,Email,Password,Permissions)" +
                " VALUES (@UserName,@FirstName,@LastName,@Phone,@Email,@Password,@Permissions);" +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int IDAffected ))
                {
                    UserID = IDAffected;
                }
            }catch (Exception ex) { 
            
            }
            finally { connection.Close(); }
            return UserID;

        }

        public static bool UpdateUserInfo(string UserName,  string FirstName,  string LastName,  string Phone,
             string Email, string Password,int Permissions)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Update Users SET UserName = @UserName,FirstName = @FirstName,LastName = @LastName,Phone = @Phone," +
                "Email = @Email,Password = @Password,Permissions = @Permissions Where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }catch (Exception ex) { }
            finally { connection.Close(); }


            return (RowsAffected>0);
        }


        public static bool DeleteUserByUserName(string UserName)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "delete from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex) { }
            finally { connection.Close(); }


            return (RowsAffected > 0);
        }


        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }catch(Exception ex) { }
            finally { connection.Close(); } 


            return dataTable;
        }


        public static bool IsUserExists(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select Found = 1 from Users where UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = (reader.HasRows);
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool Login(string UserName)
        {
            if(IsUserExists(UserName))
            {
                int RowsAffected = 0;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
                string query = "INSERT INTO UserLogin(UserName,LoginDate) VALUES (@UserName,@dt)";
                SqlCommand command = new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@dt",DateTime.Now );
                try
                {
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();

                }catch (Exception ex) { }
                finally { connection.Close(); }
                return (RowsAffected > 0);
                
            }
            else
            {
                return false;
            }
        }


        public static DataTable GetAllRegisterLogin()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from UserLogin";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return dataTable;
        }

    }

}

