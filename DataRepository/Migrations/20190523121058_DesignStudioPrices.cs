using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataRepository.Migrations
{
    public partial class DesignStudioPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignStudioPriceType_DesignStudioPrice_DesignStudioPriceId",
                table: "DesignStudioPriceType");

            migrationBuilder.DropIndex(
                name: "IX_DesignStudioPriceType_DesignStudioPriceId",
                table: "DesignStudioPriceType");

            migrationBuilder.DropColumn(
                name: "DesignStudioPriceId",
                table: "DesignStudioPriceType");

            migrationBuilder.AddColumn<Guid>(
                name: "PriceTypeId",
                table: "DesignStudioPrice",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DesignStudioPrice_PriceTypeId",
                table: "DesignStudioPrice",
                column: "PriceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DesignStudioPrice_DesignStudioPriceType_PriceTypeId",
                table: "DesignStudioPrice",
                column: "PriceTypeId",
                principalTable: "DesignStudioPriceType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignStudioPrice_DesignStudioPriceType_PriceTypeId",
                table: "DesignStudioPrice");

            migrationBuilder.DropIndex(
                name: "IX_DesignStudioPrice_PriceTypeId",
                table: "DesignStudioPrice");

            migrationBuilder.DropColumn(
                name: "PriceTypeId",
                table: "DesignStudioPrice");

            migrationBuilder.AddColumn<Guid>(
                name: "DesignStudioPriceId",
                table: "DesignStudioPriceType",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DesignStudioPriceType_DesignStudioPriceId",
                table: "DesignStudioPriceType",
                column: "DesignStudioPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_DesignStudioPriceType_DesignStudioPrice_DesignStudioPriceId",
                table: "DesignStudioPriceType",
                column: "DesignStudioPriceId",
                principalTable: "DesignStudioPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
