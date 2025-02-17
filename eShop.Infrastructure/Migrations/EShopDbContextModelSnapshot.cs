﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShop.Infrastructure.Context;

#nullable disable

namespace eShop.Infrastructure.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    partial class EShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eShop.Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDateUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                            ImageUrl = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                            Price = 109.95m,
                            Title = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 2,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.",
                            ImageUrl = "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg",
                            Price = 22.3m,
                            Title = "Mens Casual Premium Slim Fit T-Shirts ",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 3,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                            ImageUrl = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                            Price = 55.99m,
                            Title = "Mens Cotton Jacket",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 4,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                            ImageUrl = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                            Price = 15.99m,
                            Title = "Mens Casual Slim Fit",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 5,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.",
                            ImageUrl = "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg",
                            Price = 695m,
                            Title = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 6,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.",
                            ImageUrl = "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg",
                            Price = 168m,
                            Title = "Solid Gold Petite Micropave ",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 7,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...",
                            ImageUrl = "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg",
                            Price = 9.99m,
                            Title = "White Gold Plated Princess",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 8,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel",
                            ImageUrl = "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg",
                            Price = 10.99m,
                            Title = "Pierced Owl Rose Gold Plated Stainless Steel Double",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 9,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatibility Formatted NTFS for Windows 10, Windows 8.1, Windows 7; Reformatting may be required for other operating systems; Compatibility may vary depending on user’s hardware configuration and operating system",
                            ImageUrl = "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg",
                            Price = 64m,
                            Title = "WD 2TB Elements Portable External Hard Drive - USB 3.0 ",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 10,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Easy upgrade for faster boot up, shutdown, application load and response (As compared to 5400 RPM SATA 2.5” hard drive; Based on published specifications and internal benchmarking tests using PCMark vantage scores) Boosts burst write performance, making it ideal for typical PC workloads The perfect balance of performance and reliability Read/write speeds of up to 535MB/s/450MB/s (Based on internal testing; Performance may vary depending upon drive capacity, host device, OS and application.)",
                            ImageUrl = "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg",
                            Price = 109m,
                            Title = "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 11,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. The advanced SLC Cache Technology allows performance boost and longer lifespan 7mm slim design suitable for Ultrabooks and Ultra-slim notebooks. Supports TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.",
                            ImageUrl = "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg",
                            Price = 109m,
                            Title = "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 12,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty",
                            ImageUrl = "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg",
                            Price = 114m,
                            Title = "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 13,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount Refresh Rate: 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Aspect ratio - 16: 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle-178 degree. Vertical viewing angle-178 degree 75 hertz",
                            ImageUrl = "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg",
                            Price = 599m,
                            Title = "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 14,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen side by side QUANTUM DOT (QLED) TECHNOLOGY, HDR support and factory calibration provides stunningly realistic and accurate color and contrast 144HZ HIGH REFRESH RATE and 1ms ultra fast response time work to eliminate motion blur, ghosting, and reduce input lag",
                            ImageUrl = "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg",
                            Price = 999.99m,
                            Title = "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED ",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 15,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Note:The Jackets is US standard size, Please choose size as your usual wear Material: 100% Polyester; Detachable Liner Fabric: Warm Fleece. Detachable Functional Liner: Skin Friendly, Lightweigt and Warm.Stand Collar Liner jacket, keep you warm in cold weather. Zippered Pockets: 2 Zippered Hand Pockets, 2 Zippered Pockets on Chest (enough to keep cards or keys)and 1 Hidden Pocket Inside.Zippered Hand Pockets and Hidden Pocket keep your things secure. Humanized Design: Adjustable and Detachable Hood and Adjustable cuff to prevent the wind and water,for a comfortable fit. 3 in 1 Detachable Design provide more convenience, you can separate the coat and inner as needed, or wear it together. It is suitable for different season and help you adapt to different climates",
                            ImageUrl = "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg",
                            Price = 56.99m,
                            Title = "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 16,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER), Faux leather material for style and comfort / 2 pockets of front, 2-For-One Hooded denim style faux leather jacket, Button detail on waist / Detail stitching at sides, HAND WASH ONLY / DO NOT BLEACH / LINE DRY / DO NOT IRON",
                            ImageUrl = "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg",
                            Price = 29.95m,
                            Title = "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 17,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design. Button and zipper front closure raincoat, fully stripes Lined and The Raincoat has 2 side pockets are a good size to hold all kinds of things, it covers the hips, and the hood is generous but doesn't overdo it.Attached Cotton Lined Hood with Adjustable Drawstrings give it a real styled look.",
                            ImageUrl = "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg",
                            Price = 39.99m,
                            Title = "Rain Jacket Women Windbreaker Striped Climbing Raincoats",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 18,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "95% RAYON 5% SPANDEX, Made in USA or Imported, Do Not Bleach, Lightweight fabric with great stretch for comfort, Ribbed on sleeves and neckline / Double stitching on bottom hem",
                            ImageUrl = "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg",
                            Price = 9.85m,
                            Title = "MBJ Women's Solid Short Sleeve Boat Neck V ",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 19,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "100% Polyester, Machine wash, 100% cationic polyester interlock, Machine Wash & Pre Shrunk for a Great Fit, Lightweight, roomy and highly breathable with moisture wicking fabric which helps to keep moisture away, Soft Lightweight Fabric with comfortable V-neck collar and a slimmer fit, delivers a sleek, more feminine silhouette and Added Comfort",
                            ImageUrl = "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg",
                            Price = 7.95m,
                            Title = "Opna Women's Short Sleeve Moisture",
                            UpdatedBy = 0
                        },
                        new
                        {
                            Id = 20,
                            CreateDateUtc = new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = 0,
                            Description = "95%Cotton,5%Spandex, Features: Casual, Short Sleeve, Letter Print,V-Neck,Fashion Tees, The fabric is soft and has some stretch., Occasion: Casual/Office/Beach/School/Home/Street. Season: Spring,Summer,Autumn,Winter.",
                            ImageUrl = "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg",
                            Price = 12.99m,
                            Title = "DANVOUY Womens T Shirt Casual Cotton Short",
                            UpdatedBy = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
