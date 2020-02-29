using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Motorola" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "Samsung" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Micromax" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Want to try your hand at macro-photography? Want to carry your digital life with you wherever you go? You can do these and a lot more with this phone from Motorola.Powered by a 2.0 GHz AI-capable Octa-core Processor and 4 GB of RAM, this phone can handle any task that you throw at it", "\\Images\\thumbnails\\motorola-one-macro.jpg", "\\Images\\motorola-one-macro.jpg", true, false, "Motorola One Macro", 8999m },
                    { 2, 1, "With 64 GB of ROM, this mobile will offer plenty of space to store all your photos and personal files. You can also expand the storage space up to 512 GB by using a microSD card. To top it off, it has 4GB of RAM to ensure seamless performance.It has a 15.49-cm HD+ screen with 19.5:9 aspect ratio", "\\Images\\thumbnails\\moto-e6s.jpg", "\\Images\\moto-e6s.jpg", true, true, "Moto E6s", 6999m },
                    { 3, 1, "lay games and watch movies for hours without worrying about the battery life in your phone. The Moto X Play comes with a battery life of over 30 hours. Carry it anywhere without any worries, even to the beach. The phone has a water repellent coating that makes it easy to maintain", "\\Images\\thumbnails\\motorola-moto-x-play.jpg", "\\Images\\motorola-moto-x-play.jpg", true, false, "Moto X Play", 17499m },
                    { 4, 2, "Take your mobile experience to next level with the Samsung Galaxy J7 Prime phone. This drool-worthy phone features an attractive design so you can flaunt your style wherever you go, while the quick launch camera lets you capture pictures in seconds.It features a 13 MP rear camera that lets you take beautiful shots even in low-light.", "\\Images\\thumbnails\\samsung-galaxy-j7-prime.jpg", "\\Images\\samsung-galaxy-j7-prime.jpg", true, false, "Samsung Galaxy J7 Prime", 13500m },
                    { 5, 2, "Experience blazing-fast smartphone performance by bringing home this Samsung smartphone. Packed with stunning features, such as a Qualcomm Snapdragon 450 octa-core processor and 3 GB of RAM, this smartphone helps you multitask between several apps like a breeze.On top of that, this handset's stunning 3D prism design ensures that it looks great in your hands.", "\\Images\\thumbnails\\galaxy-a20s-32-a.jpg", "\\Images\\galaxy-a20s-32-a.jpg", true, true, "Samsung Galaxy A20s", 12490m },
                    { 6, 2, "The On Nxt is a performance beast, thanks to the powerful 1.6 GHz, octa-core processor that's aided by an impressive amount of RAM (3 GB). Furthermore, it has 16 GB of internal memory, so you can store loads of photos, videos, apps and more", "\\Images\\thumbnails\\samsung-galaxy-on-nxt.jpg", "\\Images\\samsung-galaxy-on-nxt.jpg", true, true, "Samsung Galaxy On Nxt", 11200m },
                    { 7, 2, "Enjoy long and fun hours of vibrant and immersive viewing experience on the Samsung Galaxy J4 Plus. You can stream your favorite TV shows or videos and watch them in stunning clarity on its 15.26 cm (6) True HD+ Infinity display. This smartphone features a 13 MP rear and 5 MP front camera with front and rear LED Flash", "\\Images\\thumbnails\\samsung-galaxy-j4-plus.jpg", "\\Images\\samsung-galaxy-j4-plus.jpg", true, false, "Samsung Galaxy J4 Plus", 10200m },
                    { 8, 3, "Featuring a slim 8.5 mm body and a 2.5D glass display, with Corning Gorilla Glass 5, the Micromax Canvas 2 is as sturdy as it is sleek. Powered by the Android Nougat 7 operating system, the Canvas 2 offers a seamless performance. With a 1.25 GHz MT6737 quad-core processor and a 3 GB DDR3 RAM, this smartphone is built to perform.", "\\Images\\thumbnails\\micromax-canvas-2.jpg", "\\Images\\micromax-canvas-2.jpg", true, false, "Micromax Canvas 2", 11999m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
