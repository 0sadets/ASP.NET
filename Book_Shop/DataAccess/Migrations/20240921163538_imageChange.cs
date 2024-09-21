using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class imageChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/36/311x480l50nn0/94468796443708.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/37/311x480l50nn0/26706706797137.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/y/a/ya_bachu_vas_cikavytj_pitjma_cover_full.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/37/311x480l50nn0/26706706797137.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://fantasy-worlds.org/img/full/339/33978.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/36/311x480l50nn0/94468796443708.jpeg");
        }
    }
}
