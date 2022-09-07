using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bank_SUT21_VS2022.Migrations
{
    public partial class correctnamespace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transcations",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HolderName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SWIFTCode = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcations", x => x.TransactionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transcations");
        }
    }
}
