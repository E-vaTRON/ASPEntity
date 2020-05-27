using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_First_Poject.Migrations
{
    public partial class Version102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Phones",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPU",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GPU",
                table: "Phones",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HeadPhones",
                columns: table => new
                {
                    HeadPhoneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    YearManufact = table.Column<DateTime>(nullable: false),
                    LedRGB = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    Bluetooth = table.Column<float>(nullable: false),
                    ConnectingGate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadPhones", x => x.HeadPhoneID);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    LaptopID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    YearManufact = table.Column<DateTime>(nullable: false),
                    CPU = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    Storage = table.Column<int>(nullable: false),
                    ScreenSize = table.Column<int>(nullable: false),
                    CameraID = table.Column<int>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    Battery = table.Column<double>(nullable: false),
                    Touchpad = table.Column<string>(nullable: true),
                    Fingersensor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.LaptopID);
                    table.ForeignKey(
                        name: "FK_Laptops_Cameras_CameraID",
                        column: x => x.CameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MechanicalKeyboards",
                columns: table => new
                {
                    Switchtype = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    YearManufact = table.Column<DateTime>(nullable: false),
                    SwitchBrand = table.Column<string>(nullable: true),
                    LedRGB = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    Keycap = table.Column<string>(nullable: true),
                    Bluetooth = table.Column<float>(nullable: false),
                    ConnectingGate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicalKeyboards", x => x.Switchtype);
                });

            migrationBuilder.CreateTable(
                name: "Tablets",
                columns: table => new
                {
                    TabletID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    YearManufact = table.Column<DateTime>(nullable: false),
                    CPU = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Ram = table.Column<int>(nullable: false),
                    Storage = table.Column<int>(nullable: false),
                    ScreenSize = table.Column<int>(nullable: false),
                    MainCameraCameraID = table.Column<int>(nullable: true),
                    SelfieCameraCameraID = table.Column<int>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    Battery = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tablets", x => x.TabletID);
                    table.ForeignKey(
                        name: "FK_Tablets_Cameras_MainCameraCameraID",
                        column: x => x.MainCameraCameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tablets_Cameras_SelfieCameraCameraID",
                        column: x => x.SelfieCameraCameraID,
                        principalTable: "Cameras",
                        principalColumn: "CameraID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Laptops_CameraID",
                table: "Laptops",
                column: "CameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_MainCameraCameraID",
                table: "Tablets",
                column: "MainCameraCameraID");

            migrationBuilder.CreateIndex(
                name: "IX_Tablets_SelfieCameraCameraID",
                table: "Tablets",
                column: "SelfieCameraCameraID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeadPhones");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "MechanicalKeyboards");

            migrationBuilder.DropTable(
                name: "Tablets");

            migrationBuilder.DropColumn(
                name: "CPU",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "GPU",
                table: "Phones");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
