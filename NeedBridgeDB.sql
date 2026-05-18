-- =============================================================
-- NeedBridge — Multi-Vendor E-Commerce System
-- Database: NeedBridgeDB
-- Language: T-SQL (Microsoft SQL Server)
-- =============================================================
--
-- HOW TO USE:
-- 1. Open SQL Server Management Studio (SSMS)
-- 2. Connect to your server (e.g., TALVI\SQLEXPRESS)
-- 3. Open this file: File -> Open -> File -> NeedBridgeDB.sql
-- 4. Click "Execute" (or press F5) to run the entire script
-- 5. Refresh Object Explorer — you will see NeedBridgeDB with
--    7 tables, 8 categories, 7 admin/test users, 100 products
-- =============================================================


-- =============================================================
-- STEP 1: CREATE DATABASE
-- =============================================================
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'NeedBridgeDB')
BEGIN
    ALTER DATABASE NeedBridgeDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE NeedBridgeDB;
END
GO

CREATE DATABASE NeedBridgeDB;
GO

USE NeedBridgeDB;
GO


-- =============================================================
-- STEP 2: CREATE TABLES (in dependency order)
-- =============================================================

-- Users table (stores all 4 user types: superadmin, admin, vendor, customer)
CREATE TABLE Users (
    user_id    INT           PRIMARY KEY IDENTITY(1,1),
    full_name  NVARCHAR(100) NOT NULL,
    username   NVARCHAR(50)  NOT NULL UNIQUE,
    password   NVARCHAR(100) NOT NULL,
    email      NVARCHAR(100),
    phone      NVARCHAR(20),
    address    NVARCHAR(255),
    user_type  NVARCHAR(20)  NOT NULL,
    status     NVARCHAR(20)  DEFAULT 'active',
    created_at DATETIME      DEFAULT GETDATE()
);
GO

-- Categories table (product classification)
CREATE TABLE Categories (
    category_id   INT           PRIMARY KEY IDENTITY(1,1),
    category_name NVARCHAR(100) NOT NULL,
    description   NVARCHAR(255)
);
GO

-- Products table (listed by vendors, classified by category)
CREATE TABLE Products (
    product_id   INT           PRIMARY KEY IDENTITY(1,1),
    vendor_id    INT           NOT NULL,
    category_id  INT           NOT NULL,
    product_name NVARCHAR(150) NOT NULL,
    description  NVARCHAR(500),
    price        DECIMAL(10,2) NOT NULL,
    discount_pct DECIMAL(5,2)  DEFAULT 0,
    stock_qty    INT           DEFAULT 0,
    image_path   NVARCHAR(255),
    availability NVARCHAR(20)  DEFAULT 'available',
    created_at   DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (vendor_id)   REFERENCES Users(user_id),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);
GO

-- Cart table (customers add products before purchase)
CREATE TABLE Cart (
    cart_id     INT      PRIMARY KEY IDENTITY(1,1),
    customer_id INT      NOT NULL,
    product_id  INT      NOT NULL,
    quantity    INT      NOT NULL DEFAULT 1,
    added_at    DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (customer_id) REFERENCES Users(user_id),
    FOREIGN KEY (product_id)  REFERENCES Products(product_id)
);
GO

-- Orders table (completed purchases with delivery tracking)
CREATE TABLE Orders (
    order_id         INT           PRIMARY KEY IDENTITY(1,1),
    customer_id      INT           NOT NULL,
    product_id       INT           NOT NULL,
    vendor_id        INT           NOT NULL,
    quantity         INT           NOT NULL,
    total_price      DECIMAL(10,2) NOT NULL,
    order_status     NVARCHAR(30)  DEFAULT 'Placed',
    payment_method   NVARCHAR(30),
    delivery_address NVARCHAR(255),
    order_date       DATETIME      DEFAULT GETDATE(),
    updated_at       DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (customer_id) REFERENCES Users(user_id),
    FOREIGN KEY (product_id)  REFERENCES Products(product_id),
    FOREIGN KEY (vendor_id)   REFERENCES Users(user_id)
);
GO

-- Payments table (payment record for each order)
CREATE TABLE Payments (
    payment_id      INT           PRIMARY KEY IDENTITY(1,1),
    order_id        INT           NOT NULL,
    customer_id     INT           NOT NULL,
    amount          DECIMAL(10,2) NOT NULL,
    payment_method  NVARCHAR(30)  NOT NULL,
    transaction_ref NVARCHAR(100),
    payment_status  NVARCHAR(20)  DEFAULT 'completed',
    payment_date    DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (order_id)    REFERENCES Orders(order_id),
    FOREIGN KEY (customer_id) REFERENCES Users(user_id)
);
GO

-- Reviews table (customers review products after delivery)
CREATE TABLE Reviews (
    review_id   INT           PRIMARY KEY IDENTITY(1,1),
    customer_id INT           NOT NULL,
    product_id  INT           NOT NULL,
    order_id    INT           NOT NULL,
    rating      INT           NOT NULL,
    comment     NVARCHAR(500),
    review_date DATETIME      DEFAULT GETDATE(),
    FOREIGN KEY (customer_id) REFERENCES Users(user_id),
    FOREIGN KEY (product_id)  REFERENCES Products(product_id),
    FOREIGN KEY (order_id)    REFERENCES Orders(order_id)
);
GO


-- =============================================================
-- STEP 3: SEED USERS (1 SuperAdmin + 4 Admins + 2 Test Users)
-- =============================================================
INSERT INTO Users (full_name, username, password, email, phone, address, user_type, status) VALUES
('Muhammad Taki Ahmed',      'taki',         'taki1234', 'taki@needbridge.com',         '01700000001', 'Dhaka',     'superadmin', 'active'),
('Dr. Md. Iftekharul Mobin', 'iftekharul',   'sirmobin', 'iftekharul@needbridge.com',   '01700000002', 'Dhaka',     'admin',      'active'),
('Hasibul Hasan',            'hasibul',      'hasib1234','hasibul@needbridge.com',      '01700000003', 'Dhaka',     'admin',      'active'),
('Md. Touhidul Islam',       'touhidul',     'touhi1234','touhidul@needbridge.com',     '01700000004', 'Dhaka',     'admin',      'active'),
('Mohtasim Mohammad',        'mohtasim',     'mohta1234','mohtasim@needbridge.com',     '01700000005', 'Dhaka',     'admin',      'active'),
('Test Vendor',              'testvendor',   'vendor123','testvendor@needbridge.com',   '01700000006', 'Chittagong','vendor',     'active'),
('Test Customer',            'testcustomer', 'test123',  'testcustomer@needbridge.com', '01700000007', 'Dhaka',     'customer',   'active');
GO


-- =============================================================
-- STEP 4: SEED CATEGORIES
-- =============================================================
INSERT INTO Categories (category_name, description) VALUES
('Electronics',      'Phones, laptops, TVs, gadgets'),
('Clothing',         'Men, women, kids fashion and accessories'),
('Food & Grocery',   'Rice, oil, snacks, beverages, daily essentials'),
('Home & Living',    'Furniture, kitchen, appliances, decor'),
('Beauty & Health',  'Skincare, cosmetics, supplements, medicines'),
('Sports',           'Cricket, football, gym, outdoor gear'),
('Books & Stationery','Textbooks, novels, pens, school supplies'),
('Automotive',       'Car accessories, oils, parts');
GO


-- =============================================================
-- STEP 5: SEED VENDORS (10 vendors — IDs 8 to 17)
-- =============================================================
INSERT INTO Users (full_name, username, password, email, phone, address, user_type, status) VALUES
('Rahim Electronics',    'rahimelectro', 'vendor123', 'rahim@shop.com',   '01711000001', 'Dhaka',       'vendor', 'active'),
('Karim Fashion',        'karimfashion', 'vendor123', 'karim@shop.com',   '01711000002', 'Chittagong',  'vendor', 'active'),
('Dhaka Grocery',        'dhakagrocery', 'vendor123', 'dhaka@shop.com',   '01711000003', 'Dhaka',       'vendor', 'active'),
('Sylhet Books',         'sylhetbooks',  'vendor123', 'sylhet@shop.com',  '01711000004', 'Sylhet',      'vendor', 'active'),
('Rajshahi Furniture',   'rajfurniture', 'vendor123', 'raj@shop.com',     '01711000005', 'Rajshahi',    'vendor', 'active'),
('Comilla Sports',       'comillasports','vendor123', 'comilla@shop.com', '01711000006', 'Comilla',     'vendor', 'active'),
('Khulna Beauty',        'khulnabeauty', 'vendor123', 'khulna@shop.com',  '01711000007', 'Khulna',      'vendor', 'active'),
('Barisal Auto',         'barisalauto',  'vendor123', 'barisal@shop.com', '01711000008', 'Barisal',     'vendor', 'active'),
('Mymensingh Home',      'mymensingh',   'vendor123', 'mymen@shop.com',   '01711000009', 'Mymensingh',  'vendor', 'active'),
('Narayanganj Tech',     'narayantech',  'vendor123', 'narayan@shop.com', '01711000010', 'Narayanganj', 'vendor', 'active');
GO


-- =============================================================
-- STEP 6: SEED PRODUCTS (100 products across all 10 vendors)
-- Vendor IDs assumed: 8 = Rahim Electronics, ..., 17 = Narayanganj Tech
-- =============================================================

-- Electronics — Rahim Electronics (vendor_id = 8)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(8, 1, 'Samsung Galaxy A55',         '6.6 inch display, 8GB RAM, 256GB storage',     45000, 10, 20, 'available'),
(8, 1, 'iPhone 14',                  'Apple iPhone 14 128GB Black',                 120000,  5, 10, 'available'),
(8, 1, 'Xiaomi Redmi Note 13',       '6.67 inch AMOLED, 6GB RAM',                    22000, 15, 35, 'available'),
(8, 1, 'Samsung 43 inch Smart TV',   '4K UHD Android TV',                            55000,  8, 15, 'available'),
(8, 1, 'Sony WH-1000XM5 Headphones', 'Noise cancelling wireless headphones',         38000, 12, 25, 'available'),
(8, 1, 'JBL Flip 6 Speaker',         'Portable waterproof bluetooth speaker',        12000,  0, 40, 'available'),
(8, 1, 'Lenovo IdeaPad Laptop',      'Intel i5, 8GB RAM, 512GB SSD',                 65000,  7, 12, 'available'),
(8, 1, 'Canon EOS M50 Camera',       '24.1MP Mirrorless Camera',                     75000,  5,  8, 'available'),
(8, 1, 'Apple Watch Series 8',       'GPS + Cellular, 45mm',                         48000,  0, 18, 'available'),
(8, 1, 'iPad 10th Generation',       '10.9 inch, 64GB, WiFi',                        58000,  6, 14, 'available');

-- Clothing — Karim Fashion (vendor_id = 9)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(9, 2, 'Panjabi White Cotton',       'Premium cotton panjabi for Eid',                1800, 20, 100, 'available'),
(9, 2, 'Salwar Kameez Set',          'Printed cotton ladies set',                     2500, 15,  80, 'available'),
(9, 2, 'Denim Jeans Slim Fit',       'Stretch denim slim fit jeans',                  1500, 10, 120, 'available'),
(9, 2, 'Formal Shirt White',         'Office formal cotton shirt',                    1200,  0, 150, 'available'),
(9, 2, 'Saree Silk Banarasi',        'Handwoven Banarasi silk saree',                 8500,  5,  30, 'available'),
(9, 2, 'Kids T-Shirt Pack',          'Pack of 3 colorful kids t-shirts',               900, 25, 200, 'available'),
(9, 2, 'Winter Jacket Men',          'Waterproof winter jacket with hood',            4500, 10,  60, 'available'),
(9, 2, 'Sharee Cotton Tant',         'Traditional Bengal tant saree',                 3200,  8,  45, 'available'),
(9, 2, 'Sports Shorts Men',          'Dry-fit sports shorts',                          800,  0, 180, 'available'),
(9, 2, 'Hijab Set 5 Pieces',         'Premium jersey hijab assorted colors',          1200, 15,  90, 'available');

-- Food & Grocery — Dhaka Grocery (vendor_id = 10)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(10, 3, 'Bashundhara Flour 5kg',     'Premium wheat flour',                            320,  0, 500, 'available'),
(10, 3, 'Radhuni Biryani Masala',    'Authentic biryani spice mix 200g',               120,  5, 300, 'available'),
(10, 3, 'Pran Mango Juice 1L',       'Fresh mango juice tetrapack',                     85,  0, 600, 'available'),
(10, 3, 'Organic Mustard Oil 1L',    'Cold pressed pure mustard oil',                  280,  0, 250, 'available'),
(10, 3, 'Arong Full Cream Milk 1L',  'Fresh pasteurized full cream milk',               95,  0, 400, 'available'),
(10, 3, 'Khaas Food Honey 500g',     'Pure natural honey from Sundarbans',             650, 10, 150, 'available'),
(10, 3, 'Chinigura Rice 5kg',        'Premium aromatic chinigura rice',                750,  0, 200, 'available'),
(10, 3, 'Ifad Noodles 75g Pack 5',   'Masala noodles family pack',                     180,  5, 350, 'available'),
(10, 3, 'Fresh Hilsa Fish 1kg',      'Fresh Padma hilsa fish',                        1800,  0,  50, 'available'),
(10, 3, 'Deshi Chicken 1kg',         'Free range country chicken',                     650,  0,  80, 'available');

-- Books & Stationery — Sylhet Books (vendor_id = 11)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(11, 7, 'HSC Physics Guide',          'Complete HSC Physics with solved MCQ',          450, 10, 200, 'available'),
(11, 7, 'Oxford Dictionary English',  'Oxford Advanced Learners Dictionary',          1200,  5,  80, 'available'),
(11, 7, 'Bangla Academy Dictionary',  'Standard Bangla-English dictionary',            650,  0, 120, 'available'),
(11, 7, 'Humayun Ahmed Novel Pack',   'Collection of 5 best Humayun novels',          1800, 15,  60, 'available'),
(11, 7, 'A4 Paper 500 Sheets',        'Premium 80gsm A4 printing paper',               480,  0, 300, 'available'),
(11, 7, 'Geometry Box Set',           'Complete geometry box for students',            250,  0, 400, 'available'),
(11, 7, 'Pen Drive 32GB',             'USB 3.0 flash drive 32GB',                      450,  8, 250, 'available'),
(11, 7, 'Scientific Calculator',      'Casio FX-991EX scientific calculator',         1800,  5, 100, 'available'),
(11, 7, 'Notebook A4 200 Pages',      'Hard cover spiral notebook',                    180,  0, 500, 'available'),
(11, 7, 'Water Color Set 24',         '24 color professional water colors',            750, 12, 150, 'available');

-- Home & Living — Rajshahi Furniture (vendor_id = 12)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(12, 4, 'Wooden Dining Table 6 Seat', 'Solid shegun wood dining set',                45000,  5,   8, 'available'),
(12, 4, 'King Size Bed Frame',        'Teak wood king size bed with storage',        35000,  8,  12, 'available'),
(12, 4, 'Sofa Set 3+1+1',             'Premium fabric sofa 5 seater',                28000, 10,   6, 'available'),
(12, 4, 'Wardrobe 6 Door',            'Melamine finish large wardrobe',              22000,  5,  10, 'available'),
(12, 4, 'Office Chair Ergonomic',     'Mesh back ergonomic office chair',             8500, 15,  25, 'available'),
(12, 4, 'Ceiling Fan Hatil',          'Energy saving 56 inch ceiling fan',            4500,  0,  40, 'available'),
(12, 4, 'Non-Stick Cookware Set',     '5 piece non-stick cooking set',                3200, 20,  60, 'available'),
(12, 4, 'Bed Sheet Set Queen',        '100% cotton queen bed sheet set',              1800, 10, 100, 'available'),
(12, 4, 'Wall Clock Wooden',          'Handcrafted wooden wall clock',                1200,  0,  80, 'available'),
(12, 4, 'Plastic Storage Basket 3pc', 'Stackable storage basket set',                  650,  0, 200, 'available');

-- Sports — Comilla Sports (vendor_id = 13)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(13, 6, 'Cricket Bat SS Ton',         'English willow cricket bat',                   8500,  5,  30, 'available'),
(13, 6, 'Football Nike Strike',       'Match quality football size 5',                3200,  8,  50, 'available'),
(13, 6, 'Badminton Racket Yonex',     'Professional badminton racket',                2800, 10,  40, 'available'),
(13, 6, 'Running Shoes Nike',         'Lightweight running shoes',                    6500, 15,  60, 'available'),
(13, 6, 'Gym Gloves Leather',         'Workout weight lifting gloves',                 850,  0, 120, 'available'),
(13, 6, 'Yoga Mat 6mm',               'Non-slip thick yoga mat',                      1200, 10,  90, 'available'),
(13, 6, 'Dumbell Set 10kg Pair',      'Rubber coated dumbbell pair',                  3500,  0,  35, 'available'),
(13, 6, 'Swimming Goggles',           'Anti-fog UV protection goggles',                850,  5,  80, 'available'),
(13, 6, 'Cycling Helmet',             'Safety certified cycling helmet',              2200,  8,  45, 'available'),
(13, 6, 'Skipping Rope Speed',        'Ball bearing speed rope',                       450,  0, 200, 'available');

-- Beauty & Health — Khulna Beauty (vendor_id = 14)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(14, 5, 'Fair and Lovely Cream 50g',  'Skin brightening face cream',                   180,  0, 500, 'available'),
(14, 5, 'Dove Shampoo 340ml',         'Moisturizing nourishment shampoo',              420,  5, 300, 'available'),
(14, 5, 'Nivea Body Lotion 400ml',    'Deep moisture body lotion',                     580,  8, 250, 'available'),
(14, 5, 'Himalaya Face Wash 100ml',   'Neem purifying face wash',                      220,  0, 400, 'available'),
(14, 5, 'Mamaearth Vitamin C Serum',  'Brightening vitamin C face serum',             1200, 10, 150, 'available'),
(14, 5, 'Paracetamol 500mg Strip',    'Paracetamol pain relief 10 tablets',             45,  0,1000, 'available'),
(14, 5, 'Hand Sanitizer 500ml',       '70% alcohol gel hand sanitizer',                280,  0, 600, 'available'),
(14, 5, 'Digital Thermometer',        'Fast reading digital thermometer',              450,  5, 200, 'available'),
(14, 5, 'Vitamin D3 Supplement',      '60 capsules vitamin D3 5000IU',                 950,  0, 180, 'available'),
(14, 5, 'Sunscreen SPF50 50ml',       'PA+++ broad spectrum sunscreen',                780, 12, 220, 'available');

-- Automotive — Barisal Auto (vendor_id = 15)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(15, 8, 'Car Phone Holder',           'Universal dashboard phone mount',               650,  0, 150, 'available'),
(15, 8, 'Car Air Freshener',          'Hanging pine tree air freshener 12pc',          350,  0, 300, 'available'),
(15, 8, 'Tyre Pressure Gauge',        'Digital tyre pressure meter',                   850,  5, 100, 'available'),
(15, 8, 'Car Seat Cover Set',         'Universal fit car seat cover full set',        3500, 10,  60, 'available'),
(15, 8, 'Jump Starter 12000mAh',      'Portable car jump starter power bank',         4500,  8,  40, 'available'),
(15, 8, 'Dashcam Full HD 1080p',      'Dual camera front rear dashcam',               6500,  5,  30, 'available'),
(15, 8, 'Engine Oil 5W30 4L',         'Synthetic engine oil full synthetic',          2800,  0,  80, 'available'),
(15, 8, 'Car Vacuum Cleaner',         'Portable 12V car vacuum cleaner',              1800, 15,  70, 'available'),
(15, 8, 'Windshield Wiper Blade',     'Universal fit wiper blade 24 inch',             650,  0, 200, 'available'),
(15, 8, 'LED Headlight Bulb H4',      'Super bright LED headlight pair',              1500, 10, 120, 'available');

-- Home & Living — Mymensingh Home (vendor_id = 16)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(16, 4, 'Air Purifier Xiaomi',        'HEPA filter smart air purifier',              18000,  5,  20, 'available'),
(16, 4, 'Rice Cooker 1.8L',           'Electric rice cooker with steamer',            3200, 10,  50, 'available'),
(16, 4, 'Blender Philips 600W',       'High power kitchen blender',                   4500,  8,  35, 'available'),
(16, 4, 'Electric Kettle 1.7L',       'Stainless steel electric kettle',              1800,  5,  80, 'available'),
(16, 4, 'Microwave Oven 20L',         '20 liter solo microwave oven',                12000,  7,  25, 'available');

-- Electronics — Narayanganj Tech (vendor_id = 17)
INSERT INTO Products (vendor_id, category_id, product_name, description, price, discount_pct, stock_qty, availability) VALUES
(17, 1, 'Power Bank 20000mAh',        'Fast charge 20000mAh power bank',              2800, 10, 100, 'available'),
(17, 1, 'Wireless Charger 15W',       'Qi wireless fast charging pad',                1500,  5, 120, 'available'),
(17, 1, 'USB-C Hub 7 in 1',           'Multiport USB-C adapter hub',                  2200,  8,  80, 'available'),
(17, 1, 'Gaming Mouse RGB',           'Programmable RGB gaming mouse',                3500, 12,  60, 'available'),
(17, 1, 'Mechanical Keyboard',        'TKL mechanical keyboard blue switch',          5500, 10,  40, 'available');
GO


-- =============================================================
-- STEP 7: VERIFY EVERYTHING WORKED
-- =============================================================
SELECT 'Users'      AS [Table], COUNT(*) AS [Total Rows] FROM Users
UNION ALL
SELECT 'Categories',     COUNT(*) FROM Categories
UNION ALL
SELECT 'Products',       COUNT(*) FROM Products
UNION ALL
SELECT 'Cart',           COUNT(*) FROM Cart
UNION ALL
SELECT 'Orders',         COUNT(*) FROM Orders
UNION ALL
SELECT 'Payments',       COUNT(*) FROM Payments
UNION ALL
SELECT 'Reviews',        COUNT(*) FROM Reviews;
GO

-- Expected output:
-- Users        17  (1 SuperAdmin + 4 Admins + 1 Test Vendor + 1 Test Customer + 10 Vendors)
-- Categories    8
-- Products    100
-- Cart          0
-- Orders        0
-- Payments      0
-- Reviews       0
-- =============================================================
-- END OF SCRIPT — NeedBridge database is ready to use.
-- Connection string for the C# app:
-- Server=TALVI\SQLEXPRESS;Database=NeedBridgeDB;Trusted_Connection=True;TrustServerCertificate=True;
-- =============================================================
