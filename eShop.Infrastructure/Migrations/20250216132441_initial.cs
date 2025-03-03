﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eShop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDateUtc", "CreatedBy", "Description", "ImageUrl", "Price", "Title", "UpdatedBy", "UpdatedDateUtc" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday", "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg", 109.95m, "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops", 0, null },
                    { 2, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Slim-fitting style, contrast raglan long sleeve, three-button henley placket, light weight & soft fabric for breathable and comfortable wearing. And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans. The Henley style round neckline includes a three-button placket.", "https://fakestoreapi.com/img/71-3HjGNDUL._AC_SY879._SX._UX._SY._UY_.jpg", 22.3m, "Mens Casual Premium Slim Fit T-Shirts ", 0, null },
                    { 3, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "great outerwear jackets for Spring/Autumn/Winter, suitable for many occasions, such as working, hiking, camping, mountain/rock climbing, cycling, traveling or other outdoors. Good gift choice for you or your family member. A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.", "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg", 55.99m, "Mens Cotton Jacket", 0, null },
                    { 4, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.", "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg", 15.99m, "Mens Casual Slim Fit", 0, null },
                    { 5, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.", "https://fakestoreapi.com/img/71pWzhdJNwL._AC_UL640_QL65_ML3_.jpg", 695m, "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet", 0, null },
                    { 6, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Satisfaction Guaranteed. Return or exchange any order within 30 days.Designed and sold by Hafeez Center in the United States. Satisfaction Guaranteed. Return or exchange any order within 30 days.", "https://fakestoreapi.com/img/61sbMiUnoGL._AC_UL640_QL65_ML3_.jpg", 168m, "Solid Gold Petite Micropave ", 0, null },
                    { 7, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Classic Created Wedding Engagement Solitaire Diamond Promise Ring for Her. Gifts to spoil your love more for Engagement, Wedding, Anniversary, Valentine's Day...", "https://fakestoreapi.com/img/71YAIFU48IL._AC_UL640_QL65_ML3_.jpg", 9.99m, "White Gold Plated Princess", 0, null },
                    { 8, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Rose Gold Plated Double Flared Tunnel Plug Earrings. Made of 316L Stainless Steel", "https://fakestoreapi.com/img/51UDEzMJVpL._AC_UL640_QL65_ML3_.jpg", 10.99m, "Pierced Owl Rose Gold Plated Stainless Steel Double", 0, null },
                    { 9, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "USB 3.0 and USB 2.0 Compatibility Fast data transfers Improve PC Performance High Capacity; Compatibility Formatted NTFS for Windows 10, Windows 8.1, Windows 7; Reformatting may be required for other operating systems; Compatibility may vary depending on user’s hardware configuration and operating system", "https://fakestoreapi.com/img/61IBBVJvSDL._AC_SY879_.jpg", 64m, "WD 2TB Elements Portable External Hard Drive - USB 3.0 ", 0, null },
                    { 10, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Easy upgrade for faster boot up, shutdown, application load and response (As compared to 5400 RPM SATA 2.5” hard drive; Based on published specifications and internal benchmarking tests using PCMark vantage scores) Boosts burst write performance, making it ideal for typical PC workloads The perfect balance of performance and reliability Read/write speeds of up to 535MB/s/450MB/s (Based on internal testing; Performance may vary depending upon drive capacity, host device, OS and application.)", "https://fakestoreapi.com/img/61U7T1koQqL._AC_SX679_.jpg", 109m, "SanDisk SSD PLUS 1TB Internal SSD - SATA III 6 Gb/s", 0, null },
                    { 11, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "3D NAND flash are applied to deliver high transfer speeds Remarkable transfer speeds that enable faster bootup and improved overall system performance. The advanced SLC Cache Technology allows performance boost and longer lifespan 7mm slim design suitable for Ultrabooks and Ultra-slim notebooks. Supports TRIM command, Garbage Collection technology, RAID, and ECC (Error Checking & Correction) to provide the optimized performance and enhanced reliability.", "https://fakestoreapi.com/img/71kWymZ+c+L._AC_SX679_.jpg", 109m, "Silicon Power 256GB SSD 3D NAND A55 SLC Cache Performance Boost SATA III 2.5", 0, null },
                    { 12, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Expand your PS4 gaming experience, Play anywhere Fast and easy, setup Sleek design with high capacity, 3-year manufacturer's limited warranty", "https://fakestoreapi.com/img/61mtL65D4cL._AC_SX679_.jpg", 114m, "WD 4TB Gaming Drive Works with Playstation 4 Portable External Hard Drive", 0, null },
                    { 13, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "21. 5 inches Full HD (1920 x 1080) widescreen IPS display And Radeon free Sync technology. No compatibility for VESA Mount Refresh Rate: 75Hz - Using HDMI port Zero-frame design | ultra-thin | 4ms response time | IPS panel Aspect ratio - 16: 9. Color Supported - 16. 7 million colors. Brightness - 250 nit Tilt angle -5 degree to 15 degree. Horizontal viewing angle-178 degree. Vertical viewing angle-178 degree 75 hertz", "https://fakestoreapi.com/img/81QpkIctqPL._AC_SX679_.jpg", 599m, "Acer SB220Q bi 21.5 inches Full HD (1920 x 1080) IPS Ultra-Thin", 0, null },
                    { 14, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "49 INCH SUPER ULTRAWIDE 32:9 CURVED GAMING MONITOR with dual 27 inch screen side by side QUANTUM DOT (QLED) TECHNOLOGY, HDR support and factory calibration provides stunningly realistic and accurate color and contrast 144HZ HIGH REFRESH RATE and 1ms ultra fast response time work to eliminate motion blur, ghosting, and reduce input lag", "https://fakestoreapi.com/img/81Zt42ioCgL._AC_SX679_.jpg", 999.99m, "Samsung 49-Inch CHG90 144Hz Curved Gaming Monitor (LC49HG90DMNXZA) – Super Ultrawide Screen QLED ", 0, null },
                    { 15, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Note:The Jackets is US standard size, Please choose size as your usual wear Material: 100% Polyester; Detachable Liner Fabric: Warm Fleece. Detachable Functional Liner: Skin Friendly, Lightweigt and Warm.Stand Collar Liner jacket, keep you warm in cold weather. Zippered Pockets: 2 Zippered Hand Pockets, 2 Zippered Pockets on Chest (enough to keep cards or keys)and 1 Hidden Pocket Inside.Zippered Hand Pockets and Hidden Pocket keep your things secure. Humanized Design: Adjustable and Detachable Hood and Adjustable cuff to prevent the wind and water,for a comfortable fit. 3 in 1 Detachable Design provide more convenience, you can separate the coat and inner as needed, or wear it together. It is suitable for different season and help you adapt to different climates", "https://fakestoreapi.com/img/51Y5NI-I5jL._AC_UX679_.jpg", 56.99m, "BIYLACLESEN Women's 3-in-1 Snowboard Jacket Winter Coats", 0, null },
                    { 16, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "100% POLYURETHANE(shell) 100% POLYESTER(lining) 75% POLYESTER 25% COTTON (SWEATER), Faux leather material for style and comfort / 2 pockets of front, 2-For-One Hooded denim style faux leather jacket, Button detail on waist / Detail stitching at sides, HAND WASH ONLY / DO NOT BLEACH / LINE DRY / DO NOT IRON", "https://fakestoreapi.com/img/81XH0e8fefL._AC_UY879_.jpg", 29.95m, "Lock and Love Women's Removable Hooded Faux Leather Moto Biker Jacket", 0, null },
                    { 17, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Lightweight perfet for trip or casual wear---Long sleeve with hooded, adjustable drawstring waist design. Button and zipper front closure raincoat, fully stripes Lined and The Raincoat has 2 side pockets are a good size to hold all kinds of things, it covers the hips, and the hood is generous but doesn't overdo it.Attached Cotton Lined Hood with Adjustable Drawstrings give it a real styled look.", "https://fakestoreapi.com/img/71HblAHs5xL._AC_UY879_-2.jpg", 39.99m, "Rain Jacket Women Windbreaker Striped Climbing Raincoats", 0, null },
                    { 18, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "95% RAYON 5% SPANDEX, Made in USA or Imported, Do Not Bleach, Lightweight fabric with great stretch for comfort, Ribbed on sleeves and neckline / Double stitching on bottom hem", "https://fakestoreapi.com/img/71z3kpMAYsL._AC_UY879_.jpg", 9.85m, "MBJ Women's Solid Short Sleeve Boat Neck V ", 0, null },
                    { 19, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "100% Polyester, Machine wash, 100% cationic polyester interlock, Machine Wash & Pre Shrunk for a Great Fit, Lightweight, roomy and highly breathable with moisture wicking fabric which helps to keep moisture away, Soft Lightweight Fabric with comfortable V-neck collar and a slimmer fit, delivers a sleek, more feminine silhouette and Added Comfort", "https://fakestoreapi.com/img/51eg55uWmdL._AC_UX679_.jpg", 7.95m, "Opna Women's Short Sleeve Moisture", 0, null },
                    { 20, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "95%Cotton,5%Spandex, Features: Casual, Short Sleeve, Letter Print,V-Neck,Fashion Tees, The fabric is soft and has some stretch., Occasion: Casual/Office/Beach/School/Home/Street. Season: Spring,Summer,Autumn,Winter.", "https://fakestoreapi.com/img/61pHAEJ4NML._AC_UX679_.jpg", 12.99m, "DANVOUY Womens T Shirt Casual Cotton Short", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
