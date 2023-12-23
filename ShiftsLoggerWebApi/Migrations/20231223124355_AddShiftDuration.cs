using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShiftsLoggerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddShiftDuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "Duration",
                table: "Shifts",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Shifts");
        }
    }
}
