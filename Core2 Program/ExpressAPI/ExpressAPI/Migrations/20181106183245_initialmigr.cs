using Microsoft.EntityFrameworkCore.Migrations;

namespace ExpressAPI.Migrations
{
    public partial class initialmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDTOs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    PersonTitle = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    CareOfName = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    CityName = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CustomerType = table.Column<string>(nullable: true),
                    IkeaFamilyNumber = table.Column<string>(nullable: true),
                    TaxRegNo = table.Column<string>(nullable: true),
                    TaxIdType = table.Column<string>(nullable: true),
                    OrganisationNumber = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    TelephoneHome = table.Column<string>(nullable: true),
                    TelephoneWork = table.Column<string>(nullable: true),
                    TelephoneMobile = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IdentityType = table.Column<string>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    PreferedLanguage = table.Column<string>(nullable: true),
                    ContactType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDTOs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReturnHeadDTOs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    BuCode = table.Column<string>(nullable: true),
                    TillNumber = table.Column<string>(nullable: true),
                    TransactionNumber = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnHeadDTOs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReturnHeadDTOs_CustomerDTOs_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDTOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineDTOs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ItemId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ReasonCode = table.Column<string>(nullable: true),
                    SubReasonCode = table.Column<string>(nullable: true),
                    ReturnHeadId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineDTOs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineDTOs_ReturnHeadDTOs_ReturnHeadId",
                        column: x => x.ReturnHeadId,
                        principalTable: "ReturnHeadDTOs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineDTOs_ReturnHeadId",
                table: "LineDTOs",
                column: "ReturnHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnHeadDTOs_CustomerId",
                table: "ReturnHeadDTOs",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineDTOs");

            migrationBuilder.DropTable(
                name: "ReturnHeadDTOs");

            migrationBuilder.DropTable(
                name: "CustomerDTOs");
        }
    }
}
