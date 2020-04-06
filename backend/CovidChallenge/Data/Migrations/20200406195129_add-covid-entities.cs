using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CovidChallenge.Data.Migrations
{
    public partial class addcovidentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Areas = table.Column<int>(nullable: false),
                    TimeframeWindow = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    RewardType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserActions",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    GoalId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false),
                    CreationDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserActions", x => new { x.AppUserId, x.GoalId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_AppUserActions_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserActions_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserActions_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRewards",
                columns: table => new
                {
                    AppUserId = table.Column<string>(nullable: false),
                    GoalId = table.Column<Guid>(nullable: false),
                    RewardType = table.Column<int>(nullable: false),
                    AppUserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRewards", x => new { x.AppUserId, x.GoalId });
                    table.ForeignKey(
                        name: "FK_AppUserRewards_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRewards_AspNetUsers_AppUserId1",
                        column: x => x.AppUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppUserRewards_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoalActionRules",
                columns: table => new
                {
                    GoalId = table.Column<Guid>(nullable: false),
                    ActionId = table.Column<Guid>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalActionRules", x => new { x.GoalId, x.ActionId });
                    table.ForeignKey(
                        name: "FK_GoalActionRules_Actions_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Actions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoalActionRules_Goals_GoalId",
                        column: x => x.GoalId,
                        principalTable: "Goals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActions_ActionId",
                table: "AppUserActions",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserActions_GoalId",
                table: "AppUserActions",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRewards_AppUserId1",
                table: "AppUserRewards",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRewards_GoalId",
                table: "AppUserRewards",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_GoalActionRules_ActionId",
                table: "GoalActionRules",
                column: "ActionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserActions");

            migrationBuilder.DropTable(
                name: "AppUserRewards");

            migrationBuilder.DropTable(
                name: "GoalActionRules");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "Goals");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");
        }
    }
}
