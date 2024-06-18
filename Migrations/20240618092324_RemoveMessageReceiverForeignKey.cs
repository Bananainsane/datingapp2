using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMessageReceiverForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.DropForeignKey(
        name: "FK_Messages_UserProfiles_ReceiverId",
        table: "Messages");

    migrationBuilder.DropIndex(
        name: "IX_Messages_ReceiverId",
        table: "Messages");
}


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.CreateIndex(
        name: "IX_Messages_ReceiverId",
        table: "Messages",
        column: "ReceiverId");

    migrationBuilder.AddForeignKey(
        name: "FK_Messages_UserProfiles_ReceiverId",
        table: "Messages",
        column: "ReceiverId",
        principalTable: "UserProfiles",
        principalColumn: "Id",
        onDelete: ReferentialAction.Cascade);
}

    }
}
