using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vidly.Migrations
{
    public partial class modifiedmoviestableandaddedgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "GenreId1",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenreIdId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId1",
                table: "Movies",
                column: "GenreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreIdId",
                table: "Movies",
                column: "GenreIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genre_GenreId1",
                table: "Movies",
                column: "GenreId1",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genre_GenreIdId",
                table: "Movies",
                column: "GenreIdId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genre_GenreId1",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genre_GenreIdId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreIdId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreId1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreIdId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                nullable: true);
        }
    }
}
