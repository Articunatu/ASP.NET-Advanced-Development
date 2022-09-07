using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_SUT21.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transcations",
                columns: table => new
                {
                    TransationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SWIFTCode = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcations", x => x.TransationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transcations");
        }
    }
}
