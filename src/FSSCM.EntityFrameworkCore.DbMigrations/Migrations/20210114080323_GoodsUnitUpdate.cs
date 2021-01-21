using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSSCM.Migrations
{
    public partial class GoodsUnitUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppGoodsUnits",
                table: "AppGoodsUnits");

            migrationBuilder.AddColumn<Guid>(
                name: "Id1",
                table: "AppGoodsUnits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppGoodsUnits",
                table: "AppGoodsUnits",
                column: "Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppGoodsUnits",
                table: "AppGoodsUnits");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "AppGoodsUnits");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppGoodsUnits",
                table: "AppGoodsUnits",
                column: "Id");
        }
    }
}
