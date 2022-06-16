# MVC CRUD App with SQLite

**Dependencies:**

- `dotnet tool install -g dotnet-ef`
- `dotnet tool install -g dotnet-aspnet-codegenerator`

## Getting Started

1. Create a new MVC application
   - `dotnet new mvc -o [project name]`
   - `cd [project name]`
2. Install EF Packages:
   - `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design`
   - `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`
   - `dotnet add package Microsoft.EntityFrameworkCore.Design`
   - `dotnet add package Microsoft.EntityFrameworkCore`
3. Build your first Model (**[Entity]**):
   - Create a new class in the models folder, this will be the first table in your database
4. Create your Database Context (Context.cs)
```csharp
public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=test.db");
    }
   
   public DbSet<[Entity]]> [Entity] {get;set;}
}
```
6. Add Context to the Dependency Pipeline:
   - Add this line to Program.cs
```csharp
builder.Services.AddDbContext<Context>();
```

5. Create your first migration:
   - `dotnet ef migrations add InitialCreate --context Context`
6. Apply your first migration:
   - `dotnet ef database update`
7. Scaffold your first Controllers/ Views
   - `dotnet aspnet-codegenerator controller --model [Entity] --dataContext Context --controllerName [Entity]Controller --relativeFolderPath Controllers --useDefaultLayout`

**Run/ test the program**
- `dotnet run`
- Navigate to your running program
- Navigate to the [Entity] controller
- Create, read, update, and delete entities