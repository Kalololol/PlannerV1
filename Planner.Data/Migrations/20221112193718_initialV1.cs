using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planner.Data.Migrations
{
    public partial class initialV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "PlanDayId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Indispositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayIndisposition = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Change = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indispositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Indispositions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMonths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateMonth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateMonthBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMonths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMonths_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayRequest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Change = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePlanDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false),
                    PlanMonthId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanDays_PlanMonths_PlanMonthId",
                        column: x => x.PlanMonthId,
                        principalTable: "PlanMonths",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlanDays_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PlanDayId",
                table: "Employees",
                column: "PlanDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Indispositions_EmployeeId",
                table: "Indispositions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDays_PlanMonthId",
                table: "PlanDays",
                column: "PlanMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDays_WardId",
                table: "PlanDays",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMonths_WardId",
                table: "PlanMonths",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_EmployeeId",
                table: "Requests",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PlanDays_PlanDayId",
                table: "Employees",
                column: "PlanDayId",
                principalTable: "PlanDays",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PlanDays_PlanDayId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Indispositions");

            migrationBuilder.DropTable(
                name: "PlanDays");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "PlanMonths");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PlanDayId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PlanDayId",
                table: "Employees");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Contracts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Contracts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
