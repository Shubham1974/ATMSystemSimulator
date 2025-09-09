# ATM System Simulator

**ATM System Simulator** is a desktop banking application built with C# and Windows Forms. It simulates basic ATM / bank account operations (create account, deposit, withdraw, transfer, mini statement, balance enquiry) and uses a local SQL Server database for data storage.

---

## Table of Contents

* [Features](#features)
* [Tech Stack](#tech-stack)
* [Prerequisites](#prerequisites)
* [Project Structure](#project-structure)
* [Database Setup](#database-setup)
* [How to Run](#how-to-run)
* [Usage](#usage)
* [Screenshots](#screenshots)
* [Contributing](#contributing)
* [License](#license)
* [Author](#author)

---

## Features

* Create new bank accounts
* Deposit money
* Withdraw money
* Transfer between accounts (if implemented)
* Mini statement / transaction history
* Balance enquiry
* Simple validation and user prompts

> Note: Feature availability depends on which forms you include in the repository (e.g., `MiniStatement`, `Account`, `AddEmployee`-like modules). Adjust features list to match your code.

## Tech Stack

* Language: C#
* UI: Windows Forms (WinForms)
* Database: Microsoft SQL Server LocalDB (AttachDB) / `.mdf` file
* IDE: Visual Studio (recommended)

## Prerequisites

* Windows OS
* Visual Studio 2017/2019/2022 (Community or higher) with .NET desktop development workload
* SQL Server Express LocalDB (installed with Visual Studio by default)

## Project Structure

```
/ATMSystemSimulator
  /ATMSystemSimulator.sln
  /ATMSystemSimulator
    /bin
    /obj
    /Forms
      - Form1.cs
      - MiniStatement.cs
      - AddAccount.cs
      - Login.cs
    /Models
    /Data
      - ATMDatabase.mdf   (or migration .sql)
    /Resources
    README.md
```

Adjust this section to match the exact folder and file names in your repository.

## Database Setup

1. If you have an `.mdf` file included in the `Data` folder, ensure it is set to be copied to the output directory (Properties -> Copy to Output Directory -> "Copy if newer").
2. Sample connection string used in the project:

```csharp
SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ATMDatabase.mdf;Integrated Security=True;Connect Timeout=30");
```

3. If your project uses a `.sql` script instead of an `.mdf` file, run the script in SQL Server Management Studio or Visual Studio's Server Explorer to create the database and tables.

### Common tables (example)

```sql
CREATE TABLE AccountTbl (
  AccNum VARCHAR(20) PRIMARY KEY,
  AccName VARCHAR(100),
  AccFname VARCHAR(100),
  DOB DATE,
  Phone VARCHAR(20),
  Address VARCHAR(255),
  Education VARCHAR(50),
  Pin VARCHAR(10),
  Balance DECIMAL(18,2)
);

CREATE TABLE TransactionTbl (
  Id INT IDENTITY(1,1) PRIMARY KEY,
  AccNum VARCHAR(20),
  Type VARCHAR(20), -- Deposit/Withdraw/Transfer
  Amount DECIMAL(18,2),
  TranDate DATETIME DEFAULT GETDATE(),
  FOREIGN KEY (AccNum) REFERENCES AccountTbl(AccNum)
);
```

Modify table definitions to match your code.

## How to Run

1. Open `ATMSystemSimulator.sln` in Visual Studio.
2. Build the solution (Build -> Build Solution).
3. Ensure the database `.mdf` file is in the expected path or update the connection string in your forms (look for `SqlConnection` instances).
4. Run the project (Start Debugging / Ctrl+F5).

## Usage

* Create an account from the "New Account" form by filling required fields and submitting.
* Use the "Deposit" and "Withdraw" forms to update account balances.
* View account mini statement / transaction history from the "Mini Statement" form.

## Screenshots

Add screenshots to the `/Screenshots` folder and reference them here. Example:

![Login screen](Screenshots/login.png)

## Contributing

1. Fork the repository
2. Create a branch: `git checkout -b feature/YourFeature`
3. Commit your changes: `git commit -m "Add some feature"`
4. Push to the branch: `git push origin feature/YourFeature`
5. Open a Pull Request

Please include clear commit messages and, when relevant, update the database migration script or `.mdf` file.

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

## Author

Shubham Bhagwan Mukhekar

Contact: add your email or GitHub profile link here

---

**Tips before uploading to GitHub**

* Add a `.gitignore` (Visual Studio template) to avoid committing `bin/`, `obj/`, and user-specific files.
* If your `.mdf` contains sensitive test data, remove or sanitize it before publishing.
* Add a short demo GIF or screenshots to make the repo attractive to recruiters.
