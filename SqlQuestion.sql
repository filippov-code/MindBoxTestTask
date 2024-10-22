/*
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

--Создадим БД
CREATE DATABASE mindbox_shop;
USE mindbox_shop;

--Создадим таблицы категорий и товаров
CREATE TABLE products
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(30) NOT NULL
)

CREATE TABLE categories
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(30) NOT NULL
)

--Заполним таблицы
INSERT categories VALUES 
('Газированные напитки'),
('Напитки без сахара'),
('Сладкие напитки'),
('Полезные напитки'),
('Алкогольные напитки');

INSERT products VALUES 
('Coca-Cola'),
('Вино'),
('Йогурт'),
('Вода'),
('Сок'),
('Чипсы');

--Создадим промежуточную таблицу и настроим связи с уже созданными
CREATE TABLE category_product
(
	id INT IDENTITY NOT NULL PRIMARY KEY,
    category_id INT NOT NULL FOREIGN KEY REFERENCES categories(Id),
    product_id INT NOT NULL FOREIGN KEY REFERENCES products(Id)
);

--Установим соответствие категорий и товаров
INSERT category_product
(category_id, product_id) 
VALUES
(1, 1),
(2, 4),
(3, 1), (3, 3), (3, 5),
(4, 3), (4, 4), (4, 5),
(5, 2);

--Выполним запрос
SELECT 
    p.name AS 'Имя продукта',
    c.name AS 'Имя категории'
FROM products p
    LEFT JOIN category_product cp ON cp.product_id = p.id
    LEFT JOIN categories c ON cp.category_id = c.id;


