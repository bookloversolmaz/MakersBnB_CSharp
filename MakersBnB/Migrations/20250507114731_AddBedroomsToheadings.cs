﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakersBnB.Migrations
{
    /// <inheritdoc />
    public partial class AddBedroomsToheadings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bedrooms",
                table: "Spaces",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bedrooms",
                table: "Spaces");
        }
    }
}
