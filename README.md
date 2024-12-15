Student Management System





Overview

The Student Management System is a desktop application built using C# and the .NET Framework. This application is designed to help teachers and administrators efficiently manage students' grades and attendance records. The application integrates with a MariaDB database to ensure secure and reliable data storage and retrieval.

Features

Student Records Management: Add, update, and delete student information.

Grade Tracking: Store and manage grades for various subjects.

Attendance Monitoring: Track and manage attendance records for students.

User-Friendly Interface: Simplified navigation for teachers and administrators.

Secure Database Integration: Ensures data integrity and security using MariaDB.

Technologies Used







Installation

Prerequisites

Install .NET Framework.

Install MariaDB.

Install a compatible IDE, such as Visual Studio.

Steps

Clone the repository:

git clone https://github.com/yourusername/StudentManagementSystem.git

Open the project in Visual Studio.

Configure the database connection:

Update the connection string in the app's configuration file to match your MariaDB setup.

Build and run the project:

Press F5 or use the build and run option in Visual Studio.

Usage

Login: Use administrator credentials to access the application.

Manage Students: Navigate to the "Students" section to add or update records.

Track Grades: Use the "Grades" section to input and manage student grades.

Monitor Attendance: Access the "Attendance" section to track daily attendance records.

Database Schema

The MariaDB database is structured as follows:

Students: Stores student details such as ID, name, age, and contact information.

Grades: Contains grades for different subjects linked to student IDs.

Attendance: Tracks attendance records with timestamps and student IDs.

Screenshots

Login Screen



Dashboard



Student Management



Contributing

Contributions are welcome! Please follow these steps:

Fork the repository.

Create a new branch:

git checkout -b feature-name

Commit your changes:

git commit -m "Add a new feature"

Push to the branch:

git push origin feature-name

Submit a pull request.

License

This project is licensed under the MIT License. See the LICENSE file for details.

Contact

If you have any questions or suggestions, feel free to contact:

Name: Hamza Derouich

Email: your.email@example.com

GitHub: HamzaDerouich

