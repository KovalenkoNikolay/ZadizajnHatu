using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataRepository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "WorkerType",
                columns: table => new
                {
                    WorkerTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerType", x => x.WorkerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Region_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    WorkerTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_WorkerType_WorkerTypeId",
                        column: x => x.WorkerTypeId,
                        principalTable: "WorkerType",
                        principalColumn: "WorkerTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    ContactInfo = table.Column<string>(nullable: true),
                    RemoteWork = table.Column<bool>(nullable: false),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    WorkerTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_Workers_WorkerType_WorkerTypeId",
                        column: x => x.WorkerTypeId,
                        principalTable: "WorkerType",
                        principalColumn: "WorkerTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PortfolioProjects",
                columns: table => new
                {
                    PortfolioProjectId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    WorkerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioProjects", x => x.PortfolioProjectId);
                    table.ForeignKey(
                        name: "FK_PortfolioProjects_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerPrice",
                columns: table => new
                {
                    WorkerPriceId = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    WorkerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerPrice", x => x.WorkerPriceId);
                    table.ForeignKey(
                        name: "FK_WorkerPrice_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    WorkerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerReviews_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerService",
                columns: table => new
                {
                    WorkerServiceId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    WorkerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerService", x => x.WorkerServiceId);
                    table.ForeignKey(
                        name: "FK_WorkerService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerService_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerCity",
                columns: table => new
                {
                    WorkerCityId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    WorkerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerCity", x => x.WorkerCityId);
                    table.ForeignKey(
                        name: "FK_WorkerCity_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerCity_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkGeography",
                columns: table => new
                {
                    WorkGeographyId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<int>(nullable: true),
                    RegionId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    WorkerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkGeography", x => x.WorkGeographyId);
                    table.ForeignKey(
                        name: "FK_WorkGeography_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkGeography_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkGeography_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkGeography_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PortfolioProjectId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Image_PortfolioProjects_PortfolioProjectId",
                        column: x => x.PortfolioProjectId,
                        principalTable: "PortfolioProjects",
                        principalColumn: "PortfolioProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "Украина" });

            migrationBuilder.InsertData(
                table: "WorkerType",
                columns: new[] { "WorkerTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Дизайнер" },
                    { 2, "Чертежник" },
                    { 3, "Архитектор" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionId", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Киевская" },
                    { 22, 1, "Черниговская" },
                    { 21, 1, "Черкасская" },
                    { 20, 1, "Хмельницкая" },
                    { 19, 1, "Херсонская" },
                    { 18, 1, "Харьковская" },
                    { 17, 1, "Тернопольская" },
                    { 16, 1, "Сумская" },
                    { 15, 1, "Ровненская" },
                    { 14, 1, "Полтавская" },
                    { 13, 1, "Одесская" },
                    { 12, 1, "Николаевская" },
                    { 11, 1, "Львовская" },
                    { 10, 1, "Луганская" },
                    { 9, 1, "Кировоградская" },
                    { 8, 1, "Ивано-Франковская" },
                    { 7, 1, "Закарпатская" },
                    { 6, 1, "Житомирская" },
                    { 5, 1, "Донецкая" },
                    { 4, 1, "Днепропетровская" },
                    { 3, 1, "Волынская" },
                    { 2, 1, "Винницкая" },
                    { 23, 1, "Черновицкая" }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "Avatar", "ContactInfo", "Name", "RegistrationDate", "RemoteWork", "WorkerTypeId" },
                values: new object[] { new Guid("e84c3e1b-a590-4e89-95a4-75c0e9cc951f"), null, "{\"address\":\"Ломоносова 50\",\"email\":\"verandadesignstuio@gmail.com\",\"phones\":[\"+1111111111\",\"222222222222\"],\"site\":\"verandadesignstuion.com\",\"socialMedia\":{\"instagram\":\"instagramVeranda\",\"facebook\":\"facebookVeranda\",\"pinterest\":\"pinterestVeranda\"}}", "Veranda Design Studio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1 });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, "Киев", 1 },
                    { 22, "Ладижин", 2 },
                    { 21, "Козятин", 2 },
                    { 20, "Гайсин", 2 },
                    { 19, "Хмельник", 2 },
                    { 18, "Могилёв-Подольский", 2 },
                    { 17, "Жмеринка", 2 },
                    { 16, "Винница", 2 },
                    { 15, "Яготин", 1 },
                    { 14, "Славутич", 1 },
                    { 13, "Вышгород", 1 },
                    { 12, "Переяслав", 1 },
                    { 11, "Буча", 1 },
                    { 10, "Обухов", 1 },
                    { 9, "Боярка", 1 },
                    { 8, "Васильков", 1 },
                    { 7, "Вишнёвое", 1 },
                    { 6, "Ирпень", 1 },
                    { 5, "Фастов", 1 },
                    { 4, "Борисполь", 1 },
                    { 3, "Бровары", 1 },
                    { 2, "Белая Церковь", 1 },
                    { 23, "Калиновка", 2 }
                });

            migrationBuilder.InsertData(
                table: "WorkerPrice",
                columns: new[] { "WorkerPriceId", "Amount", "WorkerId" },
                values: new object[] { new Guid("0e94650f-b0f9-4dc1-9e2e-4c4e5cca147b"), 10m, new Guid("e84c3e1b-a590-4e89-95a4-75c0e9cc951f") });

            migrationBuilder.CreateIndex(
                name: "IX_City_RegionId",
                table: "City",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PortfolioProjectId",
                table: "Image",
                column: "PortfolioProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioProjects_WorkerId",
                table: "PortfolioProjects",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Region_CountryId",
                table: "Region",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_WorkerTypeId",
                table: "Service",
                column: "WorkerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerCity_CityId",
                table: "WorkerCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerCity_WorkerId",
                table: "WorkerCity",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerPrice_WorkerId",
                table: "WorkerPrice",
                column: "WorkerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerReviews_WorkerId",
                table: "WorkerReviews",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorkerTypeId",
                table: "Workers",
                column: "WorkerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerService_ServiceId",
                table: "WorkerService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerService_WorkerId",
                table: "WorkerService",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkGeography_CityId",
                table: "WorkGeography",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkGeography_CountryId",
                table: "WorkGeography",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkGeography_RegionId",
                table: "WorkGeography",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkGeography_WorkerId",
                table: "WorkGeography",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "WorkerCity");

            migrationBuilder.DropTable(
                name: "WorkerPrice");

            migrationBuilder.DropTable(
                name: "WorkerReviews");

            migrationBuilder.DropTable(
                name: "WorkerService");

            migrationBuilder.DropTable(
                name: "WorkGeography");

            migrationBuilder.DropTable(
                name: "PortfolioProjects");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "WorkerType");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
