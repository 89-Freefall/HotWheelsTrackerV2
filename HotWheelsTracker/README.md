# HotWheelsTracker

ASP.NET Core MVC web app that helps collectors manage and organize their Hot Wheels collection. Users can add, edit, and delete cars, track details like year, color, and value, and view top collectibles.

---

## Week 10 – Modeling

Implemented the Modeling feature for the HotWheelsTracker project. The main goal was to define a data model that represents Hot Wheels cars in the database and prepare it for future features like CRUD operations and service-based logic. I created a `Car` entity class with the following properties: `Id`, `Name`, `Series`, `Year`, `Color`, `Condition`, and `Value`. These properties capture the essential information that a collector would want to track for each car.

Next, I created an `ApplicationDbContext` class, inheriting from `DbContext`, and added a `DbSet<Car>` to represent the Cars table in the database. I configured the DbContext in `Program.cs` and connected it to a SQL Server LocalDB database via a connection string.

After setting up the model and DbContext, I installed the necessary EF Core packages, including `Microsoft.EntityFrameworkCore.SqlServer` and `Microsoft.EntityFrameworkCore.Tools`, to enable migrations. I then created my first migration with the command `Add-Migration Week10_Modeling` and applied it to the database using `Update-Database`. This created the `Cars` table with all defined columns.

To verify the setup, I checked **SQL Server Object Explorer** in Visual Studio and confirmed that the `Cars` table exists with the correct schema. I also built and ran the project to ensure there were no errors, confirming that the database connection and model configuration are working correctly.

---

### Evidence / Screenshots

- **Cars table in SQL Server Object Explorer** & **Migrations folder**  
  ![Cars table and Migration folder](Screenshots/Screenshot_HotWheelsTracker1.png)
