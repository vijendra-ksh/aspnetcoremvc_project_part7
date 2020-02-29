using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
public class AppDbContext:DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
{

}
public DbSet<Product> Products { get; set; }
public DbSet<Category> Categories { get; set; }
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
base.OnModelCreating(modelBuilder);

modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Motorola" });
modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Samsung" });
modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Micromax" });

modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 1,
    Name = "Motorola One Macro",
    Price = 8999M,
    Description = "Want to try your hand at macro-photography? Want to carry your digital life with you wherever you go? You can do these and a lot more with this phone from Motorola.Powered by a 2.0 GHz AI-capable Octa-core Processor and 4 GB of RAM, this phone can handle any task that you throw at it",
    CategoryId = 1,
    ImageUrl = "\\Images\\motorola-one-macro.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\motorola-one-macro.jpg",
    IsInStock = true,
    IsOnSale = false
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 2,
    Name = "Moto E6s",
    Price = 6999M,
    Description = "With 64 GB of ROM, this mobile will offer plenty of space to store all your photos and personal files. You can also expand the storage space up to 512 GB by using a microSD card. To top it off, it has 4GB of RAM to ensure seamless performance.It has a 15.49-cm HD+ screen with 19.5:9 aspect ratio",
    CategoryId = 1,
    ImageUrl = "\\Images\\moto-e6s.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\moto-e6s.jpg",
    IsInStock = true,
    IsOnSale = true
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 3,
    Name = "Moto X Play",
    Price = 17499M,
    Description = "lay games and watch movies for hours without worrying about the battery life in your phone. The Moto X Play comes with a battery life of over 30 hours. Carry it anywhere without any worries, even to the beach. The phone has a water repellent coating that makes it easy to maintain",
    CategoryId = 1,
    ImageUrl = "\\Images\\motorola-moto-x-play.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\motorola-moto-x-play.jpg",
    IsInStock = true,
    IsOnSale = false
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 4,
    Name = "Samsung Galaxy J7 Prime",
    Price = 13500M,
    Description = "Take your mobile experience to next level with the Samsung Galaxy J7 Prime phone. This drool-worthy phone features an attractive design so you can flaunt your style wherever you go, while the quick launch camera lets you capture pictures in seconds.It features a 13 MP rear camera that lets you take beautiful shots even in low-light.",
    CategoryId = 2,
    ImageUrl = "\\Images\\samsung-galaxy-j7-prime.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-j7-prime.jpg",
    IsInStock = true,
    IsOnSale = false
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 5,
    Name = "Samsung Galaxy A20s",
    Price = 12490M,
    Description = "Experience blazing-fast smartphone performance by bringing home this Samsung smartphone. Packed with stunning features, such as a Qualcomm Snapdragon 450 octa-core processor and 3 GB of RAM, this smartphone helps you multitask between several apps like a breeze.On top of that, this handset's stunning 3D prism design ensures that it looks great in your hands.",
    CategoryId = 2,
    ImageUrl = "\\Images\\galaxy-a20s-32-a.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\galaxy-a20s-32-a.jpg",
    IsInStock = true,
    IsOnSale = true
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 6,
    Name = "Samsung Galaxy On Nxt",
    Price = 11200M,
    Description = "The On Nxt is a performance beast, thanks to the powerful 1.6 GHz, octa-core processor that's aided by an impressive amount of RAM (3 GB). Furthermore, it has 16 GB of internal memory, so you can store loads of photos, videos, apps and more",
    CategoryId = 2,
    ImageUrl = "\\Images\\samsung-galaxy-on-nxt.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-on-nxt.jpg",
    IsInStock = true,
    IsOnSale = true
});
           
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 7,
    Name = "Samsung Galaxy J4 Plus",
    Price = 10200M,
    Description = "Enjoy long and fun hours of vibrant and immersive viewing experience on the Samsung Galaxy J4 Plus. You can stream your favorite TV shows or videos and watch them in stunning clarity on its 15.26 cm (6) True HD+ Infinity display. This smartphone features a 13 MP rear and 5 MP front camera with front and rear LED Flash",
    CategoryId = 2,
    ImageUrl = "\\Images\\samsung-galaxy-j4-plus.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\samsung-galaxy-j4-plus.jpg",
    IsInStock = true,
    IsOnSale = false
});
modelBuilder.Entity<Product>().HasData(new Product
{
    ProductId = 8,
    Name = "Micromax Canvas 2",
    Price = 11999M,
    Description = "Featuring a slim 8.5 mm body and a 2.5D glass display, with Corning Gorilla Glass 5, the Micromax Canvas 2 is as sturdy as it is sleek. Powered by the Android Nougat 7 operating system, the Canvas 2 offers a seamless performance. With a 1.25 GHz MT6737 quad-core processor and a 3 GB DDR3 RAM, this smartphone is built to perform.",
    CategoryId = 3,
    ImageUrl = "\\Images\\micromax-canvas-2.jpg",
    ImageThumbnailUrl = "\\Images\\thumbnails\\micromax-canvas-2.jpg",
    IsInStock = true,
    IsOnSale = false
});
           
}
}
}
