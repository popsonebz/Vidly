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

8. we now have customers table and membershiptype table. notice that we did not add membershiptype dbset in applicationdbcontext yet it created the migration and update due to the relationship between the tables "pulic MembershipType and MembershipId".

note: membershipid is automatically detected as a forien key while membershiptype property is used for loading the related tables since a customer will have a membershiptype.

9. Seeding a database: run the command
```
dotnet ef migrations add "Populate database"
```
This creates a migration file.
Add your sql inserts statements
