using BetterBuys.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterBuys.Data
{
    public class StoreDbSeeder
    {
        public static async Task SeedAsync(StoreDbContext db)
        {
            if (!await db.Categories.AnyAsync())
            {
                await db.Categories.AddRangeAsync(GetPreconfiguredCategories());
                await db.SaveChangesAsync();
            }

            if (!await db.Products.AnyAsync())
            {
                await db.Products.AddRangeAsync(GetPreconfiguredProducts());
                await db.SaveChangesAsync();
            }

            if(!await db.ProductCategories.AnyAsync())
            {
                await db.ProductCategories.AddRangeAsync(GetPreconfiguredProductCategories());
                await db.SaveChangesAsync();
            }
        }

        static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>
            {
                new Product(".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5m,  "/images/products/1.png"),
                new Product(".NET Black & White Mug", ".NET Black & White Mug", 8.50m, "/images/products/2.png"),
                new Product("Prism White T-Shirt", "Prism White T-Shirt", 12m,  "/images/products/3.png"),
                new Product(".NET Foundation Sweatshirt", ".NET Foundation Sweatshirt", 12m, "/images/products/4.png"),
                new Product("Roslyn Red Sheet", "Roslyn Red Sheet", 8.5m, "/images/products/5.png"),
                new Product(".NET Blue Sweatshirt", ".NET Blue Sweatshirt", 12m, "/images/products/6.png"),
                new Product("Roslyn Red T-Shirt", "Roslyn Red T-Shirt",  12m, "/images/products/7.png"),
                new Product("Kudu Purple Sweatshirt", "Kudu Purple Sweatshirt", 8.5m, "/images/products/8.png"),
                new Product("Cup<T> White Mug", "Cup<T> White Mug", 12m, "/images/products/9.png"),
                new Product(".NET Foundation Sheet", ".NET Foundation Sheet", 12m, "/images/products/10.png"),
                new Product("Cup<T> Sheet", "Cup<T> Sheet", 8.5m, "/images/products/11.png"),
                new Product("Prism White TShirt", "Prism White TShirt", 12m, "/images/products/12.png"),
                new Product("HP 17.3 inches Laptop", "【17.3 HD+ Touchscreen WLED-backlit】Reach out and control your PC with just a touch. Being able to pinch, zoom, tap, and swipe right from the screen makes interacting with your computer a totally intuitive experience.【10th Gen Intel Core i5-1035G1 Processor】1.0 GHz base frequency, up to 3.6 GHz with Intel Turbo Boost Technology, 6 MB L3 cache, 4 cores. Smart quad-core, eight-way processing performance. Intel Turbo Boost Technology delivers dynamic extra power when you need it, while increasing energy efficiency when you don't.【Upgraded to 16GB DDR4 RAM】Substantial high-bandwidth RAM to smoothly run your games and photo-and video - editing applications, as well as multiple programs and browser tabs all at once.【512GB PCIe SSD】Provides massive storage space for huge files, so that you can store important digital data and work your way through it with ease.It gives you enormous space to save all of your files.【Fast charge & GM Accessorise】Go from 0 to 50 % charge in approximately 45 minutes.Ghost Manta Accessories Included 1x HDMI Cable, 1x USB extension cord, 1x Mouse Pad.",899.99m, "https://m.media-amazon.com/images/I/71OUSmMg6SL._AC_UY218_.jpg"),
                new Product("HP 14 inches Laptop", "Latest and Powerful Intel Celeron Processor 4205U (2MB Cache, 1.8 GHz) Dual-Core, Eight-way processing provides Maximum high-efficiency power to go. Integrated Radeon R4 Graphics with shared graphics memory provide everyday image quality for Internet use.|15.6-inch HD (1366 x 768) Anti-Glare LED-Backlit Non-touch Display, detailed picture Stunning screen delivers a clear, bright image that's easy on the eyes. Natural finger-touch navigation and screen makes the most of Windows 10|Ram is upgraded to 12GB DDR4 Memory for fast processing and advanced multitasking, Hard Drive is upgraded to 256GB PCIe Solid State Drive for delivering fast start - up time and data access.SSD works much faster than HDD.So it will improve the whole performance of a PC computer.System also comes with a 1TB HDD for plenty of storage room.|Qualcomm DW1810, 1 x 1, 802.11ac with Wi - Fi, Wireless LAN, Bluetooth 4.1, Media Card Reader | HDMI | 2 x USB 3.1 | 1 x USB 2.0 | Headphone / Mic|Windows 10 Professional 64 - bit English, the Best version of Windows OS and Great for Business users. 802.11ac Wifi and Bluetooth 3 - Cell 42WHr Battery, PCS Store 32GB USB Drive: Authorized Seller only",499.99m, "https://m.media-amazon.com/images/I/81zk8DWAxmL._AC_UY218_.jpg"),
                new Product("Acer Aspire 15.6 inches Laptop", "Acer Aspire 5 Slim Laptop, 15.6 inches Full HD IPS Display, AMD Ryzen 3 3200U, Vega 3 Graphics, 4GB DDR4, 128GB SSD",488m, "https://m.media-amazon.com/images/I/71vvXGmdKWL._AC_UY218_.jpg"),
                new Product("Lenovo IdeaPad 14 inches Laptop", "Lenovo IdeaPad 3 14 Laptop, 14.0 FHD 1920 x 1080 Display, AMD Ryzen 5 3500U Processor, 8GB DDR4 RAM, 256GB SSD",419.55m, "https://m.media-amazon.com/images/I/71dqjxW8g5L._AC_UY218_.jpg"),
                new Product("HP 14 inch Laptop", "2020 Newest HP 14 HD Laptop for Business and Student, AMD Ryzen 3 3250U Processor(up to 3.5 GHz), 8GB RAM",499.99m, "https://m.media-amazon.com/images/I/81zk8DWAxmL._AC_UY218_.jpg"),
                new Product("HP 14 inch Laptop", "2020 Newest HP 14 HD Laptop for Business and Student, AMD Ryzen 3 3250U Processor(up to 3.5 GHz), 8GB RAM",499.99m, "https://m.media-amazon.com/images/I/81zk8DWAxmL._AC_UY218_.jpg"),
                new Product("HP 14 inch Laptop", "2020 Newest HP 14 HD Laptop for Business and Student, AMD Ryzen 3 3250U Processor(up to 3.5 GHz), 8GB RAM",499.99m, "https://m.media-amazon.com/images/I/81zk8DWAxmL._AC_UY218_.jpg"),
                new Product("HP 14 inch Laptop", "2020 Newest HP 14 HD Laptop for Business and Student, AMD Ryzen 3 3250U Processor(up to 3.5 GHz), 8GB RAM",499.99m, "https://m.media-amazon.com/images/I/71k45hZkLmL._AC_UY218_.jpg"),
                new Product("HP Chromebook 14", "Google Play Store: The millions of Android apps you know and love on your phone and tablet can now run on your Chrome device without compromising their speed, simplicity or security.|Sleek, responsive design: Keep going comfortably with the backlit keyboard and multi-touch touchpad that supports four finger gestures set in a sleek design for moving from room to room or on the road.|Binge watch while you work: Equipped with an Intel(R) processor, 14 display, stereo speakers tuned by audio experts at B&O and a long battery life to get more done while having fun.|Environmentally conscious: Low halogen, mercury-free display backlights, arsenic-free display glass in this ENERGY STAR(R) certified, EPEAT(R) Silver registered Chromebook.}Dual - core Intel(R) processor: Intel(R) Celeron(R) N4000, Dual - Core, 1.1 GHz base frequency, up to 2.6 GHz burst frequency.|Display: 14.0 - inch diagonal FHD IPS anti-glare micro - edge WLED - backlit display(1920 x 1080); 82 % screen to body ratio.|Memory & storage: 4 GB LPDDR4-2400 SDRAM(not upgradable) and 32 GB eMMC",292.99m, "https://m.media-amazon.com/images/I/91shKLxoedL._AC_UY218_.jpg"),
                new Product("HP Stream 14-inch Laptop", "【14 Non-touch HD Display】14.0-inch diagonal, HD (1366 x 768), micro-edge, BrightView, 220 nits, 45% NTSC, 79% Screen to body ratio. Integrated Intel UHD Graphics 600.【Intel Dual-Core Celeron N4020】Intel Dual-Core Celeron N4020 (1.1 GHz base frequency, up to 2.8 GHz burst frequency, 4 MB L2 Cache). 【4GB RAM and 64GB SSD】4 GB DDR4-2400 SDRAM (1 x 4 GB), Memory slot not user accessible, 64 GB eMMC SSD, Full-size keyboard without number pad, HP Imagepad with multi-touch gesture support, Optical drive not included.【Connectivity】Realtek RTL8822CE 802.11a/b/g/n/ac (2x2) Wi-Fi and Bluetooth 5.0 combo; 1 microSD media card reader; 1 SuperSpeed USB Type - C 5Gbps signaling rate; 2 SuperSpeed USB Type - A 5Gbps signaling rate; 1 HDMI 1.4b; 1 AC Smart pin; 1 Headphone / microphone combo; HP True Vision 720p HD camera with integrated dual array digital microphones.【Operating System and Ports】Windows 10 Home in S mode 64 - bit, English(Free upgrade to Windows 10 Home); Office 365 Personal for 1 Year; 3 - cell, 41 Wh Li - ion battery ; Up to 9 hours(wireless streaming).【Authorized Oydisen Bundle】Bundled with Oydisen Cloth, Authorized Sellers ONLY",319.99m, "https://m.media-amazon.com/images/I/61Gqm59K62L._AC_UY218_.jpg"),
                new Product("HP 15.6 inch Laptop", "【15.6 Full HD IPS Touchscreen】IPS WLED-backlit multitouch-enabled edge-to-edge glass (1920 x 1080). Reach out and control your PC with just a touch. With its thin and light design, 6.5 mm micro-edge bezel display, and 82% screen to body ratio.【10th Gen Intel Core i5-1035G1】Smart quad-core, eight-way processing performance. Intel Turbo Boost Technology delivers dynamic extra power when you need it, while increasing energy efficiency when you don't.【Upgraded to 16GB DDR4 RAM】Substantial high-bandwidth RAM to smoothly run your games and photo-and video - editing applications, as well as multiple programs and browser tabs all at once.【Upgraded storage to 512GB SSD】Provides massive storage space for huge files, so that you can store important digital data and work your way through it with ease.It gives you enormous space to save all of your files.【Fast charge】With a long battery life and fast - charge technology, this laptop lets you work, watch, and stay connected all day.An integrated precision touchpad with multi - touch support speeds up both navigation and productivity.",749.99m, "https://m.media-amazon.com/images/I/71Ni8QtU7DL._AC_UY218_.jpg"),
                new Product("Dell Inspiron 15.6 Laptop", "Latest and Powerful Intel Celeron Processor 4205U (2MB Cache, 1.8 GHz) Dual-Core, Eight-way processing provides Maximum high-efficiency power to go. Integrated Radeon R4 Graphics with shared graphics memory provide everyday image quality for Internet use.|15.6-inch HD (1366 x 768) Anti-Glare LED-Backlit Non-touch Display, detailed picture Stunning screen delivers a clear, bright image that's easy on the eyes. Natural finger-touch navigation and screen makes the most of Windows 10|Ram is upgraded to 12GB DDR4 Memory for fast processing and advanced multitasking, Hard Drive is upgraded to 256GB PCIe Solid State Drive for delivering fast start - up time and data access.SSD works much faster than HDD.So it will improve the whole performance of a PC computer.System also comes with a 1TB HDD for plenty of storage room.|Qualcomm DW1810, 1 x 1, 802.11ac with Wi - Fi, Wireless LAN, Bluetooth 4.1, Media Card Reader | HDMI | 2 x USB 3.1 | 1 x USB 2.0 | Headphone / Mic|Windows 10 Professional 64 - bit English, the Best version of Windows OS and Great for Business users. 802.11ac Wifi and Bluetooth 3 - Cell 42WHr Battery, PCS Store 32GB USB Drive: Authorized Seller only",649.99m, "https://m.media-amazon.com/images/I/51rjrBJXoAL._AC_UY218_.jpg"),

            };
        }

        static IEnumerable<Category> GetPreconfiguredCategories()
        {
            return new List<Category>
            {
                new Category("Mug"),
                new Category("T-Shirt"),
                new Category("Sheet"),
                new Category("USB Memory Stick")
            };
        }

        static IEnumerable<ProductCategory> GetPreconfiguredProductCategories()
        {
            return new List<ProductCategory>
            {
                new ProductCategory(2,1),
                new ProductCategory(1,2),
                new ProductCategory(2,3),
                new ProductCategory(2,4),
                new ProductCategory(3,5),
                new ProductCategory(2,6),
                new ProductCategory(2,7),
                new ProductCategory(2,8),
                new ProductCategory(1,9),
                new ProductCategory(3,10),
                new ProductCategory(3,11),
                new ProductCategory(2,12)
            };
        }
    }
}
