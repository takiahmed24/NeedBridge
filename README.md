# NeedBridge-.NET

CASE STUDY: NeedBridge is a comprehensive multi-vendor e-commerce platform that connects customers with vendors, similar to Daraz, Bikroy, and Alibaba. Users have the ability to browse products based on a variety of criteria, filter by category and price, add items to cart, and purchase directly. Each user possesses pertinent information such as their name, username, email, phone number, and address.

Every product within the system is uniquely identified by its ID and encompasses details such as the product name, description, category, price, discount percentage, stock quantity, image, and availability status. Multiple vendors participate within the system, each capable of listing and managing diverse products. However, each product is exclusively associated with a single vendor. Vendors are characterized by their ID, name, address, and contact information.

The system operates under the oversight of a SuperAdmin who holds full control over the platform — creating and managing admin accounts, overseeing all vendors, customers, and platform-wide reports. Admins manage day-to-day operations including vendor/customer management, reviews, disputes, discounts, and sales reporting.

FUNCTIONALITIES:

After Login a customer can browse and search all products with filtering by category and price.
Can view full product details, reviews, and ratings.
The customer can add products to cart or Buy Now with quantity selection.
Can make payment via bKash, Nagad, Rocket, Card, or Cash on Delivery.
Can track order status: Placed → Confirmed → Shipped → Out for Delivery → Delivered.
Can cancel orders or request returns, and write star reviews after purchase.
There is a profile section where users can see and update their details and change password.
Vendors can add, edit, and delete their own products with image support.
They can track their orders and update delivery status for each order.
They can monitor stock levels and view earnings reports filtered by time period.
An Admin can see all vendors and customers with their full details and manage their accounts.
Admin can manage reviews, handle disputes, set discounts on any product, and view platform-wide sales reports.
SuperAdmin can create, suspend, activate, and delete admin accounts and view full platform-wide statistics.

DATABASE SCHEMA: SQL Query:

```sql
create database NeedBridgeDB;

create table Users (
    user_id    int primary key identity(1,1),
    full_name  nvarchar(100) not null,
    username   nvarchar(50)  not null unique,
    password   nvarchar(100) not null,
    email      nvarchar(100),
    phone      nvarchar(20),
    address    nvarchar(255),
    user_type  nvarchar(20)  not null,
    status     nvarchar(20)  default 'active',
    created_at datetime      default getdate()
)

create table Categories (
    category_id   int primary key identity(1,1),
    category_name nvarchar(100) not null,
    description   nvarchar(255)
)

create table Products (
    product_id   int primary key identity(1,1),
    vendor_id    int not null,
    category_id  int not null,
    product_name nvarchar(150) not null,
    description  nvarchar(500),
    price        decimal(10,2) not null,
    discount_pct decimal(5,2)  default 0,
    stock_qty    int           default 0,
    image_path   nvarchar(255),
    availability nvarchar(20)  default 'available',
    created_at   datetime      default getdate(),
    foreign key (vendor_id)   references Users(user_id),
    foreign key (category_id) references Categories(category_id)
)

create table Cart (
    cart_id     int primary key identity(1,1),
    customer_id int not null,
    product_id  int not null,
    quantity    int not null default 1,
    added_at    datetime default getdate(),
    foreign key (customer_id) references Users(user_id),
    foreign key (product_id)  references Products(product_id)
)

create table Orders (
    order_id         int primary key identity(1,1),
    customer_id      int not null,
    product_id       int not null,
    vendor_id        int not null,
    quantity         int not null,
    total_price      decimal(10,2) not null,
    order_status     nvarchar(30)  default 'Placed',
    payment_method   nvarchar(30),
    delivery_address nvarchar(255),
    order_date       datetime      default getdate(),
    updated_at       datetime      default getdate(),
    foreign key (customer_id) references Users(user_id),
    foreign key (product_id)  references Products(product_id),
    foreign key (vendor_id)   references Users(user_id)
)

create table Payments (
    payment_id      int primary key identity(1,1),
    order_id        int not null,
    customer_id     int not null,
    amount          decimal(10,2) not null,
    payment_method  nvarchar(30) not null,
    transaction_ref nvarchar(100),
    payment_status  nvarchar(20) default 'completed',
    payment_date    datetime     default getdate(),
    foreign key (order_id)    references Orders(order_id),
    foreign key (customer_id) references Users(user_id)
)

create table Reviews (
    review_id   int primary key identity(1,1),
    customer_id int not null,
    product_id  int not null,
    order_id    int not null,
    rating      int not null,
    comment     nvarchar(500),
    review_date datetime default getdate(),
    foreign key (customer_id) references Users(user_id),
    foreign key (product_id)  references Products(product_id),
    foreign key (order_id)    references Orders(order_id)
)

select * from Users;
select * from Categories;
select * from Products;
select * from Cart;
select * from Orders;
select * from Payments;
select * from Reviews;

insert into Users (full_name, username, password, email, phone, address, user_type, status)
values ('Muhammad Taki Ahmed', 'taki', 'taki1234', 'taki@needbridge.com', '01700000001', 'Dhaka', 'superadmin', 'active')
```

Database Schema:

*(screenshot to be added)*

ER DIAGRAM:

*(screenshot to be added)*

Login Page:

*(screenshot to be added)*

Register Page:

*(screenshot to be added)*

Customer Home:

*(screenshot to be added)*

Product Details:

*(screenshot to be added)*

Cart Page:

*(screenshot to be added)*

Payment Page:

*(screenshot to be added)*

My Orders:

*(screenshot to be added)*

Write Review:

*(screenshot to be added)*

Customer Profile:

*(screenshot to be added)*

Vendor Dashboard:

*(screenshot to be added)*

Vendor My Products:

*(screenshot to be added)*

Vendor Add Product:

*(screenshot to be added)*

Vendor Orders:

*(screenshot to be added)*

Vendor Stock Dashboard:

*(screenshot to be added)*

Vendor Earnings Report:

*(screenshot to be added)*

Admin Dashboard:

*(screenshot to be added)*

Admin Manage Vendors:

*(screenshot to be added)*

Admin Manage Customers:

*(screenshot to be added)*

Admin Manage Reviews:

*(screenshot to be added)*

Admin Dispute Center:

*(screenshot to be added)*

Admin Sales Report:

*(screenshot to be added)*

Admin Manage Discounts:

*(screenshot to be added)*

Admin Stock Overview:

*(screenshot to be added)*

SuperAdmin Control Panel:

*(screenshot to be added)*

SuperAdmin Manage Admins:

*(screenshot to be added)*