using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameDiary.Dao.Migrations
{
    /// <inheritdoc />
    public partial class PublisherKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePublisherEntities_Publishers_GameId",
                table: "GamePublisherEntities");

            migrationBuilder.CreateIndex(
                name: "IX_GamePublisherEntities_PublisherId",
                table: "GamePublisherEntities",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePublisherEntities_Publishers_PublisherId",
                table: "GamePublisherEntities",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamePublisherEntities_Publishers_PublisherId",
                table: "GamePublisherEntities");

            migrationBuilder.DropIndex(
                name: "IX_GamePublisherEntities_PublisherId",
                table: "GamePublisherEntities");

            migrationBuilder.AddForeignKey(
                name: "FK_GamePublisherEntities_Publishers_GameId",
                table: "GamePublisherEntities",
                column: "GameId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
