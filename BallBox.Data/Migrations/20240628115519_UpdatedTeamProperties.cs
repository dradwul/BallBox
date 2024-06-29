using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BallBox.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTeamProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RedCard",
                table: "MatchStats",
                newName: "RedCards");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryColor",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryColor",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Corners",
                table: "MatchStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Freekicks",
                table: "MatchStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryColor",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SecondaryColor",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "Corners",
                table: "MatchStats");

            migrationBuilder.DropColumn(
                name: "Freekicks",
                table: "MatchStats");

            migrationBuilder.RenameColumn(
                name: "RedCards",
                table: "MatchStats",
                newName: "RedCard");
        }
    }
}
