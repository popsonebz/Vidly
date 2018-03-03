using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vidly.Migrations
{
    public partial class updategenretable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          migrationBuilder.Sql("SET Identity_Insert Movies ON");
          migrationBuilder.Sql("UPDATE Movies SET GenreId1 = 1 WHERE Id = 1");
          migrationBuilder.Sql("UPDATE Movies SET GenreId1 = 2 WHERE Id = 2");
          migrationBuilder.Sql("UPDATE Movies SET GenreId1 = 3 WHERE Id = 3");
          migrationBuilder.Sql("UPDATE Movies SET GenreId1 = 4 WHERE Id = 4");
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
