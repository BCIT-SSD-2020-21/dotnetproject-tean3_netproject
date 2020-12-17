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

            if (!await db.ProductCategories.AnyAsync())
            {
                await db.ProductCategories.AddRangeAsync(GetPreconfiguredProductCategories());
                await db.SaveChangesAsync();
            }
        }

        static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>
            {
                //new Product(".NET Bot Black Sweatshirt", ".NET Bot Black Sweatshirt", 19.5m,  "/images/products/1.png"),
                //new Product(".NET Black & White Mug", ".NET Black & White Mug", 8.50m, "/images/products/2.png"),
                //new Product("Prism White T-Shirt", "Prism White T-Shirt", 12m,  "/images/products/3.png"),
                //new Product(".NET Foundation Sweatshirt", ".NET Foundation Sweatshirt", 12m, "/images/products/4.png"),
                //new Product("Roslyn Red Sheet", "Roslyn Red Sheet", 8.5m, "/images/products/5.png"),
                //new Product(".NET Blue Sweatshirt", ".NET Blue Sweatshirt", 12m, "/images/products/6.png"),
                //new Product("Roslyn Red T-Shirt", "Roslyn Red T-Shirt",  12m, "/images/products/7.png"),
                //new Product("Kudu Purple Sweatshirt", "Kudu Purple Sweatshirt", 8.5m, "/images/products/8.png"),
                //new Product("Cup<T> White Mug", "Cup<T> White Mug", 12m, "/images/products/9.png"),
                //new Product(".NET Foundation Sheet", ".NET Foundation Sheet", 12m, "/images/products/10.png"),
                //new Product("Cup<T> Sheet", "Cup<T> Sheet", 8.5m, "/images/products/11.png"),
                //new Product("Prism White TShirt", "Prism White TShirt", 12m, "/images/products/12.png"),
                new Product("HP 17.3 inches Laptop", "<li>【17.3 HD+ Touchscreen WLED-backlit】Reach out and control your PC with just a touch. Being able to pinch, zoom, tap, and swipe right from the screen makes interacting with your computer a totally intuitive experience.<li>【10th Gen Intel Core i5-1035G1 Processor】1.0 GHz base frequency, up to 3.6 GHz with Intel Turbo Boost Technology, 6 MB L3 cache, 4 cores. Smart quad-core, eight-way processing performance. Intel Turbo Boost Technology delivers dynamic extra power when you need it, while increasing energy efficiency when you don't.<li>【Upgraded to 16GB DDR4 RAM】Substantial high-bandwidth RAM to smoothly run your games and photo-and video - editing applications, as well as multiple programs and browser tabs all at once.<li>【512GB PCIe SSD】Provides massive storage space for huge files, so that you can store important digital data and work your way through it with ease.It gives you enormous space to save all of your files.<li>【Fast charge & GM Accessorise】Go from 0 to 50 % charge in approximately 45 minutes.Ghost Manta Accessories Included 1x HDMI Cable, 1x USB extension cord, 1x Mouse Pad.",899.99m, "https://m.media-amazon.com/images/I/71OUSmMg6SL._AC_UY218_.jpg"),
                new Product("HP 14 inches Laptop", "<li>Latest and Powerful Intel Celeron Processor 4205U (2MB Cache, 1.8 GHz) Dual-Core, Eight-way processing provides Maximum high-efficiency power to go. Integrated Radeon R4 Graphics with shared graphics memory provide everyday image quality for Internet use.<li> 15.6-inch HD (1366 x 768) Anti-Glare LED-Backlit Non-touch Display, detailed picture Stunning screen delivers a clear, bright image that's easy on the eyes. Natural finger-touch navigation and screen makes the most of Windows 10<li>Ram is upgraded to 12GB DDR4 Memory for fast processing and advanced multitasking, Hard Drive is upgraded to 256GB PCIe Solid State Drive for delivering fast start - up time and data access.SSD works much faster than HDD.So it will improve the whole performance of a PC computer.System also comes with a 1TB HDD for plenty of storage room.<li>Qualcomm DW1810, 1 x 1, 802.11ac with Wi - Fi, Wireless LAN, Bluetooth 4.1, Media Card Reader <li> HDMI <li> 2 x USB 3.1 <li> 1 x USB 2.0 <li> Headphone / Mic<li>Windows 10 Professional 64 - bit English, the Best version of Windows OS and Great for Business users. 802.11ac Wifi and Bluetooth 3 - Cell 42WHr Battery, PCS Store 32GB USB Drive: Authorized Seller only",499.99m, "https://m.media-amazon.com/images/I/81zk8DWAxmL._AC_UY218_.jpg"),
                new Product("Acer Aspire 15.6 inches Laptop", "<li>AMD Ryzen 3 3200U Dual Core Processor (Up to 3.5GHz); 4GB DDR4 Memory; 128GB PCIe NVMe SSD.<li>15.6 inches full HD (1920 x 1080) widescreen LED backlit IPS display; <li>AMD Radeon Vega 3 Mobile Graphics.<li>1 USB 3.1 Gen 1 port, 2 USB 2.0 ports & 1 HDMI port with HDCP support.<li>802.11ac Wi-Fi; Backlit Keyboard; Up to 7.5 hours battery life.<li>Windows 10 in S mode. Maximum power supply wattage: 65 Watts",488m, "https://m.media-amazon.com/images/I/71vvXGmdKWL._AC_UY218_.jpg"),
                new Product("Lenovo IdeaPad 14 inches Laptop", "<li>AMD Ryzen 5 3500U Mobile Processors with Radeon Graphics deliver powerful performance for everyday tasks.<li>Dopoundsy Audio delivers crystal - clear sound, while the 14 - inch FHD screen and narrow side bezels give you more viewing area and less clutter.<li>Quick and quiet with Q - control – Effortlessly swap between fast &powerful performance and quiet battery saving mode.<li>Connect with ease using Bluetooth 4.1, up to 2x2 Wi-Fi 5, three USB ports, and HDMI.<li>Keep your privacy intact with a physical shutter for your webcam. You'll enjoy privacy right at your fingertips.<li>System RAM Type: DDR4 SDRAM", 419.55m, "https://m.media-amazon.com/images/I/71dqjxW8g5L._AC_UY218_.jpg"),
                new Product("ASUS TUF 15.6 Laptop", "<li>2020 Latest AMD Ryzen 7 4000 Series - 4800H (beat 10th Gen Intel Core i7-10750H) Octa-Core processor up to 4.20 GHz, features machine intelligence that anticipates your needs. Discover true responsiveness with 8 cores and 16 threads for ultimate performance.<li>NVIDIA GeForce RTX 20-series graphics cards are built on the Turing architecture. Combining traditional CUDA cores with RT and Tensor cores for ray - tracing and AI, these cards offer more realistic lighting, shadows, and reflections in real - time.<li>15.6 Full HD display boasts impressive color and clarity. Energy-efficient LED backlight. Built-in HD webcam with array microphone makes it easy to video chat with family and friends or teleconference with colleagues over Skype; 60 Hz refresh rate.<li>ASUS TUF Gaming Laptop has the required specs to run Virtual Reality hardware and software and is compatible with Oculus Rift, HTC Vive, and Windows Mixed Reality Ultra.RGB Backlit keyboard allows you to enjoy comfortable and accurate typing, even in dim lighting.<li>Wireless / Wired connectivity(WiFi 5 - 802.11 ac).Backward - compatible with all other Wi - Fi networks and hotspots.HDMI output expands your viewing options; 48 Whr battery",987.99m, "https://m.media-amazon.com/images/I/91xA0C0bIxL._AC_UY218_.jpg"),
                new Product("HP Chromebook 11.6", "<li>【11.6 Inch Laptop】11.6 inch HD (1366 x 768) Widescreen LED screen with built-in 720p camera, Intel HD Graphics 500.<li>【Dual-Core Celeron N3350】Intel Celeron N3350 Processor (1.1 GHz base frequency up to 2.4 GHz, 2 cores, 2MB cache), 2-cell Li-ion, up to 9 hours battery life mixed-use.<li>High Speed】RAM is upgraded to 4GB LPDDR2 memory for multitasking Adequate high - bandwidth RAM to smoothly run multiple applications and browser tabs all at once.<li>【Enormous Space】Hard Drive is upgraded to 32GB eMMC provides massive storage space for huge files, so that you can store important digital data and work your way through it with ease.Enhance the overall performance of the laptop for business, student, daily usage.<br>【NexiGo Bundle】 Bundled with NexiGo 32GB MicroSD Card, offers cost - effective portable solution instantly boosting available storage space for your laptop. 2 x USB Type A Ports, 2 x USB Type C Ports, 1 x Headphone Jack, 1 x Media Card Reader. 1 - Year NexiPC Limited Warranty | View description and warranty section below for more details.",418.50m, "https://m.media-amazon.com/images/I/61p1g-I0WkL._AC_UY218_.jpg"),
                new Product("HP Stream 14-inch Pink", "<li>Intel Celeron N4000 Dual-Core Processor (Up to 2.60GHz, 4MB Cache), 4GB DDR4 RAM, 32GB eMMC Storage.<li>14 HD (1366 x 768) SVA WLED-Backlit Display with BrightView Micro-edge Technology, Intel Integrated UHD Graphics 600.<li>IEEE 802.11ac, Bluetooth 4.2, 2xUSB3.1 Gen 1 (Data transfer only),1xUSB 2.0, 1xHeadphone/Microphone Combo Jack, 1xMulti-format SD Media Card Reader, 1xHDMI 1.4, NO Optical Drive.<li>Windows 10 S OS, 3-cell Lithium Ion Battery",296.99m, "https://m.media-amazon.com/images/I/71V2Ms3ytHL._AC_UY218_.jpg"),
                new Product("Acer Predator Helios 300", "<li>10th Generation Intel Core i7-10750H 6-Core Processor (Up to 5.0 GHz) with Windows 10 Home 64 Bit.<li>Overclockable NVIDIA GeForce RTX 2060 with 6 GB of dedicated GDDR6 VRAM.<li>15.6 Full HD (1920 x 1080) Widescreen LED-backlit IPS display (144Hz Refresh Rate, 3ms Overdrive Response Time, 300nit Brightness & 72% NTSC).<li>16 GB DDR4 2933MHz Dual-Channel Memory, 512GB NVMe SSD (2 x M.2 slots | 1 Slot open for easy upgrades) &1 - Available Hard Drive Bay.<li>4 - Zone RGB Backlit Keyboard | Wireless: Killer Double Shot Pro Wireless - AX 1650i 802. 11ax Wi-Fi 6 | LAN: Killer Ethernet E2600 10 / 100 / 1000 Gigabit Ethernet LAN | DTS X: Ultra Audio | 4th Gen All - Metal AeroBlade 3D Fan.<li>Connectivity technology: Bluetooth",1234.99m, "https://m.media-amazon.com/images/I/71k45hZkLmL._AC_UY218_.jpg"),
                new Product("HP Chromebook 14", "<li>Google Play Store: The millions of Android apps you know and love on your phone and tablet can now run on your Chrome device without compromising their speed, simplicity or security.<li>Sleek, responsive design: Keep going comfortably with the backlit keyboard and multi-touch touchpad that supports four finger gestures set in a sleek design for moving from room to room or on the road.<li>Binge watch while you work: Equipped with an Intel(R) processor, 14 display, stereo speakers tuned by audio experts at B&O and a long battery life to get more done while having fun.<li>Environmentally conscious: Low halogen, mercury-free display backlights, arsenic-free display glass in this ENERGY STAR(R) certified, EPEAT(R) Silver registered Chromebook.<Bbr>Dual - core Intel(R) processor: Intel(R) Celeron(R) N4000, Dual - Core, 1.1 GHz base frequency, up to 2.6 GHz burst frequency.<li>Display: 14.0 - inch diagonal FHD IPS anti-glare micro - edge WLED - backlit display(1920 x 1080); 82 % screen to body ratio.<li>Memory & storage: 4 GB LPDDR4-2400 SDRAM(not upgradable) and 32 GB eMMC",292.99m, "https://m.media-amazon.com/images/I/91shKLxoedL._AC_UY218_.jpg"),
                new Product("HP Stream 14-inch Laptop Grey", "<li>【14 Non-touch HD Display】14.0-inch diagonal, HD (1366 x 768), micro-edge, BrightView, 220 nits, 45% NTSC, 79% Screen to body ratio. Integrated Intel UHD Graphics 600.<li>【Intel Dual-Core Celeron N4020】Intel Dual-Core Celeron N4020 (1.1 GHz base frequency, up to 2.8 GHz burst frequency, 4 MB L2 Cache). <li>【4GB RAM and 64GB SSD】4 GB DDR4-2400 SDRAM (1 x 4 GB), Memory slot not user accessible, 64 GB eMMC SSD, Full-size keyboard without number pad, HP Imagepad with multi-touch gesture support, Optical drive not included.<li> 【Connectivity】Realtek RTL8822CE 802.11a/b/g/n/ac (2x2) Wi-Fi and Bluetooth 5.0 combo; 1 microSD media card reader; 1 SuperSpeed USB Type - C 5Gbps signaling rate; 2 SuperSpeed USB Type - A 5Gbps signaling rate; 1 HDMI 1.4b; 1 AC Smart pin; 1 Headphone / microphone combo; HP True Vision 720p HD camera with integrated dual array digital microphones.<li> 【Operating System and Ports】Windows 10 Home in S mode 64 - bit, English(Free upgrade to Windows 10 Home); Office 365 Personal for 1 Year; 3 - cell, 41 Wh Li - ion battery ; Up to 9 hours(wireless streaming).<li> 【Authorized Oydisen Bundle】Bundled with Oydisen Cloth, Authorized Sellers ONLY",319.99m, "https://m.media-amazon.com/images/I/61Gqm59K62L._AC_UY218_.jpg"),
                new Product("HP 15.6 inch Laptop", "<li>【15.6 Full HD IPS Touchscreen】IPS WLED-backlit multitouch-enabled edge-to-edge glass (1920 x 1080). Reach out and control your PC with just a touch. With its thin and light design, 6.5 mm micro-edge bezel display, and 82% screen to body ratio.<li> 【10th Gen Intel Core i5-1035G1】Smart quad-core, eight-way processing performance. Intel Turbo Boost Technology delivers dynamic extra power when you need it, while increasing energy efficiency when you don't.<li> 【Upgraded to 16GB DDR4 RAM】Substantial high-bandwidth RAM to smoothly run your games and photo-and video - editing applications, as well as multiple programs and browser tabs all at once.<li> 【Upgraded storage to 512GB SSD】Provides massive storage space for huge files, so that you can store important digital data and work your way through it with ease.It gives you enormous space to save all of your files.<li> 【Fast charge】With a long battery life and fast - charge technology, this laptop lets you work, watch, and stay connected all day.An integrated precision touchpad with multi - touch support speeds up both navigation and productivity.",749.99m, "https://m.media-amazon.com/images/I/71Ni8QtU7DL._AC_UY218_.jpg"),
                new Product("Dell Inspiron 15.6 Laptop", "<li>Latest and Powerful Intel Celeron Processor 4205U (2MB Cache, 1.8 GHz) Dual-Core, Eight-way processing provides Maximum high-efficiency power to go. Integrated Radeon R4 Graphics with shared graphics memory provide everyday image quality for Internet use.<li>15.6-inch HD (1366 x 768) Anti-Glare LED-Backlit Non-touch Display, detailed picture Stunning screen delivers a clear, bright image that's easy on the eyes. Natural finger-touch navigation and screen makes the most of Windows 10<li>Ram is upgraded to 12GB DDR4 Memory for fast processing and advanced multitasking, Hard Drive is upgraded to 256GB PCIe Solid State Drive for delivering fast start - up time and data access.SSD works much faster than HDD.So it will improve the whole performance of a PC computer.System also comes with a 1TB HDD for plenty of storage room.<li>Qualcomm DW1810, 1 x 1, 802.11ac with Wi - Fi, Wireless LAN, Bluetooth 4.1, Media Card Reader <li> HDMI <li> 2 x USB 3.1 <li> 1 x USB 2.0 <li> Headphone / Mic<li>Windows 10 Professional 64 - bit English, the Best version of Windows OS and Great for Business users. 802.11ac Wifi and Bluetooth 3 - Cell 42WHr Battery, PCS Store 32GB USB Drive: Authorized Seller only",649.99m, "https://m.media-amazon.com/images/I/51rjrBJXoAL._AC_UY218_.jpg"),

            };
        }

        static IEnumerable<Category> GetPreconfiguredCategories()
        {
            return new List<Category>
            {
                new Category("Mug"),
                new Category("T-Shirt"),
                new Category("Sheet"),
                new Category("USB Memory Stick"),
                new Category("Laptops")
            };
        }

        static IEnumerable<ProductCategory> GetPreconfiguredProductCategories()
        {
            return new List<ProductCategory>
            {
                //new ProductCategory(2,1),
                //new ProductCategory(1,2),
                //new ProductCategory(2,3),
                //new ProductCategory(2,4),
                //new ProductCategory(3,5),
                //new ProductCategory(2,6),
                //new ProductCategory(2,7),
                //new ProductCategory(2,8),
                //new ProductCategory(1,9),
                //new ProductCategory(3,10),
                //new ProductCategory(3,11),
                //new ProductCategory(2,12),
                new ProductCategory(5,1),
                new ProductCategory(5,2),
                new ProductCategory(5,3),
                new ProductCategory(5,4),
                new ProductCategory(5,5),
                new ProductCategory(5,6),
                new ProductCategory(5,7),
                new ProductCategory(5,8),
                new ProductCategory(5,9),
                new ProductCategory(5,10),
                new ProductCategory(5,11),
                new ProductCategory(5,12),
            };
        }
    }
}
