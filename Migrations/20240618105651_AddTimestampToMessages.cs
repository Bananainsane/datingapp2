using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampToMessages : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<DateTime>(
            name: "Timestamp",
            table: "Messages",
            nullable: false,
            defaultValueSql: "GETDATE()"); // This sets the default value to the current date and time

        // If you want to update the existing records with a specific timestamp, you can run a custom SQL command here
        // Example: migrationBuilder.Sql("UPDATE Messages SET Timestamp = '2023-06-01 00:00:00' WHERE Timestamp IS NULL");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Timestamp",
            table: "Messages");
    }
}

}
