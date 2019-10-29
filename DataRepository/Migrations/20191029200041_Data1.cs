using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataRepository.Migrations
{
    public partial class Data1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: new Guid("22219702-c91c-4da5-9f96-d24baa8526b6"));

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "ContactInfo", "Name", "WorkerTypeId" },
                values: new object[] { new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca"), "Ломоносова 46/1", "Veranda Design Studio", 1 });

            migrationBuilder.InsertData(
                table: "WorkerPrice",
                columns: new[] { "WorkerPriceId", "Amount", "WorkerId" },
                values: new object[] { new Guid("b0def08c-867e-4586-85ce-b200b218cecd"), 10m, new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkerPrice",
                keyColumn: "WorkerPriceId",
                keyValue: new Guid("b0def08c-867e-4586-85ce-b200b218cecd"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca"));

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "ContactInfo", "Name", "WorkerTypeId" },
                values: new object[] { new Guid("22219702-c91c-4da5-9f96-d24baa8526b6"), "Ломоносова 46/1", "Veranda Design Studio", 1 });
        }
    }
}
