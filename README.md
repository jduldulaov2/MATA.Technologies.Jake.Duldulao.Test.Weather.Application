# MATA Technologies - Jake Duldulao Test Application

A **weather forecast** application is a software program or mobile/web app that provides users with up-to-date weather information for a specific location. It typically retrieves weather data from APIs (like OpenWeather, AccuWeather, or WeatherAPI) and displays it in a user-friendly format.

## Software Design Approach

The project was created using the [Clean Architecture](https://www.geeksforgeeks.org/system-design/complete-guide-to-clean-architecture/) software design approach.

**Clean Architecture** is a software design approach introduced by **Robert C. Martin (Uncle Bob)** that helps organize code into layers to keep your business logic independent, testable, and flexible.

**Core idea:**

* Separate your code into distinct layers with clear responsibilities.

* Inner layers contain core business logic and rules.

* Outer layers handle things like UI, database, and external systems.

* Dependencies always point inward, meaning outer layers depend on inner layers, but not the other way around.

**Technical Approach of Clean architecture:**

I used 3 main layers to Design the architecture of the Application.

* **Domain Layer (Core)** - This is the **innermost** layer. It contains **business rules** and entities—the core logic that doesn’t change regardless of technologies or frameworks. This includes **Entities**, **Value Objects**, **Domain Services**, **Business Rules**. Its Completely **independent of frameworks**, UI, or DB.

* **Application Layer (Use Cases)** - Contains **application-specific rules** how the system behaves to achieve business goals. This includes **Use Cases (or Application Services)**, **Interfaces (e.g., IUserRepository)**, **DTOs / Commands / Queries**. It Coordinates the flow between domain and outer layers. Depends on the domain, but not on infrastructure.

* **Infrastructure Layer (Implementation Details)** - This is the **outermost** layer of the application. It contains **actual implementations** frameworks, databases, external services, file systems, etc. This includes **Repositories (EF Core, Dapper, etc.)**,**API clients, Email services**,**Controllers / UI**,**Dependency Injection setup**. It Implements interfaces from the application layer and can be replaced without affecting business logic.

### 🔁 **Dependency Rule**

* **Inner layers** should never depend on outer layers.

* Only the **Infrastructure layer** depends on Application and Domain, not the other way around.

## Architectural Pattern

The architectural pattern used on this project is **CQRS**.

**CQRS** stands for Command Query Responsibility Segregation. It’s a design pattern that separates the operations that **change data** (commands) from the operations that **read data** (queries).


## Backend Technology

The backend used on this project is **C# .NET 8.0.101**. This version has the latest Long-Term Support (LTS) release of Microsoft's cross-platform development platform, launched on November 14, 2023. It enables developers to build modern apps across web, desktop, mobile, cloud, IoT, and AI—using one unified framework.

## Front End Technology (SPA)

The Front-end used is **Angular 16**. v16 brings you the developer preview of Angular CLI's new builders based on esbuild. This new architecture can significantly improve build times in many scenarios. This preview additionally includes integration with Vite powering the CLI's development server.

## Database (RDMS)

I used **MSSQL Database** to this application. It refers to Microsoft SQL Server, which is a **relational database management system (RDBMS)** developed by Microsoft. It is used to store, retrieve, and manage data for various types of applications, especially enterprise-level software.

## ORM - Object-Relational Mapper

I used **Entity Framework Core (EF Core)** on this project. This is a modern, lightweight, and cross-platform Object-Relational Mapper (ORM) for .NET applications. It helps developers work with databases using .NET objects instead of writing raw SQL queries.

The approach I used is Code-First: You define your C# classes and EF Core creates the database schema.

## Other Technologie/Libraries

### ✅ **Node.js** 

Node.js is a free, open-source, cross-platform JavaScript runtime environment that lets developers create servers, web apps, command line tools and scripts. For now, Node.js doesn't necessarily use on the browser part of Angular, but you need it in the background to develop, build, and manage Angular apps. Common usage are the following.

* **Angular CLI Tooling** - Angular CLI (ng commands) is built on Node.js and runs in a Node environment.

* **Package Management** - Uses npm (Node Package Manager) to install libraries and dependencies.

* **Build & Serve** - Runs your dev server (ng serve) and builds the project using Node-powered tools.

* **Development Server** - Angular uses Node to start a local server for live reloading during development.

* **Tooling Integrations** - Tools like Webpack, esbuild, Vite (used experimentally in Angular 16) rely on Node.

* **Script Execution** - Custom build/test/deploy scripts run via Node.js.



### ✅ **AutoMapper** 

AutoMapper is a popular **object-to-object mapping library** for .NET. It helps you automatically map properties from one object type to another, which is especially useful when you want to convert between **data models, DTOs (Data Transfer Objects), view models**, or other classes without writing repetitive manual mapping code.

 * Reduces boilerplate code for copying data between objects.

 * Ensures consistent mapping rules.

 * Makes your code cleaner and easier to maintain.

 * Supports complex mappings, including nested objects, collections, and custom rules.


 
### ✅ **FluentValidation** 

FluentValidation - is a popular **.NET library** used for building **strongly-typed validation rules** for your objects (usually models or DTOs) in a clean, readable, and maintainable way.

 * It allows you to define validation rules for your classes using a fluent interface (method chaining), making the code easy to read and write.
 
 * Helps you validate user input, business rules, or any data model properties.
 
 * Separates validation logic from business logic, improving code organization.
 
 * Works well with ASP.NET Core, MVC, Web API, and other .NET applications.
 
 * Supports **custom validation rules**, conditional validations, localization, and asynchronous validation.


 
### ✅ **MediatR** 

MediatR - is a simple but powerful **.NET library** that helps you implement the **Mediator Pattern**, promoting **loose coupling** between different parts of your application by sending messages (requests) and having them handled by handlers. 

MediatR acts like a **central message bus** inside your application. Instead of calling methods or services directly, you send a **request (or notification)**, and MediatR finds and calls the appropriate handler.

It’s commonly used to implement **CQRS (Command Query Responsibility Segregation)** in ASP.NET Core and .NET applications.


### ✅ **OpenAPI in Angular 16**

In **Angular 16**, OpenAPI is **not built-in**, but you **can use it to generate Angular services** that connect to a backend API described by an OpenAPI (Swagger) spec.

### ✅ **OpenAPI Usage in Angular 16**

You can **auto-generate TypeScript/Angular API clients** using the OpenAPI spec, so you don’t manually write HTTP requests.

### ✅ **NSwag** 

NSwag is a tool designed to **bridge the gap between back-end APIs and front-end clients** by automating the creation of API clients and documentation using OpenAPI (Swagger) specs.

NSwag saves time and prevents errors by generating strongly typed code (clients or server stubs) from your API definition.

## Setup and Running the application (Locally)

Steps here..

## Code Scaffolding

The project includes support to scaffold new commands and queries.

Start in the `.\src\Application\` folder.

## Build

Run `dotnet build -tl` to build the solution.

## Run

To run the web application:

```bash
cd .\src\Web\
dotnet watch run
```

Navigate to https://localhost:5001. The application will automatically reload if you change any of the source files.

Start in the `.\src\Application\` folder.

## ✅ Demo Application

**"You can check the test application at this link: http://www.weather.somee.com/

Note: This is hosted on a free service, so it may be temporarily disabled by the hosting provider."**