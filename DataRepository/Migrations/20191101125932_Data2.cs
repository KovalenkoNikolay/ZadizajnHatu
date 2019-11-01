using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataRepository.Migrations
{
    public partial class Data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_PortfolioProject_PortfolioProjectId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioProject_Workers_WorkerId",
                table: "PortfolioProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioProject",
                table: "PortfolioProject");

            migrationBuilder.DeleteData(
                table: "WorkerPrice",
                keyColumn: "WorkerPriceId",
                keyValue: new Guid("b0def08c-867e-4586-85ce-b200b218cecd"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca"));

            migrationBuilder.RenameTable(
                name: "PortfolioProject",
                newName: "PortfolioProjects");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioProject_WorkerId",
                table: "PortfolioProjects",
                newName: "IX_PortfolioProjects_WorkerId");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Workers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Workers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioProjects",
                table: "PortfolioProjects",
                column: "PortfolioProjectId");

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "Avatar", "ContactInfo", "Name", "Rating", "RegistrationDate", "WorkerTypeId" },
                values: new object[] { new Guid("504b2100-0b85-4a03-8def-8a856a3db6d5"), null, "{\"address\":\"Ломоносова 50\",\"email\":\"verandadesignstuio@gmail.com\",\"phones\":[\"+1111111111\",\"222222222222\"],\"site\":\"verandadesignstuion.com\",\"socialMedia\":{\"instagram\":\"instagramVeranda\",\"facebook\":\"facebookVeranda\",\"pinterest\":\"pinterestVeranda\"}}", "Veranda Design Studio", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "WorkerPrice",
                columns: new[] { "WorkerPriceId", "Amount", "WorkerId" },
                values: new object[] { new Guid("785cc532-d321-4a31-a5f1-a7feb57ef209"), 10m, new Guid("504b2100-0b85-4a03-8def-8a856a3db6d5") });

            migrationBuilder.AddForeignKey(
                name: "FK_Image_PortfolioProjects_PortfolioProjectId",
                table: "Image",
                column: "PortfolioProjectId",
                principalTable: "PortfolioProjects",
                principalColumn: "PortfolioProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioProjects_Workers_WorkerId",
                table: "PortfolioProjects",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_PortfolioProjects_PortfolioProjectId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_PortfolioProjects_Workers_WorkerId",
                table: "PortfolioProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PortfolioProjects",
                table: "PortfolioProjects");

            migrationBuilder.DeleteData(
                table: "WorkerPrice",
                keyColumn: "WorkerPriceId",
                keyValue: new Guid("785cc532-d321-4a31-a5f1-a7feb57ef209"));

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "WorkerId",
                keyValue: new Guid("504b2100-0b85-4a03-8def-8a856a3db6d5"));

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "PortfolioProjects",
                newName: "PortfolioProject");

            migrationBuilder.RenameIndex(
                name: "IX_PortfolioProjects_WorkerId",
                table: "PortfolioProject",
                newName: "IX_PortfolioProject_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PortfolioProject",
                table: "PortfolioProject",
                column: "PortfolioProjectId");

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "ContactInfo", "Name", "WorkerTypeId" },
                values: new object[] { new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca"), "Ломоносова 46/1", "Veranda Design Studio", 1 });

            migrationBuilder.InsertData(
                table: "WorkerPrice",
                columns: new[] { "WorkerPriceId", "Amount", "WorkerId" },
                values: new object[] { new Guid("b0def08c-867e-4586-85ce-b200b218cecd"), 10m, new Guid("b0fb7e92-1c00-45f7-8d5a-e9b7499c8cca") });

            migrationBuilder.AddForeignKey(
                name: "FK_Image_PortfolioProject_PortfolioProjectId",
                table: "Image",
                column: "PortfolioProjectId",
                principalTable: "PortfolioProject",
                principalColumn: "PortfolioProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PortfolioProject_Workers_WorkerId",
                table: "PortfolioProject",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
