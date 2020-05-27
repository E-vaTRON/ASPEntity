using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_First_Poject.Migrations
{
    public partial class version103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    HeadPhoneID = table.Column<int>(nullable: true),
                    LaptopID = table.Column<int>(nullable: true),
                    MechanicalKeyboardSwitchtype = table.Column<string>(nullable: true),
                    PhoneID = table.Column<int>(nullable: true),
                    TabletID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_HeadPhones_HeadPhoneID",
                        column: x => x.HeadPhoneID,
                        principalTable: "HeadPhones",
                        principalColumn: "HeadPhoneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Laptops_LaptopID",
                        column: x => x.LaptopID,
                        principalTable: "Laptops",
                        principalColumn: "LaptopID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_MechanicalKeyboards_MechanicalKeyboardSwitchtype",
                        column: x => x.MechanicalKeyboardSwitchtype,
                        principalTable: "MechanicalKeyboards",
                        principalColumn: "Switchtype",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Phones_PhoneID",
                        column: x => x.PhoneID,
                        principalTable: "Phones",
                        principalColumn: "PhoneID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Tablets_TabletID",
                        column: x => x.TabletID,
                        principalTable: "Tablets",
                        principalColumn: "TabletID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_HeadPhoneID",
                table: "Comment",
                column: "HeadPhoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_LaptopID",
                table: "Comment",
                column: "LaptopID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MechanicalKeyboardSwitchtype",
                table: "Comment",
                column: "MechanicalKeyboardSwitchtype");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PhoneID",
                table: "Comment",
                column: "PhoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TabletID",
                table: "Comment",
                column: "TabletID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}
