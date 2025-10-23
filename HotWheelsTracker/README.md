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

---

#### Week 11 - Separation of Concerns / Dependency Injection

I implemented the Separation of Concerns and Dependency Injection feature in the HotWheelsTracker project. The main goal was to move all non-UI logic out of the controller and into a dedicated service, making the controller thinner and easier to maintain.

I created a new folder called Services and added an ICarService interface along with a CarService class. The service handles retrieving cars from the database and sorting them by value. 
This keeps the controller focused solely on coordinating between the view and the service, which aligns with the Separation of Concerns principle.

In `Program.cs`, I registered the service with the dependency injection container using `builder.Services.AddScoped<ICarService`, `CarService>();`. This ensures that whenever a controller requests `ICarService`, the DI container provides an instance of `CarService`. 
In the `HomeController`, I removed the previous logger constructor and replaced it with a constructor that accepts `ICarService`. The controller now calls the service to get the list of cars and passes them to the Index view.
The result is visible on the homepage, where the cars table loads correctly, confirming that DI is working and the controller remains focused on routing and presentation. This approach not only makes the code cleaner and easier to maintain but also allows future features (like filtering or sorting) to be implemented entirely in the service without modifying the controller.

### Evidence / Screenshots

- **Homepage showing cars loaded via CarService (DI working)**  
  ![Homepage with cars table](Screenshots/Screenshot_HotWheelsTracker2.png)

- **Program.cs DI registration and HomeController constructor using ICarService**  
  ![Program.cs and HomeController.cs](Screenshots/Screenshot_HotWheelsTracker3.png)
---
