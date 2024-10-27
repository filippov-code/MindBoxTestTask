/*
� ���� ������ MS SQL Server ���� �������� � ���������. 
������ �������� ����� ��������������� ����� ���������, � ����� ��������� ����� ���� ����� ���������. 
�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.
*/

--�������� ��
CREATE DATABASE mindbox_shop;
GO 

USE mindbox_shop;
GO

--�������� ������� ��������� � �������
CREATE TABLE products
(
    id INT IDENTITY(1, 1),
    name NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_products PRIMARY KEY (id)
);
GO

CREATE TABLE categories
(
    id INT IDENTITY(1, 1),
    name NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_categories PRIMARY KEY (id)
)
GO

--�������� �������
INSERT categories 
(name)
VALUES 
('������������ �������'),
('������� ��� ������'),
('������� �������'),
('�������� �������'),
('����������� �������');
GO

INSERT products 
(name)
VALUES 
('Coca-Cola'),
('����'),
('������'),
('����'),
('���'),
('�����');
GO

--�������� ������������� ������� � �������� ����� � ��� ����������
CREATE TABLE category_product
(
    category_id INT NOT NULL ,
    product_id INT NOT NULL,
    CONSTRAINT pk_category_product PRIMARY KEY (category_id, product_id),
	CONSTRAINT fk_category_product__category_id FOREIGN KEY (category_id) REFERENCES categories(Id),
	CONSTRAINT fk_category_product__product_id FOREIGN KEY (product_id) REFERENCES products(Id),
);
GO

--��������� ������������ ��������� � �������
INSERT category_product
(category_id, product_id) 
VALUES
(1, 1),
(2, 4),
(3, 1), (3, 3), (3, 5),
(4, 3), (4, 4), (4, 5),
(5, 2);
GO

--�������� ������
SELECT 
    p.name AS '��� ��������',
    c.name AS '��� ���������'
FROM products p
    LEFT JOIN category_product cp ON cp.product_id = p.id
    LEFT JOIN categories c ON cp.category_id = c.id;
GO