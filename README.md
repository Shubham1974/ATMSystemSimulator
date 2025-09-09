# ATM System Simulator

**ATM System Simulator** is a desktop banking application built with C# and Windows Forms. It simulates basic ATM / bank account operations (create account, deposit, withdraw, transfer, mini statement, balance enquiry) and uses a local SQL Server database for data storage.

---

## Table of Contents

* [Features](#features)
* [Tech Stack](#tech-stack)
* [Prerequisites](#prerequisites)
* [Project Structure](#project-structure)
* [How to Run](#how-to-run)
* [Usage](#usage)
* [Video](#Video)
* [Screenshots](#screenshots)
* [Contributing](#contributing)
* [License](#license)
* [Author](#author)
* [Screenshots](#author)
  
---

## Features

* Create new bank accounts
* Deposit money
* Withdraw money
* Transfer between accounts (if implemented)
* Mini statement / transaction history
* Balance enquiry
* Simple validation and user prompts

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

## How to Run

1. Open `ATMSystemSimulator.sln` in Visual Studio.
2. Build the solution (Build -> Build Solution).
3. Ensure the database `.mdf` file is in the expected path or update the connection string in your forms (look for `SqlConnection` instances).
4. Run the project (Start Debugging / Ctrl+F5).

## Usage

* Create an account from the "New Account" form by filling required fields and submitting.
* Use the "Deposit" and "Withdraw" forms to update account balances.
* View account mini statement / transaction history from the "Mini Statement" form.

## Contributing

1. Fork the repository
2. Create a branch: `git checkout -b feature/YourFeature`
3. Commit your changes: `git commit -m "Add some feature"`
4. Push to the branch: `git push origin feature/YourFeature`
5. Open a Pull Request


## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

## Author

Shubham Bhagwan Mukhekar

Contact: mshubham2503@gmail.com

## Video
[Watch Demo Video](https://drive.google.com/file/d/1uT0UD4Lki7AvdWouwRLVOZilRlEUSFnb/view?usp=sharing)

## Screenshots

### Home Page
![Home Page](https://github.com/user-attachments/assets/ee8cd478-f911-4477-8973-5e988cb9e839)

### Login Page
![Login Page](https://github.com/user-attachments/assets/665404d4-7ff8-4a66-8b0d-7e755064bfc8)

### Account Details
![Account Details](https://github.com/user-attachments/assets/905401b1-20cd-4128-a601-89c8c6990375)

### Transaction Menu
![Transaction Menu](https://github.com/user-attachments/assets/36c0a892-3a08-4883-af19-ec6470883fae)

### Deposit Page
![Deposit Page](https://github.com/user-attachments/assets/846aa4ed-04ae-4947-9e73-0ad3fb8ad4d1)

### Balance Page
![Balance Page](https://github.com/user-attachments/assets/28cd6ea2-e24c-4b43-8616-2caf40cb7757)

### Withdraw Page
![Withdraw Page](https://github.com/user-attachments/assets/5b5ff29f-e28b-469d-a754-9a4ddf80a6be)

### FreeCash Page
![FreeCash Page](https://github.com/user-attachments/assets/53b3c1b5-5793-4917-927f-4fa54d054e43)

### MiniStatement Page
![MiniStatement Page](https://github.com/user-attachments/assets/62bda9fd-5adc-481b-858a-5024a073d476)

### MiniStatement Page (Alt)
![MiniStatement Page 2](https://github.com/user-attachments/assets/ed0bf57c-a4fd-4f94-ab96-6f57475d592b)

