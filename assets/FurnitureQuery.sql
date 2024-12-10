USE FurnitureStoreDb

------------------------------------------------------------
--------------- Data for FurnitureBrandName ----------------
------------------------------------------------------------

INSERT INTO dbo.FurnitureBrands (FurnitureBrandName)
VALUES 
('AThing'),
('BestStuff'),
('CoolItem');

------------------------------------------------------------
------------- Data for FurnitureCategoryName ---------------
------------------------------------------------------------

INSERT INTO dbo.FurnitureCategories (FurnitureCategoryName)
VALUES 
('Bed'),
('Cabinet'),
('Showers'),
('Sink'),
('Sofa'),
('Table');

------------------------------------------------------------
-------------------- Data for Furniture --------------------
------------------------------------------------------------

INSERT INTO dbo.Furnitures (Name, Price, Quantity, FurnitureBrandId, FurnitureCategoryId, FurnitureDescription, FurnitureImage)
VALUES
-- Beds
('Classic Queen Bed', 300.00, 10, 1, 1, 'A timeless queen-sized bed featuring a sturdy wooden frame with elegant traditional design. Perfect for those seeking a classic, comfortable sleeping solution with reliable support and a touch of vintage charm.', 'assets/Bed/Bed (1).jpg'),
('Modern Single Bed', 400.00, 15, 2, 1, 'Sleek and contemporary single bed with a minimalist design. Crafted with high-quality materials and a clean aesthetic, this bed offers modern comfort and style for individual bedrooms or compact spaces.', 'assets/Bed/Bed (2).jpg'),
('Luxury Queen Bed', 500.00, 8, 3, 1, 'Exquisite luxury queen bed designed for ultimate comfort and sophistication. Features premium materials, intricate craftsmanship, and a bold design that serves as a stunning centerpiece in any master bedroom.', 'assets/Bed/Bed (3).jpg'),
('Simple Queen Bed', 200.00, 20, 1, 1, 'Affordable and practical queen-sized bed with a straightforward design. Offers reliable comfort and functionality, making it an excellent choice for budget-conscious buyers seeking a no-frills sleeping solution.', 'assets/Bed/Bed (4).jpg'),
('Storage King Bed', 350.00, 12, 2, 1, 'Innovative king-sized bed with integrated storage compartments. Perfect for maximizing bedroom space, this bed combines comfort with practicality, offering ample hidden storage for bedding, clothing, and personal items.', 'assets/Bed/Bed (5).jpg'),
('Rustic King Bed', 280.00, 18, 3, 1, 'Rustic-style king bed crafted with natural wood and a weathered finish. Brings a warm, earthy atmosphere to the bedroom, combining rugged charm with comfortable sleeping space for couples.', 'assets/Bed/Bed (6).jpg'),

-- Cabinets
('Modern Wood Cabinet', 250.00, 10, 1, 2, 'Contemporary wooden cabinet with clean lines and a minimalist design. Offers versatile storage solutions with multiple shelves and a smooth finish, perfect for modern home and office environments.', 'assets/Cabinet/Cabinet (1).jpg'),
('Rustic White Cabinet', 270.00, 8, 2, 2, 'Charming rustic white cabinet that blends traditional craftsmanship with a contemporary color palette. Provides substantial storage with a distinctive weathered finish that adds character to any room.', 'assets/Cabinet/Cabinet (2).jpg'),
('Vintage Colourful Cabinet', 300.00, 6, 3, 2, 'Vibrant vintage-inspired cabinet featuring a unique color palette and nostalgic design. A statement piece that combines functional storage with artistic expression and retro charm.', 'assets/Cabinet/Cabinet (3).jpg'),
('Compact White Cabinet', 180.00, 12, 1, 2, 'Space-saving white cabinet ideal for smaller rooms or apartments. Offers efficient storage with a clean, unobtrusive design that complements various interior styles.', 'assets/Cabinet/Cabinet (4).jpg'),
('Spacious Blue Cabinet', 320.00, 5, 2, 2, 'Large blue cabinet with generous storage capacity and a bold color statement. Perfect for organizing household items while adding a striking visual element to your living space.', 'assets/Cabinet/Cabinet (5).jpg'),
('Classic Wooden Cabinet', 290.00, 7, 3, 2, 'Timeless wooden cabinet featuring traditional craftsmanship and elegant design. Offers reliable storage with rich wood textures and a classic aesthetic that never goes out of style.', 'assets/Cabinet/Cabinet (6).jpg'),
('Twin White Cabinet', 310.00, 9, 1, 2, 'Symmetrical white cabinet with twin-style design, offering balanced and efficient storage. Ideal for bedrooms, living rooms, or home offices seeking a clean, coordinated look.', 'assets/Cabinet/Cabinet (7).jpg'),

-- Showers
('Classic Shower', 400.00, 5, 1, 3, 'Traditional shower design with reliable performance and timeless aesthetics. Features durable construction and classic styling, suitable for bathrooms seeking a standard, dependable showering solution.', 'assets/Showers/Showers (1).jpg'),
('Long Shower', 450.00, 8, 2, 3, 'Extended-length shower providing extra space and comfort. Perfect for those desiring a more luxurious bathing experience with ample room for movement and relaxation.', 'assets/Showers/Showers (2).jpg'),
('Skydown Shower', 500.00, 4, 3, 3, 'Premium overhead shower system with advanced water distribution technology. Creates a rainfall-like experience with precision engineering and sophisticated design.', 'assets/Showers/Showers (3).jpg'),
('Skymeteor Shower', 380.00, 6, 1, 3, 'Innovative shower head with multiple spray settings and sleek modern design. Offers customizable water flow and a contemporary aesthetic for modern bathrooms.', 'assets/Showers/Showers (4).jpg'),
('Metal Shower', 600.00, 3, 2, 3, 'High-end metal shower system featuring industrial-grade materials and cutting-edge design. Provides exceptional durability and a bold, contemporary bathroom statement.', 'assets/Showers/Showers (5).jpg'),
('Duo Shower', 420.00, 7, 3, 3, 'Dual-function shower system with complementary shower heads. Offers versatility and a luxurious bathing experience with multiple water flow options.', 'assets/Showers/Showers (6).jpg'),

-- Sinks
('Classic Chrome Tap', 120.00, 25, 1, 4, 'Timeless chrome tap with smooth operation and classic design. Offers reliable water control and a polished look that complements traditional bathroom and kitchen fixtures.', 'assets/Sink/Sink (1).jpg'),
('Black Tap', 140.00, 20, 2, 4, 'Sleek black tap featuring a modern design and contemporary color. Provides a striking visual contrast and adds a touch of sophistication to modern kitchen or bathroom spaces.', 'assets/Sink/Sink (2).jpg'),
('White Plastic Tap', 500.00, 5, 3, 4, 'Premium white plastic tap with innovative design and high-end functionality. Offers a unique aesthetic and durable performance for contemporary interior spaces.', 'assets/Sink/Sink (3).jpg'),
('Chrome Single Handle Tap', 180.00, 18, 1, 4, 'User-friendly chrome single-handle tap with precise water temperature and flow control. Combines practical design with a clean, modern appearance.', 'assets/Sink/Sink (4).jpg'),
('Rustic Chrome Tap', 220.00, 15, 2, 4, 'Vintage-inspired chrome tap with rustic charm and traditional craftsmanship. Adds character and warmth to bathrooms and kitchens with its distinctive design.', 'assets/Sink/Sink (5).jpg'),
('Minimalist Chrome Tap', 300.00, 8, 3, 4, 'Ultra-modern minimalist chrome tap with clean lines and sophisticated design. Perfect for contemporary spaces seeking understated elegance and precision engineering.', 'assets/Sink/Sink (6).jpg'),
('Chrome Single Handle Tap', 100.00, 28, 1, 4, 'Budget-friendly chrome single-handle tap offering reliable performance and classic styling. An excellent choice for practical, no-frills installations.', 'assets/Sink/Sink (7).jpg'),
('Chrome Double Handle Tap', 130.00, 20, 2, 4, 'Traditional chrome double-handle tap providing separate controls for hot and cold water. Offers classic design and precise temperature management.', 'assets/Sink/Sink (8).jpg'),
('Gold Tap', 250.00, 12, 3, 4, 'Luxurious gold-finished tap that serves as a stunning focal point. Combines opulent design with high-end functionality for discerning homeowners.', 'assets/Sink/Sink (9).jpg'),
('Chrome Cool Tap', 180.00, 18, 1, 4, 'Modern chrome tap with a cool, contemporary design. Features smooth lines and efficient water flow for stylish, functional kitchen and bathroom installations.', 'assets/Sink/Sink (10).jpg'),
('Deck Mounted Chrome Tap', 200.00, 22, 2, 4, 'Deck-mounted chrome tap designed for seamless integration with countertops and sinks. Offers a clean, streamlined look with professional installation.', 'assets/Sink/Sink (11).jpg'),
('Freestanding Chrome Tap', 350.00, 10, 3, 4, 'Versatile freestanding chrome tap that provides installation flexibility and modern design. Ideal for unique bathroom layouts and contemporary interior designs.', 'assets/Sink/Sink (12).jpg'),
('Brushed Nickel Chrome Tap', 240.00, 16, 1, 4, 'Sophisticated brushed nickel chrome tap with a soft, muted finish. Provides a modern alternative to traditional chrome with enhanced visual depth.', 'assets/Sink/Sink (13).jpg'),
('Vintage Chrome Style Tap', 180.00, 14, 2, 4, 'Nostalgic chrome tap featuring vintage-inspired design elements. Brings classic elegance and timeless charm to traditional interior spaces.', 'assets/Sink/Sink (14).jpg'),
('High Arc Chrome Tap', 220.00, 25, 3, 4, 'High-arc chrome tap offering increased clearance for easier sink usage. Combines practical design with modern aesthetic for enhanced functionality.', 'assets/Sink/Sink (15).jpg'),
('Commercial Chrome Tap', 300.00, 18, 1, 4, 'Robust commercial-grade chrome tap designed for high-traffic areas. Offers durability, reliability, and professional-quality performance.', 'assets/Sink/Sink (16).jpg'),
('Elegant Chrome Tap', 270.00, 9, 2, 4, 'Refined chrome tap with elegant curves and sophisticated design. Elevates bathroom and kitchen aesthetics with its graceful, polished appearance.', 'assets/Sink/Sink (17).jpg'),
('Chrome Tap', 400.00, 5, 3, 4, 'Premium chrome tap featuring exceptional craftsmanship and superior materials. A high-end solution for those seeking top-tier performance and design.', 'assets/Sink/Sink (18).jpg'),

-- Sofas
('Comfortable Grey Sofa', 800.00, 10, 1, 5, 'Plush grey sofa offering unparalleled comfort and versatile styling. Features soft upholstery and a neutral color that seamlessly integrates into various living room designs.', 'assets/Sofa/Sofa (1).jpg'),
('Modern Red Sofa', 900.00, 7, 2, 5, 'Bold red sofa with contemporary design, making a striking statement in any living space. Combines eye-catching color with modern comfort and sleek lines.', 'assets/Sofa/Sofa (2).jpg'),
('Leather Luxury Sofa', 1000.00, 5, 3, 5, 'Premium leather sofa representing the pinnacle of luxury and comfort. Crafted with top-grain leather and exceptional attention to detail for discerning homeowners.', 'assets/Sofa/Sofa (3).jpg'),
('Premium Sofa', 700.00, 8, 1, 5, 'High-quality sofa offering superior comfort and refined design. Balances aesthetic appeal with practical functionality for modern living spaces.', 'assets/Sofa/Sofa (4).jpg'),
('Majestic Single Sofa', 850.00, 6, 2, 5, 'Elegant single-seat sofa designed for individual comfort and sophisticated styling. Perfect for creating intimate seating areas with a touch of luxury.', 'assets/Sofa/Sofa (5).jpg'),
('Great Luxury Sofa', 950.00, 4, 3, 5, 'Exceptional luxury sofa combining opulent design with supreme comfort. A statement piece that transforms living spaces with its remarkable craftsmanship.', 'assets/Sofa/Sofa (6).jpg'),
('Comfy Luxury Sofa', 950.00, 4, 3, 5, 'Indulgent luxury sofa emphasizing comfort and relaxation. Generously padded with premium materials, offering an inviting and sumptuous seating experience.', 'assets/Sofa/Sofa (7).jpg'),

-- Tables
('Wooden Office Table', 500.00, 12, 1, 6, 'Sturdy wooden office table designed for professional environments. Offers ample workspace with classic wooden construction and reliable performance.', 'assets/Table/Table (1).jpg'),
('Glass Top Coffee Table', 350.00, 10, 2, 6, 'Elegant glass-top coffee table that adds a touch of modern sophistication to living rooms. Features a sleek design that creates a sense of openness and light.', 'assets/Table/Table (2).jpg'),
('Elegant Study Table', 200.00, 15, 3, 6, 'Compact and stylish study table perfect for students and home offices. Provides a focused workspace with a clean, minimalist design.', 'assets/Table/Table (3).jpg'),
('Multifunctional Study Table', 800.00, 5, 1, 6, 'Advanced study table with multiple features and configurations. Designed to adapt to various work and study needs with innovative design elements.', 'assets/Table/Table (4).jpg'),
('Modern Drawer Table', 180.00, 20, 2, 6, 'Space-efficient modern table with integrated drawer storage. Offers practical organization and a sleek, contemporary aesthetic.', 'assets/Table/Table (5).jpg'),
('Rustic Shield Table', 700.00, 8, 3, 6, 'Unique rustic table featuring a distinctive shield-inspired design. Combines traditional craftsmanship with artistic flair for a memorable furniture piece.', 'assets/Table/Table (6).jpg'),
('Modern Black Table', 600.00, 9, 1, 6, 'Sophisticated black table with clean, modern lines. Creates a bold statement in contemporary interior spaces with its striking design.', 'assets/Table/Table (7).jpg'),
('Cabinet Writing Desk', 250.00, 14, 2, 6, 'Versatile writing desk with integrated cabinet storage. Provides an organized workspace with practical design and efficient functionality.', 'assets/Table/Table (8).jpg'),
('Vintage Study Table', 400.00, 7, 3, 6, 'Nostalgic study table featuring vintage design elements. Brings timeless charm and character to home offices and study areas.', 'assets/Table/Table (9).jpg'),
('OG Study Table', 450.00, 6, 1, 6, 'Original and classic study table design offering reliable performance and traditional styling. A dependable workspace solution with enduring appeal.', 'assets/Table/Table (10).jpg'),
('Single Computer Table', 550.00, 11, 2, 6, 'Specialized computer table designed for optimal ergonomics and technology integration. Provides a dedicated workspace for digital professionals and enthusiasts.', 'assets/Table/Table (11).jpg');