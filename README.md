# Magic Villa

# Overview
  - Magic Villa is a RESTful Web API built with ASP.NET Core, designed to provide robust functionalities for managing villa properties.

  - The API supports versioning and secure access via JWT Bearer authentication.

  - The API is consumed by an MVC project within the same solution, providing a seamless user experience for managing villa properties.

# Features
  - API Versioning:

      - Implemented multiple API versions to support backward compatibility and smooth transitions between different versions.
       
- JWT Bearer Authentication:

     - Secured the API with JWT Bearer tokens, ensuring that only authenticated users can access certain endpoints.
       
- Villa Management:

     - CRUD operations for managing villa properties, including adding, updating, deleting, and viewing villa details.

- MVC Integration:

    - The API is consumed by an MVC project, providing a user-friendly interface for interacting with the villa management system.
 
# Technologies Used
  - Backend:
      - ASP.NET Core
        
  - API:
      - RESTful services with versioning
        
  - Authentication:
      - JWT Bearer tokens
        
  - Frontend:
      - ASP.NET Core MVC
  - Database:
      - SQL Server
  - Version Control:
      - GitHub

# Installation
  - Clone the repository:
      -     git clone https://github.com/mans0147/magic-villa.git
  - Navigate to the project directory:
      -     cd magic-villa
   
  - Update the database connection string in `appsettings.json`.

  - Apply migrations to create the database:
      -     dotnet ef database update

  - Run the application:
      -     dotnet run 

# Usage

  - Endpoints:
    - List of key API endpoints (`/api/v1/villas`, `/api/v2/villas`) 

# Contact
 - For more information, feel free to reach out to me at `mohamed00147mansour@gmail.com`.









