using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExampleASP.NET.Migrations
{
    public partial class ShopCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shopCartItems",
                columns: table => new
                {
                    itemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    carid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    ShopCartID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shopCartItems", x => x.itemID);
                    table.ForeignKey(
                        name: "FK_shopCartItems_Car_carid",
                        column: x => x.carid,
                        principalTable: "Car",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shopCartItems_carid",
                table: "shopCartItems",
                column: "carid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shopCartItems");
        }
    }
}
