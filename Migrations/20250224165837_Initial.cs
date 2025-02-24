using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mission8.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Type",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Quadrent1s",
                columns: table => new
                {
                    Q1Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataType = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quadrent = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TruFalse = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrent1s", x => x.Q1Id);
                    table.ForeignKey(
                        name: "FK_Quadrent1s_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quadrent2s",
                columns: table => new
                {
                    Q2Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataType = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quadrent = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TruFalse = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrent2s", x => x.Q2Id);
                    table.ForeignKey(
                        name: "FK_Quadrent2s_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quadrent3s",
                columns: table => new
                {
                    Q3Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataType = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quadrent = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TruFalse = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrent3s", x => x.Q3Id);
                    table.ForeignKey(
                        name: "FK_Quadrent3s_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quadrent4s",
                columns: table => new
                {
                    Q4Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataType = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quadrent = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TruFalse = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quadrent4s", x => x.Q4Id);
                    table.ForeignKey(
                        name: "FK_Quadrent4s_Type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Type",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Home" },
                    { 2, "School" },
                    { 3, "Work" },
                    { 4, "Church" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quadrent1s_TypeId",
                table: "Quadrent1s",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrent2s_TypeId",
                table: "Quadrent2s",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrent3s_TypeId",
                table: "Quadrent3s",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quadrent4s_TypeId",
                table: "Quadrent4s",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quadrent1s");

            migrationBuilder.DropTable(
                name: "Quadrent2s");

            migrationBuilder.DropTable(
                name: "Quadrent3s");

            migrationBuilder.DropTable(
                name: "Quadrent4s");

            migrationBuilder.DropTable(
                name: "Type");
        }
    }
}
