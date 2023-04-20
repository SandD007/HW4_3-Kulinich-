using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW43.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeID);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirht = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfficeId = table.Column<int>(type: "int", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employe_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employe_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeProject",
                columns: table => new
                {
                    EmployeeProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeProject", x => x.EmployeeProjectId);
                    table.ForeignKey(
                        name: "FK_EmployeProject_Employe_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employe",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeProject_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 1, "Client1" },
                    { 2, "Client2" },
                    { 3, "Client3" },
                    { 4, "Client4" },
                    { 5, "Client5" }
                });

            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "OfficeID", "Location", "Title" },
                values: new object[,]
                {
                    { 1, "USA", "Some Title" },
                    { 2, "Canada", "Some Title2" },
                    { 3, "Japan", "Some Title3" },
                    { 4, "Africa", "Some Title4" },
                    { 5, "UK", "Some Title5" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "Title1a" },
                    { 2, "Title2" },
                    { 3, "Title3" },
                    { 4, "Title4a" },
                    { 5, "Title5" }
                });

            migrationBuilder.InsertData(
                table: "Employe",
                columns: new[] { "EmployeeId", "DateOfBirht", "FirstName", "HiredData", "LastName", "OfficeId", "TitleId" },
                values: new object[,]
                {
                    { 1, new DateTime(1560, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Josh", new DateTime(2009, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pipka", 1, 1 },
                    { 2, new DateTime(1450, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vasan", new DateTime(1850, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zapal", 2, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nina", new DateTime(2000, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponos", 3, 3 },
                    { 4, new DateTime(2, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maksim", new DateTime(2020, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katz", 4, 4 },
                    { 5, new DateTime(1476, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valera", new DateTime(2003, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponosov", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Budget", "ClientId", "Name", "StartedData" },
                values: new object[,]
                {
                    { 1, 12000m, 1, "Fanta", new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 24000m, 2, "CSGO", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 850000m, 3, "WOW", new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 8520000m, 4, "Wurm", new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 8150000m, 5, "RDR2", new DateTime(2017, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedData" },
                values: new object[,]
                {
                    { 1, 1, 1, 2500m, new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 2, 6200m, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 3, 7630m, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 4, 8463m, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 5, 84320m, new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employe_OfficeId",
                table: "Employe",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employe_TitleId",
                table: "Employe",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeProject_EmployeeId",
                table: "EmployeProject",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeProject_ProjectId",
                table: "EmployeProject",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeProject");

            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
