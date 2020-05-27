using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_First_Poject.Migrations
{
    public partial class Version100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Megapixel = table.Column<int>(nullable: false),
                    Sensor = table.Column<string>(nullable: true),
                    FocalLength = table.Column<int>(nullable: false),
                    NumberOfLength = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraID);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    Storage = table.Column<int>(nullable: false),
                    ScreenSize = table.Column<int>(nullable: false),
                    YearManufact = table.Column<DateTime>(nullable: false),
                    MainCameraCameraID = table.Column<int>(nullable: true),
                    SelfieCameraCameraID = table.Column<int>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    Battery = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneID);
                    table.ForeignKey(
                        name: "FK_Phones_Cameras_MainCameraCameraID",
                        column: x => x.MainCameraCameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_Cameras_SelfieCameraCameraID",
                        column: x => x.SelfieCameraCameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_MainCameraCameraID",
                table: "Phones",
                column: "MainCameraCameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_SelfieCameraCameraID",
                table: "Phones",
                column: "SelfieCameraCameraID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}
