# Employee Management System

## 📌 Overview
The **Employee Management System** is a **full-stack web application** designed to efficiently manage employee records. Built with **Angular 18** for the frontend and **.NET Core 9.0** for the backend, it offers a **secure, scalable, and responsive** solution for employee data management.

This project follows **best development practices**, including modular design, structured API development, and responsive UI implementation with **Bootstrap**. The backend ensures robust **data integrity and security** using **Entity Framework Core**.

---

## 🚀 Features

✅ **Employee CRUD Operations** – Create, read, update, and delete employee records seamlessly.  
✅ **Responsive UI** – Designed with **Bootstrap** for an intuitive and adaptive user experience.  
✅ **Secure API** – RESTful API with proper authentication and secure data handling.  
✅ **Scalable Architecture** – Built using **.NET Core** and **Entity Framework Core** for efficient data management.  
✅ **Seamless Frontend-Backend Communication** – Fully integrated using **CORS policies** for cross-origin requests.  
✅ **Well-Documented Codebase** – Structured and maintainable code with clear documentation.  

---

## 🛠️ Technologies Used

### Frontend
- **Framework:** Angular 18
- **Languages:** TypeScript, HTML, CSS
- **Styling:** Bootstrap (for responsive design)
- **State Management:** Angular Services

### Backend
- **Framework:** .NET Core 9.0
- **Language:** C#
- **ORM:** Entity Framework Core (for database management)
- **Security:** CORS policies, secure API endpoints

### Tools & DevOps
- **IDE:** Visual Studio Code, Visual Studio
- **Version Control:** Git, GitHub
- **Package Management:** npm, NuGet
- **Deployment:** Local development servers

---

## 🏁 Getting Started

### ✅ Prerequisites
Ensure you have the following installed on your system:
- **Node.js** and **npm** (for Angular)
- **.NET Core SDK** (for backend development)
- **Angular CLI** (for managing Angular projects)
- **Git** (for version control)

### 🔧 Installation & Setup

1️⃣ **Clone the Repository:**
```bash
 git clone https://github.com/a1865818/employee-management-system.git
 cd employee-management-system
```

2️⃣ **Backend Setup:**
```bash
 cd backend
 dotnet restore  # Restore dependencies
 dotnet build    # Build the project
 dotnet run      # Start the backend server
```
The backend server will run on **https://localhost:7206/index.html**.

3️⃣ **Frontend Setup:**
```bash
 cd frontend
 npm install   # Install dependencies
 ng serve      # Run the frontend
```
The frontend application will run on **http://localhost:4200**.

---

## 🔗 API Endpoints

| Method | Endpoint | Description |
|--------|---------|-------------|
| **GET** | `/api/employees` | Retrieve all employees |
| **GET** | `/api/employees/{id}` | Retrieve an employee by ID |
| **POST** | `/api/employees` | Create a new employee |
| **PUT** | `/api/employees/{id}` | Update an existing employee |
| **DELETE** | `/api/employees/{id}` | Delete an employee |

---

## 🤝 Contributing
We welcome contributions! To contribute:

1. **Fork the repository**
2. **Create a new branch** (`git checkout -b feature/your-feature`)
3. **Commit your changes** (`git commit -m 'Add some feature'`)
4. **Push to the branch** (`git push origin feature/your-feature`)
5. **Open a pull request** 🚀

---

## 📜 License
This project is licensed under the **MIT License**. See the **LICENSE** file for details.

---

## 📧 Contact
For any questions or suggestions, feel free to reach out:
📩 Email: [minhnt10122003@gmail.com](mailto:minhnt10122003@gmail.com)

Let’s build great software together! 🎯

