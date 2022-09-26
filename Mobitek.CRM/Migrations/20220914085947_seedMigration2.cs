using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobitek.CRM.Migrations
{
    public partial class seedMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CustomerAccountableId", "Infrastructure", "Name", "SEMBudget", "SEMContract", "SEMExpertId", "SEMMeetingDate", "SEMReportDate", "SEMReportMail", "SEMStartDate", "SEMStatus", "SEOBudget", "SEOContract", "SEOExpertId", "SEOMeetingDate", "SEOReportDate", "SEOReportMail", "SEOStartDate", "SEOStatus" },
                values: new object[] { "1", new DateTime(2022, 9, 14, 11, 59, 47, 263, DateTimeKind.Local).AddTicks(4358), null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mail1.2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mail1.1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "CustomerAccountableId", "Infrastructure", "Name", "SEMBudget", "SEMContract", "SEMExpertId", "SEMMeetingDate", "SEMReportDate", "SEMReportMail", "SEMStartDate", "SEMStatus", "SEOBudget", "SEOContract", "SEOExpertId", "SEOMeetingDate", "SEOReportDate", "SEOReportMail", "SEOStartDate", "SEOStatus" },
                values: new object[] { "2", new DateTime(2022, 9, 14, 11, 59, 47, 264, DateTimeKind.Local).AddTicks(8270), null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mail2.2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mail2.1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
