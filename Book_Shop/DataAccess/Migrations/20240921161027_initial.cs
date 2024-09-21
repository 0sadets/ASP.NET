using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaperPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EBookPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "USA", "Nora", "Sakavic" },
                    { 2, "Ukraine", "Hilarion", "Pavlyuk" },
                    { 3, "USA", "Erin", "Morgenstern" },
                    { 4, "Ukraine", "V.", "Tsybulska" },
                    { 5, "Germany", "Thomas", "Mann" },
                    { 6, "USA", "Ray", "Bradbury" },
                    { 7, "USA", "Harper", "Lee" },
                    { 8, "UK", "Charlotte", "Brontë" },
                    { 9, "Ukraine", "Grigory", "Kvitky-Osnovyanenko" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Novel" },
                    { 2, "Contemporary literature" },
                    { 3, "Young Adult" },
                    { 4, "Mystical Horror" },
                    { 5, "Fantasy" },
                    { 6, "Horror" },
                    { 7, "Southern Gothic Bildungsroman" },
                    { 8, "Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Rivne", "Osadets2004@gmail.com", "Sasha", "Osadets", "+380958325059" },
                    { 2, "Rivne", "Misha2004@gmail.com", "Misha", "Jobs", "+380951234059" },
                    { 3, "Lviv", "levchyk2004@gmail.com", "Olena", "Levchyk", "+380956543219" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "PublisherName" },
                values: new object[,]
                {
                    { 1, "Nora Sakavic" },
                    { 2, "Vivat" },
                    { 3, "KSD" },
                    { 4, "KM-BUKS" },
                    { 5, "Laboratory" },
                    { 6, "Educational book - Bohdan" },
                    { 7, "Old Lion Publishing House" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CategoryID", "Count", "Description", "EBookPrice", "ISBN", "ImagePath", "Language", "NumberOfPages", "PaperPrice", "PublisherId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, 3, 10, "Neil Josten is the newest addition to the Palmetto State University Exy team.", 160m, "1516801512", "https://static.wikia.nocookie.net/aftg/images/6/6a/%D0%9B%D0%B8%D1%81%D1%8C%D1%8F_%D0%BD%D0%BE%D1%80%D0%B0.jpeg/revision/latest?cb=20231119183605&path-prefix=ru", "English", 260, 570m, 1, "The Foxhole Court", 2013 },
                    { 2, 1, 2, 17, "he Foxes are a fractured mess, but their latest disaster might be the miracle they've always needed to come together as a team. The one person standing in their way is Andrew, and the only one who can break through his personal barriers is Neil.", 180m, "978-5-6044581-3-6", "https://fantasy-worlds.org/img/full/338/33893.jpg", "English", 432, 590m, 1, "The Raven King", 2013 },
                    { 3, 1, 3, 13, "He knew when he came to PSU he wouldn't survive the year, but with his death right around the corner he's got more reasons than ever to live. ", 280m, "9786171701090", "https://fantasy-worlds.org/img/full/339/33978.jpg", "English", 448, 650m, 1, "The King's Men", 2014 },
                    { 4, 2, 8, 20, "\"I see you are interested in the dark\" is a story about impenetrable human indifference and the darkness within us", 300m, "9786176798323", "https://static.yakaboo.ua/media/cloudflare/product/webp/600x840/y/a/ya_bachu_vas_cikavytj_pitjma_cover_full.jpg", "Ukrainian", 664, 450m, 7, "I see you are interested in the dark", 2022 },
                    { 5, 6, 6, 24, "Fahrenheit 451 tells the story of Guy Montag and his transformation from a book-burning fireman to a book-reading rebel. ", 160m, "9783060311354", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqDywXlxk7PpGQaNR5B50K-JGw36JBrokCwA&s", "Ukrainian", 272, 570m, 6, "451° Fahrenheit", 1953 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryID",
                table: "Books",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
