using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingToolWebAPI.Migrations
{
    public partial class Initiallll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_AppUserId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_AppUserId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "TreatmentID",
                table: "Bookings",
                newName: "TreatmentId");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "Treatments",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Bookings",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_BookingId",
                table: "Treatments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserID",
                table: "Bookings",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserID",
                table: "Bookings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Bookings_BookingId",
                table: "Treatments",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Bookings_BookingId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_BookingId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_UserID",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Treatments");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "Bookings",
                newName: "TreatmentID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Bookings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_AppUserId",
                table: "Bookings",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_AppUserId",
                table: "Bookings",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
