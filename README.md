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

DATABASE SCHEMA:

Full SQL script: [NeedBridgeDB.sql](./NeedBridgeDB.sql)

Run this file in SQL Server Management Studio (SSMS) to create the database with all tables and sample data.

Database Schema:

<img width="1536" height="1024" alt="SCHEMA DIAGRAM" src="https://github.com/user-attachments/assets/df715763-04c8-4e66-8f94-592eacbeeb85" />


ER DIAGRAM:

<img width="1536" height="1024" alt="ER DIAGRAM" src="https://github.com/user-attachments/assets/36a02bc7-f476-47bb-afc1-b147ec98c6f1" />


Login Page:

<img width="879" height="617" alt="Screenshot 2026-05-18 120033" src="https://github.com/user-attachments/assets/6c77ae66-28c5-4095-80de-d04f54cd1151" />


Register Page:

<img width="819" height="704" alt="Screenshot 2026-05-18 120310" src="https://github.com/user-attachments/assets/765415c5-25e7-4a96-87f7-6a79a77dd6bc" />


Customer Home:

<img width="1151" height="759" alt="image" src="https://github.com/user-attachments/assets/280f671d-7a6a-4b3f-91de-11aa3fa4856f" />


Product Details:

<img width="1082" height="753" alt="Screenshot 2026-05-18 120248" src="https://github.com/user-attachments/assets/29bf339b-48c1-46ba-828b-ac8f37ea5a78" />

Cart Page:

<img width="858" height="610" alt="Screenshot 2026-05-18 120120" src="https://github.com/user-attachments/assets/f0ea0122-3a75-42ef-9530-a6f39efc7852" />

Payment Page:

<img width="621" height="655" alt="Screenshot 2026-05-18 120241" src="https://github.com/user-attachments/assets/1f07de8a-e61c-47b8-adef-6dafd512af86" />

My Orders:

<img width="946" height="671" alt="image" src="https://github.com/user-attachments/assets/0be9cc31-31bb-4327-baf5-2a3efced2481" />


Write Review:

<img width="570" height="613" alt="Screenshot 2026-05-18 120428" src="https://github.com/user-attachments/assets/f2d620e7-077c-4789-83ca-5e8f0e9e3467" />

Customer Profile:

<img width="631" height="788" alt="Screenshot 2026-05-18 120302" src="https://github.com/user-attachments/assets/be20117b-df1c-4988-bccb-af47636b6753" />

Vendor Dashboard:

<img width="1176" height="776" alt="Screenshot 2026-05-18 120400" src="https://github.com/user-attachments/assets/03dd9883-aa02-44af-a37a-9b6aae67b48a" />

Vendor My Products:

<img width="1147" height="739" alt="Screenshot 2026-05-18 120421" src="https://github.com/user-attachments/assets/6e5e2d8f-707c-46c3-b2b9-7cb24635aa52" />

Vendor Add Product:

<img width="669" height="758" alt="image" src="https://github.com/user-attachments/assets/df251c0f-ec9d-4e96-874b-40d9219a1056" />


Vendor Orders:

<img width="1021" height="667" alt="Screenshot 2026-05-18 120408" src="https://github.com/user-attachments/assets/1fcfbb11-d1ff-4224-b36c-568591a38f39" />

Vendor Stock Dashboard:

<img width="951" height="728" alt="image" src="https://github.com/user-attachments/assets/d63d685d-0381-481f-8157-8be7817894a5" />


Vendor Earnings Report:

<img width="949" height="722" alt="Screenshot 2026-05-18 120138" src="https://github.com/user-attachments/assets/7eea236d-1b6c-490b-aa4a-1e0d5de638a6" />

Admin Dashboard:

<img width="1158" height="760" alt="Screenshot 2026-05-18 120103" src="https://github.com/user-attachments/assets/9d1cbd3f-613e-47ac-9eca-93ded4fb97b4" />

Admin Manage Users:

<img width="1014" height="673" alt="image" src="https://github.com/user-attachments/assets/e67923b1-f3c8-4dc7-a8f4-8819efe33b8e" />


Admin Manage Reviews:

<img width="1029" height="683" alt="Screenshot 2026-05-18 120209" src="https://github.com/user-attachments/assets/c891b302-b62e-4a06-8c82-77f690f89782" />

Admin Dispute Center:

<img width="1014" height="688" alt="Screenshot 2026-05-18 120201" src="https://github.com/user-attachments/assets/aa455bf9-b41c-4fa1-b7c6-7538425589f7" />

Admin Sales Report:

<img width="967" height="707" alt="Screenshot 2026-05-18 120320" src="https://github.com/user-attachments/assets/d08c1b76-1b80-4569-80fe-80a021a55163" />

Admin Manage Discounts:
<img width="1014" height="684" alt="image" src="https://github.com/user-attachments/assets/b8ced340-ceb4-4c2e-8b54-602846ed8263" />

Admin Stock Overview:

<img width="1001" height="713" alt="Screenshot 2026-05-18 120111" src="https://github.com/user-attachments/assets/4a39a732-d1eb-4660-b893-d802b1aa2596" />

SuperAdmin Control Panel:

<img width="1152" height="755" alt="Screenshot 2026-05-18 120341" src="https://github.com/user-attachments/assets/cf0ffd5d-8a7c-447e-816b-926a39f084c3" />

SuperAdmin Manage Admins:

<img width="1130" height="741" alt="Screenshot 2026-05-18 120348" src="https://github.com/user-attachments/assets/4490a136-73c7-40a0-aec4-a8bdb91efdff" />
