using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsClientData
    {
        public static bool getClientInfoByAccountNumber(ref int ID,string AccountNumber,ref string FirstName,ref string LastName,
            ref string Phone,ref string Email,ref string PinCode,ref decimal AccountBalance)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Clients where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    PinCode = (string)reader["PinCode"];
                    AccountBalance = (decimal)reader["AccountBalance"];
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

        public static int AddNewClient(string AccountNumber, string FirstName, string LastName, string Phone, string Email,
            string PinCode, decimal AccountBalance)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Clients(AccountNumber,FirstName,LastName,Phone,Email,PinCode,AccountBalance)" +
                " VALUES (@AccountNumber,@FirstName,@LastName,@Phone,@Email,@PinCode,@AccountBalance);" +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

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

        public static bool UpdateClientInfo(string AccountNumber, string FirstName, string LastName, string Phone,
             string Email, string PinCode, decimal AccountBalance)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Update Clients SET AccountNumber = @AccountNumber,FirstName = @FirstName,LastName = @LastName,Phone = @Phone," +
                "Email = @Email,PinCode = @PinCode,AccountBalance = @AccountBalance where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (RowsAffected > 0);
        }


        public static bool DeleteClientByAccountNumber(string AccountNumber)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "delete from Clients where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (RowsAffected > 0);
        }




        public static DataTable GetAllClients()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Clients";

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

        public static DataTable GetAllTransfers()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select * from Transfers";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }catch (Exception ex) { }
            finally { connection.Close(); }
            return dataTable;
        }
        public static DataTable GetAllDeposits()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select * from Deposit";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static DataTable GetAllWithDraws()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string Query = "select * from WithDraw";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dataTable;
        }



        public static bool IsClientExists(string AccountNumber)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select Found = 1 from Clients where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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



        private static bool CheckAccountBalance(string AccountNumber,decimal Amount)
        {
            decimal balance = 0;
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "SELECT AccountBalance FROM Clients Where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    balance = (decimal)reader["AccountBalance"];
                }
            }catch (Exception ex) { IsFound = false; }
            finally { connection.Close(); }

            return (balance>Amount &&  IsFound);
        }

        public static int Deposit(string AccountNumber,decimal Amount,DateTime dt)
        {
            int DepositID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Update Clients set AccountBalance += @Amount where AccountNumber = @AccountNumber;" +
                
                "INSERT INTO Deposit(AccountNumber,Amount,DepositDate)" +
                "VALUES(@AccountNumber,@Amount,@dt);" +

                "SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@dt", dt);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int IDAffected))
                {
                    DepositID = IDAffected;
                }
            }catch (Exception ex) { }
            finally { connection.Close(); }

            return DepositID ;
        }


        public static int WithDraw(string AccountNumber, decimal Amount, DateTime dt)
        {
            if (CheckAccountBalance(AccountNumber, Amount))
            {
                int DepositID = -1;
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
                string query = "Update Clients set AccountBalance -= @Amount where AccountNumber = @AccountNumber;" +

                    "INSERT INTO WithDraw(AccountNumber,Amount,WithDrawDate)" +
                    "VALUES(@AccountNumber,@Amount,@dt);" +

                    "SELECT SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(@query, connection);
                command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                command.Parameters.AddWithValue("@Amount", Amount);
                command.Parameters.AddWithValue("@dt", dt);

                try
                {
                    connection.Open();
                    object Result = command.ExecuteScalar();
                    if (Result != null && int.TryParse(Result.ToString(), out int IDAffected))
                    {
                        DepositID = IDAffected;
                    }
                }
                catch (Exception ex) { }
                finally { connection.Close(); }

                return DepositID;
            }
            else
            {
                return -1;
            }

        }


        public static bool Transfer(string AccountNumberFrom, string AccountNumberTo, decimal Amount, DateTime dt)
        {
            if (CheckAccountBalance(AccountNumberFrom, Amount))
            {
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
                SqlTransaction transaction = null;

                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    // Withdraw from the source account
                    string withdrawQuery = "UPDATE Clients SET AccountBalance -= @Amount WHERE AccountNumber = @AccountNumberFrom;" +
                                           "INSERT INTO Withdraw(AccountNumber, Amount, WithdrawDate) VALUES(@AccountNumberFrom, @Amount, @dt);";
                    SqlCommand withdrawCommand = new SqlCommand(withdrawQuery, connection, transaction);
                    withdrawCommand.Parameters.AddWithValue("@AccountNumberFrom", AccountNumberFrom);
                    withdrawCommand.Parameters.AddWithValue("@Amount", Amount);
                    withdrawCommand.Parameters.AddWithValue("@dt", dt);
                    withdrawCommand.ExecuteNonQuery();

                    // Deposit into the destination account
                    string depositQuery = "UPDATE Clients SET AccountBalance += @Amount WHERE AccountNumber = @AccountNumberTo;" +
                                          "INSERT INTO Deposit(AccountNumber, Amount, DepositDate) VALUES(@AccountNumberTo, @Amount, @dt);";
                    SqlCommand depositCommand = new SqlCommand(depositQuery, connection, transaction);
                    depositCommand.Parameters.AddWithValue("@AccountNumberTo", AccountNumberTo);
                    depositCommand.Parameters.AddWithValue("@Amount", Amount);
                    depositCommand.Parameters.AddWithValue("@dt", dt);
                    depositCommand.ExecuteNonQuery();

                    // Transfer
                    string transferQuery = "INSERT INTO Transfers(TransferFrom, TransferTo, Amount, TransferDate)" +
                                           "VALUES(@AccountNumberFrom, @AccountNumberTo, @Amount, @dt)";
                    SqlCommand transferCommand = new SqlCommand(transferQuery, connection, transaction);
                    transferCommand.Parameters.AddWithValue("@AccountNumberFrom", AccountNumberFrom);
                    transferCommand.Parameters.AddWithValue("@AccountNumberTo", AccountNumberTo);
                    transferCommand.Parameters.AddWithValue("@Amount", Amount);
                    transferCommand.Parameters.AddWithValue("@dt", dt);
                    transferCommand.ExecuteNonQuery();

                    // Commit the transaction if everything is successful
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of an exception
                    transaction?.Rollback();
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                return false; // Insufficient balance in the source account
            }
        }

        

    }







    public class clsCurrencyData
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Currencies";
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dataTable;
        }

        public static bool IsCurrencyExistsByCode(string CurrencyCode)
        {
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "select * from Currencies where Code = @CurrencyCode";
            SqlCommand command  = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                return false;
            }catch (Exception ex) { }
            finally { connection.Close(); }
            return false;
        }

        public static bool UpdateCurrency(string CurrencyCode,decimal NewRate)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
            string query = "Update Currencies SET Rate = @NewRate where Code = @CurrencyCode";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("NewRate", NewRate);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
           

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return (RowsAffected > 0);
        }

        public static bool getCurrencyInfoByCode(string Code,ref int CurrencyID,ref string Country,ref string Name,ref decimal Rate)
        {
            if (IsCurrencyExistsByCode(Code))
            {

                string query = "select * from Currencies where Code = @Code";
                SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionString);
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Code", Code);
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        Country = (string)Reader["Country"];
                        Name = (string)Reader["Name"];
                        Rate = (decimal)Reader["Rate"];
                        CurrencyID = (int)Reader["ID"];
                        Reader.Close();
                    }
                }catch (Exception ex) { return false; }
                finally { connection.Close(); }
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
