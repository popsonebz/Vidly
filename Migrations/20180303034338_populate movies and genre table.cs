using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vidly.Migrations
{
    public partial class populatemoviesandgenretable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

          migrationBuilder.Sql("SET Identity_Insert Genre ON");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Romance')");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Action')");
          migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Comedy')");
          migrationBuilder.Sql("SET Identity_Insert Genre OFF");
       /* 
          migrationBuilder.Sql("SET Identity_Insert Movies ON");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (1,'Hangover','2017-12-31','2018-01-02',5,1)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (2,'Die Hard','01-01-2018-01-01','2018-01-02',2,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (3,'The Terminator','2018-01-21','02-01-2018',3,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (4,'Toy story','02-01-2018','03-01-20128',4,4)");
          migrationBuilder.Sql("SET Identity_Insert Movies OFF");  */
        
          migrationBuilder.Sql("SET Identity_Insert Movies ON");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (1,'Hangover','12-31-2017','01-02-2018',5,1)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (2,'Die Hard','01-01-2018','01-02-2018',2,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (3,'The Terminator','01-21-2018','02-01-2018',3,2)");
          migrationBuilder.Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreIdId) VALUES (4,'Toy story','02-01-2018','03-01-2018',4,4)");
          migrationBuilder.Sql("SET Identity_Insert Movies OFF");

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
