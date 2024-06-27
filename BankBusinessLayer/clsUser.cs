using BankDataAccessLayer;
using System;
using System.Data;

namespace BankBusinessLayer
{
	public class clsUser
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get { return FirstName + " " + LastName; } }
		public string Phone { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public char Gender { get; set; }
		public string Password { get; set; }
		public int Permissions { get; set; }

		enum enMode { NewMode = 0, UpdateMode = 1 }
		enMode Mode = enMode.NewMode;

		private clsUser(int usertID, string userName, string firstName, string lastName, char gender, DateTime dateOfBirth, string phone, string email, string password, int permissions)
		{
			UserID = usertID;
			UserName = userName;
			FirstName = firstName;
			LastName = lastName;
			Phone = phone;
			Email = email;
			Gender = Gender;
			DateOfBirth = dateOfBirth;
			Password = password;
			Permissions = permissions;
			Mode = enMode.UpdateMode;
		}

		public clsUser()
		{
			UserID = -1;
			UserName = "";
			FirstName = "";
			LastName = "";
			Phone = "";
			Email = "";
			Gender = 'M';
			DateOfBirth = DateTime.Now;
			Password = "";
			Permissions = 0;
			Mode = enMode.NewMode;
		}

		public static clsUser FindByUserName(string UserName)
		{
			string FirstName = "", LastName = "", Phone = "", Email = "", Password = "";
			int UserID = -1, Permission = 0;
			char Gender = 'M';
			DateTime DateOfBirth = DateTime.Now;
			if (clsUserData.getUserInfoByUserName(UserName, ref FirstName, ref LastName, ref Phone, ref Email, ref Gender, ref DateOfBirth, ref Password, ref Permission))
			{
				return new clsUser(UserID, UserName, FirstName, LastName, Gender, DateOfBirth, Phone, Email, Password, Permission);
			}
			else
			{
				return null;
			}
		}

		public static clsUser FindByUserNameAndPassword(string UserName, string Password)
		{
			string FirstName = "", LastName = "", Phone = "", Email = "";
			int UserID = -1, Permission = 0;
			char Gender = 'M';
			DateTime DateOfBirth = DateTime.Now;

			if (clsUserData.FindByUserNameAndPassword(ref UserID, UserName, ref FirstName, ref LastName, ref Gender, ref Phone, ref Email, ref DateOfBirth, Password, ref Permission))
			{
				return new clsUser(UserID, UserName, FirstName, LastName, Gender, DateOfBirth, Phone, Email, Password, Permission);
			}
			else
			{
				return null;
			}
		}

		private bool _AddNewUser()
		{
			this.UserID = clsUserData.AddNewUser(this.UserName, this.FirstName, this.LastName, this.Phone, this.Email, this.Gender, this.DateOfBirth, this.Password
				, this.Permissions);

			return (this.UserID != -1);
		}

		private bool _UpdateUser()
		{
			return clsUserData.UpdateUserInfo(this.UserName, this.FirstName, this.LastName, this.Phone, this.Gender, this.DateOfBirth, this.Email, this.Password, this.Permissions);
		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.NewMode:
					if (_AddNewUser())
					{
						Mode = enMode.UpdateMode;
						return true;
					}
					else
					{
						return false;
					}
				case enMode.UpdateMode:
					return _UpdateUser();
			}
			return false;

		}

		public static bool DeleteUserByUserName(string userName)
		{
			return clsUserData.DeleteUserByUserName(userName);
		}

		public static DataTable GetAllUsers()
		{
			return clsUserData.GetAllUsers();
		}

		public static bool IsUserExists(string UserName)
		{
			return clsUserData.IsUserExists(UserName);
		}

		public bool Login()
		{
			return clsUserData.Login(this.UserID);
		}

		public static DataTable GetAllRegisterLogin()
		{
			return clsUserData.GetAllRegisterLogin();
		}
	}
}
