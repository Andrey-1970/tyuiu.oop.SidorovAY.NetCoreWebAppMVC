using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddParent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Persons",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ParentId",
                table: "Persons",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Persons_ParentId",
                table: "Persons",
                column: "ParentId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Persons_ParentId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ParentId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Persons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
