-- Create the database
CREATE DATABASE starbuko;

-- Switch to the newly created database
USE starbuko;

-- Create the Products table
CREATE TABLE Products (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    productName VARCHAR(255) NOT NULL DEFAULT '',
    Price DECIMAL(10,2) NOT NULL DEFAULT 0.00,
    Image VARCHAR(255) NOT NULL DEFAULT ''
);

-- Insert the product data
INSERT INTO Products (productName, Price, ImagePath)
VALUES 
    ('Creamy Pure Matcha Latte', 180.00, 'Images/matcha_latte.jpeg'),
    ('XOXO Frappuccino', 150.00, 'Images/xoxo_frappucino.jpeg'),
    ('Strawberry Açaí with Lemonade', 160.00, 'Images/strawberry_acai.jpeg'),
    ('Pink Drink with Strawberry Açaí', 165.00, 'Images/pink_drink.jpeg'),
    ('Dragon Drink with Mango Dragonfruit', 170.00, 'Images/dragon_drink.jpeg'),
    ('Strawberries & Cream Frappuccino', 175.00, 'Images/strawberries_cream.jpg'),
    ('Chocolate Chip Cream Frappuccino', 180.00, 'Images/chocolate_chip.jpg'),
    ('Dark Caramel Coffee Frappuccino', 170.00, 'Images/dark_caramel_frappucino.jpg');