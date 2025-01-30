using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoMekanik.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove or comment out this line since the column doesn't exist in the database.
            // migrationBuilder.DropColumn(
            //     name: "UserId",
            //     table: "Bookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // If you don't plan to reintroduce the UserId column in the future, 
            // you can safely leave this empty or remove the Down method entirely.
        }
    }
}
