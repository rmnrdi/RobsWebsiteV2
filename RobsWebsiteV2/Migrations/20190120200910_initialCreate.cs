using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RobsWebsiteV2.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalcTypes",
                columns: table => new
                {
                    CalcTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CalcTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalcTypes", x => x.CalcTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    CalcId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CalcName = table.Column<string>(nullable: true),
                    CalcTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => x.CalcId);
                    table.ForeignKey(
                        name: "FK_Calculations_CalcTypes_CalcTypeId",
                        column: x => x.CalcTypeId,
                        principalTable: "CalcTypes",
                        principalColumn: "CalcTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calculations_CalcTypeId",
                table: "Calculations",
                column: "CalcTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculations");

            migrationBuilder.DropTable(
                name: "CalcTypes");
        }
    }
}
