using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vidly.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql("SET Identity_Insert Genre ON");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Romance')");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Comedy')");
          migrationBuilder.Sql("SET Identity_Insert Genre OFF");

           migrationBuilder.Sql("SET Identity_Insert MembershipType ON");
           migrationBuilder.Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1,0,0,0)");
           migrationBuilder.Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2,30,1,10)");
           migrationBuilder.Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3,90,3,15)");
           migrationBuilder.Sql("INSERT INTO MembershipType (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4,300,12,20)");
           migrationBuilder.Sql("SET Identity_Insert MembershipType OFF");
           
           migrationBuilder.Sql("SET Identity_Insert Customers ON");
           migrationBuilder.Sql("INSERT INTO Customers (Id, Name, MembershipTypeId, IsSubscribedToNewsLetter) VALUES (1,'Ebenezer',1,'true')");
           migrationBuilder.Sql("INSERT INTO Customers (Id, Name, MembershipTypeId, IsSubscribedToNewsLetter) VALUES (2,'Josh',1,'true')");
           migrationBuilder.Sql("INSERT INTO Customers (Id, Name, MembershipTypeId, IsSubscribedToNewsLetter) VALUES (3,'Brenda',2,'true')");
           migrationBuilder.Sql("SET Identity_Insert Customers OFF");

          migrationBuilder.Sql("SET Identity_Insert Movies ON");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (1,'Hangover','12-31-2017','01-02-2018',5,1)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (2,'Die Hard','01-01-2018','01-02-2018',2,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (3,'The Terminator','01-21-2018','02-01-2018',3,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (4,'Toy story','02-01-2018','03-01-2018',4,3)");
          migrationBuilder.Sql("SET Identity_Insert Movies OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
