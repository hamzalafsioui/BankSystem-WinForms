# Bank System Project
## Overview
This project is a banking system implemented using a Windows Forms application and a SQL Server database. The system allows users to manage bank accounts, perform transactions.
* -- This project is not created at the time of published it --

## Features
* *User management* (registration, login)
* *Account management* (create, update, delete)
* *Transactions* (deposits, withdrawals, transfers)
* *Currency management*

## Technologies Used
* C# with Windows Forms for the application
* SQL Server for the database
* ADO.NET for database access

## Database Schema
### Tables
* all columns are NOT NULL only Phone accepts NULL.
#### Users
* *UserID* (INT, Primary Key)
* *FirstName* (NVARCHAR(MAX))
* *LastName* (NVARCHAR(MAX))
* *Gender* (CHAR(1))
* *DateOfBirth* (DATETIME)
* *Phone* (NVARCHAR(MAX))
* *Email* (NVARCHAR(MAX))
* *Password* (NVARCHAR(MAX))
* *Permissions* (INT)
  
#### Clients

* *ClientID* (INT, Primary Key)
* *AccountNumber* (NVARCHAR(MAX))
* *FirstName* (NVARCHAR(MAX))
* *LastName* (NVARCHAR(MAX))
* *Gender* (CHAR(1))
* *DateOfBirth* (DATETIME)
* *Phone* (NVARCHAR(MAX))
* *Email* (NVARCHAR(MAX))
* *PinCode* (NVARCHAR(MAX))
* *AccountBalance* (DECIMAL(18, 2))
  
#### UserLogin

* *LoginID* (INT, Primary Key)
* *UserID* (INT, Foreign Key references Users(UserID))
* *LoginDate* (DATETIME)
  
#### Deposit
* *DepositID* (INT, Primary Key)
* *AccountNumber* (NVARCHAR(MAX), Foreign Key references Clients(AccountNumber))
* *Amount* (DECIMAL(18, 2))
* *DepositDate* (DATETIME)

#### Withdraw

* *WithdrawID* (INT, Primary Key)
* *AccountNumber* (NVARCHAR(MAX), Foreign Key references Clients(AccountNumber))
* *Amount* (DECIMAL(18, 2))
* *WithdrawDate* (DATETIME)

#### Transfers

* *TransferID* (INT, Primary Key)
* *FromAccountNumber* (NVARCHAR(MAX), Foreign Key references Clients(AccountNumber))
* *ToAccountNumber* (NVARCHAR(MAX), Foreign Key references Clients(AccountNumber))
* *Amount* (DECIMAL(18, 2))
* *TransferDate* (DATETIME)

#### Currencies

* *ID* (INT, Primary Key)
* *Country* (NVARCHAR(MAX))
* *Code* (NVARCHAR(MAX))
* *Name* (NVARCHAR(MAX))
* *Rate* (DECIMAL(18, 2))


