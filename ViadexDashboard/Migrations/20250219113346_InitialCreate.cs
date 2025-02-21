using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ViadexDashboard.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    EncryptionEnabled = table.Column<bool>(type: "bit", nullable: false),
                    PolicyCompliant = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceData_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DEXScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    PerformanceScore = table.Column<double>(type: "float", nullable: false),
                    UserFeedbackScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEXScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DEXScores_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SustainabilityData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    PowerConsumption = table.Column<double>(type: "float", nullable: false),
                    CarbonFootprint = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SustainabilityData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SustainabilityData_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelemetryData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<int>(type: "int", nullable: false),
                    CPUUsage = table.Column<double>(type: "float", nullable: false),
                    MemoryUsage = table.Column<double>(type: "float", nullable: false),
                    DiskUsage = table.Column<double>(type: "float", nullable: false),
                    RecordedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelemetryData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelemetryData_Devices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Devices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "OS", "SerialNumber" },
                values: new object[,]
                {
                    { 1, "Laptop1", "Windows 10", "SN001" },
                    { 2, "Laptop2", "Windows 11", "SN002" },
                    { 3, "Laptop3", "Windows 10", "SN003" },
                    { 4, "Laptop4", "Windows 11", "SN004" },
                    { 5, "Laptop5", "Windows 10", "SN005" },
                    { 6, "Laptop6", "Windows 11", "SN006" },
                    { 7, "Laptop7", "Windows 10", "SN007" },
                    { 8, "Laptop8", "Windows 11", "SN008" },
                    { 9, "Laptop9", "Windows 10", "SN009" },
                    { 10, "Laptop10", "Windows 11", "SN010" },
                    { 11, "Laptop11", "Windows 10", "SN011" },
                    { 12, "Laptop12", "Windows 11", "SN012" },
                    { 13, "Laptop13", "Windows 10", "SN013" },
                    { 14, "Laptop14", "Windows 11", "SN014" },
                    { 15, "Laptop15", "Windows 10", "SN015" },
                    { 16, "Laptop16", "Windows 11", "SN016" },
                    { 17, "Laptop17", "Windows 10", "SN017" },
                    { 18, "Laptop18", "Windows 11", "SN018" },
                    { 19, "Laptop19", "Windows 10", "SN019" },
                    { 20, "Laptop20", "Windows 11", "SN020" },
                    { 21, "Laptop21", "Windows 10", "SN021" },
                    { 22, "Laptop22", "Windows 11", "SN022" },
                    { 23, "Laptop23", "Windows 10", "SN023" },
                    { 24, "Laptop24", "Windows 11", "SN024" },
                    { 25, "Laptop25", "Windows 10", "SN025" }
                });

            migrationBuilder.InsertData(
                table: "ComplianceData",
                columns: new[] { "Id", "DeviceId", "EncryptionEnabled", "PolicyCompliant" },
                values: new object[,]
                {
                    { 1, 1, true, false },
                    { 2, 2, true, true },
                    { 3, 3, false, false },
                    { 4, 4, true, false },
                    { 5, 5, false, true },
                    { 6, 6, true, true },
                    { 7, 7, true, true },
                    { 8, 8, false, false },
                    { 9, 9, true, false },
                    { 10, 10, true, false },
                    { 11, 11, true, true },
                    { 12, 12, true, true },
                    { 13, 13, true, true },
                    { 14, 14, false, false },
                    { 15, 15, false, true },
                    { 16, 16, true, true },
                    { 17, 17, true, true },
                    { 18, 18, false, false },
                    { 19, 19, true, false },
                    { 20, 20, true, true },
                    { 21, 21, true, false },
                    { 22, 22, true, false },
                    { 23, 23, true, true },
                    { 24, 24, true, true },
                    { 25, 25, true, true }
                });

            migrationBuilder.InsertData(
                table: "DEXScores",
                columns: new[] { "Id", "DeviceId", "PerformanceScore", "UserFeedbackScore" },
                values: new object[,]
                {
                    { 1, 1, 85.0, 4.2000000000000002 },
                    { 2, 2, 90.299999999999997, 4.5 },
                    { 3, 3, 78.5, 3.8999999999999999 },
                    { 4, 4, 88.099999999999994, 4.2999999999999998 },
                    { 5, 5, 92.400000000000006, 4.7000000000000002 },
                    { 6, 6, 80.200000000000003, 4.0 },
                    { 7, 7, 83.599999999999994, 4.0999999999999996 },
                    { 8, 8, 87.900000000000006, 4.4000000000000004 },
                    { 9, 9, 91.5, 4.5999999999999996 },
                    { 10, 10, 76.799999999999997, 3.7999999999999998 },
                    { 11, 11, 85.700000000000003, 4.2000000000000002 },
                    { 12, 12, 89.200000000000003, 4.2999999999999998 },
                    { 13, 13, 93.099999999999994, 4.7999999999999998 },
                    { 14, 14, 79.400000000000006, 3.8999999999999999 },
                    { 15, 15, 86.299999999999997, 4.2000000000000002 },
                    { 16, 16, 90.0, 4.5 },
                    { 17, 17, 81.700000000000003, 4.0 },
                    { 18, 18, 84.5, 4.0999999999999996 },
                    { 19, 19, 88.799999999999997, 4.4000000000000004 },
                    { 20, 20, 75.900000000000006, 3.7000000000000002 },
                    { 21, 21, 82.599999999999994, 4.0 },
                    { 22, 22, 87.200000000000003, 4.2999999999999998 },
                    { 23, 23, 92.0, 4.5999999999999996 },
                    { 24, 24, 77.5, 3.7999999999999998 },
                    { 25, 25, 89.700000000000003, 4.4000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "SustainabilityData",
                columns: new[] { "Id", "CarbonFootprint", "DeviceId", "PowerConsumption" },
                values: new object[,]
                {
                    { 1, 10.199999999999999, 1, 50.5 },
                    { 2, 9.8000000000000007, 2, 45.299999999999997 },
                    { 3, 11.0, 3, 52.100000000000001 },
                    { 4, 10.5, 4, 48.700000000000003 },
                    { 5, 9.9000000000000004, 5, 47.200000000000003 },
                    { 6, 10.6, 6, 49.799999999999997 },
                    { 7, 11.4, 7, 53.5 },
                    { 8, 9.6999999999999993, 8, 46.899999999999999 },
                    { 9, 10.9, 9, 51.0 },
                    { 10, 10.300000000000001, 10, 50.200000000000003 },
                    { 11, 10.0, 11, 48.0 },
                    { 12, 9.5999999999999996, 12, 45.700000000000003 },
                    { 13, 11.800000000000001, 13, 54.200000000000003 },
                    { 14, 9.8000000000000007, 14, 47.5 },
                    { 15, 10.699999999999999, 15, 50.899999999999999 },
                    { 16, 10.4, 16, 49.399999999999999 },
                    { 17, 11.199999999999999, 17, 52.799999999999997 },
                    { 18, 10.1, 18, 48.299999999999997 },
                    { 19, 9.6999999999999993, 19, 47.0 },
                    { 20, 10.6, 20, 50.700000000000003 },
                    { 21, 9.5, 21, 46.5 },
                    { 22, 10.800000000000001, 22, 51.299999999999997 },
                    { 23, 10.5, 23, 49.899999999999999 },
                    { 24, 11.1, 24, 53.0 },
                    { 25, 10.199999999999999, 25, 48.600000000000001 }
                });

            migrationBuilder.InsertData(
                table: "TelemetryData",
                columns: new[] { "Id", "CPUUsage", "DeviceId", "DiskUsage", "MemoryUsage", "RecordedAt" },
                values: new object[,]
                {
                    { 1, 25.5, 1, 45.100000000000001, 35.200000000000003, new DateTime(2024, 1, 1, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 22.300000000000001, 2, 48.5, 32.799999999999997, new DateTime(2024, 1, 2, 11, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 30.100000000000001, 3, 50.299999999999997, 40.700000000000003, new DateTime(2024, 1, 3, 9, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 28.399999999999999, 4, 47.600000000000001, 38.899999999999999, new DateTime(2024, 1, 4, 14, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 27.800000000000001, 5, 46.299999999999997, 37.200000000000003, new DateTime(2024, 1, 5, 16, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 26.899999999999999, 6, 45.0, 36.100000000000001, new DateTime(2024, 1, 6, 8, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 29.5, 7, 49.100000000000001, 39.5, new DateTime(2024, 1, 7, 12, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 31.199999999999999, 8, 50.700000000000003, 41.799999999999997, new DateTime(2024, 1, 8, 13, 25, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 24.100000000000001, 9, 44.5, 34.200000000000003, new DateTime(2024, 1, 9, 15, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 32.799999999999997, 10, 51.899999999999999, 43.700000000000003, new DateTime(2024, 1, 10, 17, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 30.5, 11, 48.100000000000001, 40.200000000000003, new DateTime(2024, 1, 11, 10, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 27.199999999999999, 12, 45.600000000000001, 36.899999999999999, new DateTime(2024, 1, 12, 14, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 26.399999999999999, 13, 44.299999999999997, 35.700000000000003, new DateTime(2024, 1, 13, 9, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 28.899999999999999, 14, 48.399999999999999, 39.200000000000003, new DateTime(2024, 1, 14, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 31.5, 15, 50.100000000000001, 42.700000000000003, new DateTime(2024, 1, 15, 16, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 23.800000000000001, 16, 43.200000000000003, 33.5, new DateTime(2024, 1, 16, 10, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 25.899999999999999, 17, 47.799999999999997, 37.399999999999999, new DateTime(2024, 1, 17, 14, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 29.800000000000001, 18, 50.899999999999999, 41.5, new DateTime(2024, 1, 18, 15, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 22.5, 19, 42.700000000000003, 32.100000000000001, new DateTime(2024, 1, 19, 11, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 24.899999999999999, 20, 48.399999999999999, 35.200000000000003, new DateTime(2024, 1, 20, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 38.5, 21, 55.100000000000001, 46.700000000000003, new DateTime(2024, 1, 21, 9, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 27.800000000000001, 22, 33.200000000000003, 38.5, new DateTime(2024, 1, 22, 12, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 39.899999999999999, 23, 27.800000000000001, 17.399999999999999, new DateTime(2024, 1, 23, 15, 10, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 19.800000000000001, 24, 30.899999999999999, 61.5, new DateTime(2024, 1, 24, 11, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 25.800000000000001, 25, 22.699999999999999, 22.100000000000001, new DateTime(2024, 1, 25, 14, 20, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceData_DeviceId",
                table: "ComplianceData",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DEXScores_DeviceId",
                table: "DEXScores",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SustainabilityData_DeviceId",
                table: "SustainabilityData",
                column: "DeviceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelemetryData_DeviceId",
                table: "TelemetryData",
                column: "DeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplianceData");

            migrationBuilder.DropTable(
                name: "DEXScores");

            migrationBuilder.DropTable(
                name: "SustainabilityData");

            migrationBuilder.DropTable(
                name: "TelemetryData");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
