using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class RevertRemoveMessageReceiverForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Messages_ReceiverId' AND object_id = OBJECT_ID('Messages'))
            BEGIN
                CREATE INDEX [IX_Messages_ReceiverId] ON [Messages] ([ReceiverId]);
            END
        ");

            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Messages_UserProfiles_ReceiverId')
            BEGIN
                ALTER TABLE [Messages] ADD CONSTRAINT [FK_Messages_UserProfiles_ReceiverId] FOREIGN KEY ([ReceiverId]) REFERENCES [UserProfiles]([Id]) ON DELETE CASCADE;
            END
        ");

            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Messages_SenderId' AND object_id = OBJECT_ID('Messages'))
            BEGIN
                CREATE INDEX [IX_Messages_SenderId] ON [Messages] ([SenderId]);
            END
        ");

            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Messages_UserProfiles_SenderId')
            BEGIN
                ALTER TABLE [Messages] ADD CONSTRAINT [FK_Messages_UserProfiles_SenderId] FOREIGN KEY ([SenderId]) REFERENCES [UserProfiles]([Id]) ON DELETE CASCADE;
            END
        ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Messages_UserProfiles_ReceiverId')
            BEGIN
                ALTER TABLE [Messages] DROP CONSTRAINT [FK_Messages_UserProfiles_ReceiverId];
            END
        ");

            migrationBuilder.Sql(@"
            IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Messages_ReceiverId' AND object_id = OBJECT_ID('Messages'))
            BEGIN
                DROP INDEX [IX_Messages_ReceiverId] ON [Messages];
            END
        ");

            migrationBuilder.Sql(@"
            IF EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Messages_UserProfiles_SenderId')
            BEGIN
                ALTER TABLE [Messages] DROP CONSTRAINT [FK_Messages_UserProfiles_SenderId];
            END
        ");

            migrationBuilder.Sql(@"
            IF EXISTS (SELECT * FROM sys.indexes WHERE name = 'IX_Messages_SenderId' AND object_id = OBJECT_ID('Messages'))
            BEGIN
                DROP INDEX [IX_Messages_SenderId] ON [Messages];
            END
        ");
        }
    }

}