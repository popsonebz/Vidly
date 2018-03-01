# Creating C# Application

1. Run the command below to create a new application which has authentication templates

```
dotnet new mvc --auth Individual -n Vidly
```
2. Test the application by runnung

```
dotnet run
```

3. Create your views in respective folders and namespaces. Then under the "Data" folder 
open the ApplicationDbContext file add your DbSets.

4. Open your appsettings.json and add the connection to your database. give it a name e.g "defaultconnection".

5. Open the "Startup.cs" file and find the line with services.AddDbContext. specify the sql to use (e.g options.UseSqlServer) and the name of your database connection string.

6. Create a migration
```
dotnet ef migrations add "added customers table migration"
```

7. Update the database
```
dotnet ef database update
```
