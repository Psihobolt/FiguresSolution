-- Create example
CREATE TABLE Product(
  id INT PRIMARY KEY,
  name VARCHAR(255));
  
CREATE TABLE Category(
  id INT PRIMARY KEY,
  name VARCHAR(255))
  
 CREATE TABLE CategoryProducts(
   id INT PRIMARY KEY,
   productId INT NOT NULL 
		FOREIGN KEY REFERENCES Product(id),
   categoryId INT NOT NULL 
		FOREIGN KEY REFERENCES Category(id))

-- Temporary data
INSERT INTO Product(id, name)
VALUES(1, 'Product 1'),
(2, 'Product 2'),
(3, 'Product 3'),
(4, 'Product 4');

INSERT INTO Category(id, name)
VALUES(1, 'Category 1'),
(2, 'Category 2'),
(3, 'Category 3'),
(4, 'Category 4');

INSERT INTO CategoryProducts(id, productid, categoryid)
values (1, 1, 1),
(2, 1, 2),
(3, 2, 2),
(4, 2, 3),
(5, 2, 4),
(6, 3, 1);

-- Need Select 
SELECT p.name, c.name FROm Product p
LEFT JOIN CategoryProducts cp
   	ON p.id = cp.productId
LEFT JOIN Category c
	ON cp.categoryId = c.id;