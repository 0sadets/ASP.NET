using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Authors",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://knigogo.top/wp-content/uploads/2023/01/Nora-Sakavic-237x308.jpg");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://forbes.ua/static/storage/thumbs/414x671/5/1f/7f751b94-b3bb5c9efa73b215c208131abc3a41f5.jpg?v=4355_2");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://mybookshelf.com.ua/files/Erin.jpg");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "https://static.yakaboo.ua/media/entity/author/1/_/1_5_2.jpg");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeCIh-DgHkRN6kF01iw5EVC7AMAR8PFbUeNg&s");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8pdhxKYlV1EYfjGfTf9P-EpF2LGQn8Ev2pg&s");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePath",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRtdV2etWBDVg4tdHyaCERfMZNqmPTUMNhJMQ&s");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePath",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg/800px-%D0%9A%D0%B2%D1%96%D1%82%D0%BA%D0%B0-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%27%D1%8F%D0%BD%D0%B5%D0%BD%D0%BA%D0%BE.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Authors");
        }
    }
}
