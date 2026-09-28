Pediatrics Department Management Platform

A full-stack web platform developed for a Pediatrics Department to provide information about doctors and services while allowing patients/users to conveniently view doctor availability and book appointments through an online calendar.

📌 Project Overview

The platform consists of two main parts:

- Patient/User Interface: Allows users to explore available pediatric doctors, view their information and availability, and schedule appointments.
- Doctor/Staff Interface: Provides authenticated doctors with access to their appointments and relevant scheduling information through a secure login system.

The system aims to simplify appointment management and provide users with an easy way to find available pediatricians and book appointments online.

✨ Features

👤 User/Patient Side

- Browse the Pediatrics Department.
- View available doctors.
- View doctor profiles and information.
- Check doctor availability.
- View available appointment dates and times.
- Book appointments through an interactive calendar.
- Manage/view scheduled appointments.
- User-friendly and responsive interface.

👨‍⚕️ Doctor Side

- Secure doctor login.
- Authenticated access to the doctor dashboard.
- View scheduled appointments.
- Check appointment dates and times.
- Manage availability.
- Access relevant patient appointment information.

📅 Appointment Management

- Calendar-based appointment scheduling.
- Display available time slots.
- Prevent conflicting appointments.
- Connect appointments with specific doctors.
- Store appointment information in the database.

🏗️ System Architecture

The project follows a full-stack web application architecture:

                    ┌─────────────────────┐
                    │       Users         │
                    │   / Patients        │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │   Web Application   │
                    │    Frontend/UI       │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │    ASP.NET Core     │
                    │      Backend        │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │      Database       │
                    │  Doctors / Users    │
                    │   Appointments       │
                    └─────────────────────┘

🛠️ Technologies Used

Backend

- ASP.NET Core
- C#
- Entity Framework Core
- RESTful APIs / MVC (depending on implementation)

Frontend

- HTML5
- CSS3
- JavaScript
- Bootstrap (if used)
- Calendar/appointment UI

Database

- SQL Server
- Entity Framework Core for database access

Authentication

- ASP.NET Core Identity / Authentication
- Role-based access for doctors and users

📂 Project Structure

PediatricsPlatform/
│
├── Controllers/
│   ├── AccountController.cs
│   ├── DoctorController.cs
│   └── AppointmentController.cs
│
├── Models/
│   ├── Doctor.cs
│   ├── Patient.cs
│   ├── Appointment.cs
│   └── ...
│
├── Views/
│   ├── Home/
│   ├── Doctor/
│   ├── Appointment/
│   └── Account/
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── Migrations/
│
├── Program.cs
├── appsettings.json
└── README.md

«The exact structure may vary depending on the implementation.»

🚀 Getting Started

Prerequisites

Before running the project, make sure you have:

- ".NET SDK" (https://dotnet.microsoft.com/download)
- SQL Server or SQL Server Express
- Visual Studio or Visual Studio Code
- Git

1. Clone the Repository

git clone <repository-url>
cd <project-folder>

2. Configure the Database

Update the connection string in "appsettings.json":

"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=PediatricsDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

3. Apply Database Migrations

dotnet ef database update

4. Run the Application

dotnet run

Or run the project directly through Visual Studio.

The application will be available at the local URL shown in the terminal, for example:

https://localhost:xxxx

🔐 User Roles

The platform provides separate functionality depending on the user's role.

Role| Access
User/Patient| Browse doctors, check availability, book appointments
Doctor| Login, view appointments, manage availability
Administrator (if implemented)| Manage doctors, users, and appointments

📅 Appointment Workflow

User
  │
  ▼
Browse Doctors
  │
  ▼
Select Doctor
  │
  ▼
View Availability
  │
  ▼
Select Date & Time
  │
  ▼
Book Appointment
  │
  ▼
Appointment Saved

🔒 Security

The application uses authentication and authorization to separate doctor functionality from the public/user-facing features.

Doctor-specific pages and functionality are protected so that only authenticated and authorized doctors can access them.

🎯 Project Goals

The main objectives of the project are to:

- Digitize pediatric appointment scheduling.
- Make doctor availability easily accessible to users.
- Reduce manual appointment management.
- Provide doctors with a centralized appointment interface.
- Improve the overall patient experience.
- Provide a scalable foundation for further healthcare-related features.

🔮 Future Improvements

Potential future improvements include:

- Email/SMS appointment reminders.
- Online appointment cancellation and rescheduling.
- Patient medical history.
- Doctor availability management with recurring schedules.
- Admin dashboard.
- Online consultations.
- Appointment notifications.
- Reporting and analytics.
- Multi-department support.

👩‍💻 Masah Jsri

Developed as a full-stack web application project using ASP.NET Core and C#.

📄 License

This project is intended for educational/project purposes.
# PedDepartment
