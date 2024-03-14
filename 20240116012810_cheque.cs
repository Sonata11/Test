using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendorAPI.Migrations
{
    /// <inheritdoc />
    public partial class cheque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CancelChequeBlobName",
                table: "VendorBlob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CancelChequeBusinessName",
                table: "VendorBlob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CancelChequeNumber",
                table: "VendorBlob",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CancelChequeURL",
                table: "VendorBlob",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelChequeBlobName",
                table: "VendorBlob");

            migrationBuilder.DropColumn(
                name: "CancelChequeBusinessName",
                table: "VendorBlob");

            migrationBuilder.DropColumn(
                name: "CancelChequeNumber",
                table: "VendorBlob");

            migrationBuilder.DropColumn(
                name: "CancelChequeURL",
                table: "VendorBlob");
        }
    }
}
