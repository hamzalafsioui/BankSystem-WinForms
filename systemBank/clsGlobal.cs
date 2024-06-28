using BankBusinessLayer;
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace systemBank
{
	static public class clsGlobal
	{
		static public clsUser GlobalUser { get; set; }


		static public string ComputeHash(string input)
		{
			//SHA is Secured Hash Algorithm.
			// Create an instance of the SHA-256 algorithm
			using (SHA256 sha256 = SHA256.Create())
			{
				// Compute the hash value from the UTF-8 encoded input string
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


				// Convert the byte array to a lowercase hexadecimal string
				return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
			}

		}

		// Save Data By Using Registry

		public static bool RememberUsernameAndPasswordInRegistry(string Username, string Password)
		{
			string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\BANK";

			string UsernameName = "Username";
			string UsernameData = Username;

			string PasswordName = "Password";
			string PasswordData = Password;

			try
			{
				// Write the value to the Registry
				Registry.SetValue(keyPath, UsernameName, UsernameData, RegistryValueKind.String);
				Registry.SetValue(keyPath, PasswordName, PasswordData, RegistryValueKind.String);

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An Error occurred: {ex.Message}");
				return false;
			}


		}

		public static bool GetStoredCredentialFromRegistry(ref string Username, ref string Password)
		{
			string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\BANK";

			string UsernameName = "Username";
			string PasswordName = "Password";

			try
			{
				// Read the value from the Registry
				Username = Registry.GetValue(keyPath, UsernameName, null) as string;
				Password = Registry.GetValue(keyPath, PasswordName, null) as string;

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An Error occurred: {ex.Message}");
				return false;
			}
		}



		public static bool RemoveStoredCredentialFromRegistry()
		{
			string keyPath = @"SOFTWARE\BANK";

			string UsernameName = "Username";
			string PasswordName = "Password";

			try
			{
				// Open the registry key in read/write mode with explicit registry view
				using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
					{
						if (key != null)
						{
							// Delete the specified value
							key.DeleteValue(UsernameName);
							key.DeleteValue(PasswordName);

							return true;
						}
						else
						{
							return false;
						}
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("UnauthorizedAccessException: Run the program with" +
					" administrative privileges.", "Access Denied",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}