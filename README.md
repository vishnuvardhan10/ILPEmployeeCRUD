# ILP Employee CRUD System

A simple ASP.NET Core MVC application to manage employee records with full CRUD (Create, Read, Update, Delete) operations. Built as part of the ILP 2025 training.

---

## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 9)
- Razor Views
- Dependency Injection (DI)
- C#
- Entity Layer (no database, in-memory store)
- Visual Studio / VS Code

---


---

## 🧑‍💼 Employee Model

Each employee contains the following properties:

- `Id` (int)
- `Name` (string)
- `Designation` (string)
- `YOE` (int) – Years of Experience
- `Salary` (decimal)

---

## 🚀 Features

- View list of all employees
- View employee details
- Add a new employee
- Edit an existing employee
- Delete an employee
- Razor UI for frontend
- In-memory data (no database used)

---

## ▶️ How to Run

### 🖥️ Visual Studio

1. Open `Microsoft.ILP2025.EmployeeCRUD.sln`
2. Set `Microsoft.ILP2025.EmployeeCRUD.Web` as the startup project
3. Press `F5` to build and run

### 📦 .NET CLI

```bash
cd Microsoft.ILP2025.EmployeeCRUD.Web
dotnet run
Then open your browser to: https://localhost:5139/Employee
---

