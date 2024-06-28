using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
	public class clsUserData
	{
		public static bool getUserInfoByUserName(string UserName, ref string FirstName, ref string LastName, ref string Phone,
			ref string Email, ref char Gender, ref DateTime DateOfBirth, ref string Password, ref int Permissions)
		{

			bool IsFound = false;
			using (SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString))
			{
				string query = "select * from BK.Users where UserName = @UserName";

				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@UserName", UserName);

					try
					{
						connection.Open();
						using (SqlDataReader reader = command.ExecuteReader())
						{

							if (reader.Read())
							{
								IsFound = true;
								FirstName = (string)reader["FirstName"];
								LastName = (string)reader["LastName"];
								if (reader["Phone"] != DBNull.Value)
								{
									Phone = (string)reader["Phone"];
								}
								Email = (string)reader["Email"];
								Gender = Convert.ToChar(reader["Gender"].ToString().Trim());
								DateOfBirth = (DateTime)reader["DateOfBirth"];
								Password = (string)reader["Password"];
								Permissions = (int)reader["Permissions"];
							}
							else
							{
								IsFound = false;
							}

						}


					}
					catch (Exception ex)
					{
						IsFound = false;
					}
				}


			}


			return IsFound;

		}

		public static bool FindByUserNameAndPassword(ref int ID, string UserName, ref string FirstName, ref string LastName, ref char Gender, ref string Phone,
			ref string Email, ref DateTime DateOfBirth, string Password, ref int Permissions)
		{

			bool IsFound = false;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "select * from BK.Users where UserName = @UserName and Password = @Password";

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
					ID = (int)reader["UserID"];
					UserName = (string)reader["UserName"];
					FirstName = (string)reader["FirstName"];
					LastName = (string)reader["LastName"];
					Email = (string)reader["Email"];

					if (reader["Phone"] != DBNull.Value)
						Email = (string)reader["Phone"];

					Gender = Convert.ToChar(reader["Gender"].ToString().Trim());
					DateOfBirth = (DateTime)reader["DateOfBirth"];

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


		public static int AddNewUser(string UserName, string FirstName, string LastName, string Phone, string Email, char Gender, DateTime DateOfBirth,
			string Password, int Permissions)
		{
			int UserID = -1;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "INSERT INTO BK.Users(UserName,FirstName,LastName,Phone,Email,Gender,DateOfBirth,Password,Permissions)" +
				" VALUES (@UserName,@FirstName,@LastName,@Phone,@Email,@Gender,@DateOfBirth,@Password,@Permissions);" +
				"SELECT SCOPE_IDENTITY();";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserName", UserName);
			command.Parameters.AddWithValue("@FirstName", FirstName);
			command.Parameters.AddWithValue("@LastName", LastName);
			if (Phone == "")
			{
				command.Parameters.AddWithValue("@Phone", DBNull.Value);
			}
			else
			{
				command.Parameters.AddWithValue("@Phone", Phone);

			}

			command.Parameters.AddWithValue("@Email", Email);
			command.Parameters.AddWithValue("@Gender", Gender);
			command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			command.Parameters.AddWithValue("@Password", Password);
			command.Parameters.AddWithValue("@Permissions", Permissions);

			try
			{
				connection.Open();
				object result = command.ExecuteScalar();
				if (result != null && int.TryParse(result.ToString(), out int IDAffected))
				{
					UserID = IDAffected;
				}
			}
			catch (Exception ex)
			{

			}
			finally { connection.Close(); }
			return UserID;

		}

		public static bool UpdateUserInfo(string UserName, string FirstName, string LastName, string Phone, char Gender, DateTime DateOfBirth,
			 string Email, string Password, int Permissions)
		{
			int RowsAffected = 0;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "Update BK.Users SET UserName = @UserName,FirstName = @FirstName,LastName = @LastName,Phone = @Phone," +
				"Email = @Email,Gender = @Gender,DateOfBirth = @DateOfBirth,Password = @Password,Permissions = @Permissions Where UserName = @UserName";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@UserName", UserName);
			command.Parameters.AddWithValue("@FirstName", FirstName);
			command.Parameters.AddWithValue("@LastName", LastName);
			if (Phone != null && Phone != "")
				command.Parameters.AddWithValue("@Phone", Phone);
			else
				command.Parameters.AddWithValue("@Phone", DBNull.Value);

			command.Parameters.AddWithValue("@Email", Email);
			command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
			command.Parameters.AddWithValue("@Gender", Gender);
			command.Parameters.AddWithValue("@Password", Password);
			command.Parameters.AddWithValue("@Permissions", Permissions);

			try
			{
				connection.Open();
				RowsAffected = command.ExecuteNonQuery();
			}
			catch (Exception ex) { }
			finally { connection.Close(); }


			return (RowsAffected > 0);
		}


		public static bool DeleteUserByUserName(string UserName)
		{
			int RowsAffected = 0;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "delete from BK.Users where UserName = @UserName";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserName", UserName);

			try
			{
				connection.Open();
				RowsAffected = command.ExecuteNonQuery();
			}
			catch (Exception ex) { }
			finally { connection.Close(); }


			return (RowsAffected > 0);
		}


		public static DataTable GetAllUsers()
		{
			DataTable dataTable = new DataTable();

			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "select * from BK.UserDetails_View";

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


		public static bool IsUserExists(string UserName)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "select Found = 1 from BK.Users where UserName = @UserName";
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
		public static bool IsUserExistsByID(int UserID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
			string query = "select Found = 1 from BK.Users where UserID = @UserID";
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@UserID", UserID);

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

		public static bool Login(int UserID)
		{
			if (IsUserExistsByID(UserID))
			{
				int RowsAffected = 0;
				SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
				string query = "INSERT INTO BK.UserLogin(UserID,LoginDate) VALUES (@UserID,@dt)";
				SqlCommand command = new SqlCommand(@query, connection);
				command.Parameters.AddWithValue("@UserID", UserID);
				command.Parameters.AddWithValue("@dt", DateTime.Now);
				try
				{
					connection.Open();
					RowsAffected = command.ExecuteNonQuery();

				}
				catch (Exception ex) { }
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
			string query = "SELECT * FROM BK.UserLogin ORDER BY LoginDate DESC";

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

