/*
� ���� ������ MS SQL Server ���� �������� � ���������. 
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. 
�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
*/

--�������� ��
CREATE DATABASE mindbox_shop;
USE mindbox_shop;

--�������� ������� ��������� � �������
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

--�������� �������
INSERT categories VALUES 
('������������ �������'),
('������� ��� ������'),
('������� �������'),
('�������� �������'),
('����������� �������');

INSERT products VALUES 
('Coca-Cola'),
('����'),
('������'),
('����'),
('���'),
('�����');

--�������� ������������� ������� � �������� ����� � ��� ����������
CREATE TABLE category_product
(
	id INT IDENTITY NOT NULL PRIMARY KEY,
    category_id INT NOT NULL FOREIGN KEY REFERENCES categories(Id),
    product_id INT NOT NULL FOREIGN KEY REFERENCES products(Id)
);

--��������� ������������ ��������� � �������
INSERT category_product
(category_id, product_id) 
VALUES
(1, 1),
(2, 4),
(3, 1), (3, 3), (3, 5),
(4, 3), (4, 4), (4, 5),
(5, 2);

--�������� ������
SELECT 
    p.name AS '��� ��������',
    c.name AS '��� ���������'
FROM products p
    LEFT JOIN category_product cp ON cp.product_id = p.id
    LEFT JOIN categories c ON cp.category_id = c.id;


