using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/35/311x480l50nn0/49283594893207.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/37/311x480l50nn0/26706706797137.jpeg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://yabooks.com.ua/content/images/36/311x480l50nn0/94468796443708.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://static.wikia.nocookie.net/aftg/images/6/6a/%D0%9B%D0%B8%D1%81%D1%8C%D1%8F_%D0%BD%D0%BE%D1%80%D0%B0.jpeg/revision/latest?cb=20231119183605&path-prefix=ru");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://fantasy-worlds.org/img/full/338/33893.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/y/a/ya_bachu_vas_cikavytj_pitjma_cover_full.jpg");
        }
    }
}
