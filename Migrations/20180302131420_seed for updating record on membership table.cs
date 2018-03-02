using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vidly.Migrations
{
    public partial class seedforupdatingrecordonmembershiptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
           migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Prepaid' WHERE Id = 1");
           migrationBuilder.Sql("UPDATE MembershipType SET Name = 'Monthly' WHERE Id = 2");
           
        }
        

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
