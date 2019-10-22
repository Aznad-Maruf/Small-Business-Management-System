
CREATE DATABASE Project1DB;
USE Project1DB;

CREATE TABLE Category(
Code VARCHAR(255) PRIMARY KEY,
Name VARCHAR(255) UNIQUE NOT NULL
)

INSERT INTO Category (Code, Name) VALUES ('1000', 'Mobile');
INSERT INTO Category (Code, Name) VALUES ('1001', 'Desktop');
INSERT INTO Category (Code, Name) VALUES ('1002', 'Laptop');
INSERT INTO Category (Code, Name) VALUES ('1003', 'Motherboard');
INSERT INTO Category (Code, Name) VALUES ('1004', 'Keyboard');
INSERT INTO Category (Code, Name) VALUES ('1005', 'Soundbox');
INSERT INTO Category (Code, Name) VALUES ('1006', 'Monitor');
INSERT INTO Category (Code, Name) VALUES ('1007', 'Headphone');


CREATE TABLE Product(
Code VARCHAR(255) PRIMARY KEY,
Name VARCHAR(255) UNIQUE NOT NULL,
Category VARCHAR(255) NOT NULL,
ReorderLevel INT NOT NULL,
Description TEXT,

CONSTRAINT FK_Category FOREIGN KEY (Category) REFERENCES Category(Code)
)

INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1000', 'Samsung Galaxy Y', '1000', 100, 'Old is gold');
INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1001', 'Samsung Galaxy S', '1000', 50, 'New is smart');
INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1002', 'iPhone 8', '1000', 80, 'Elegant');
INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1003', 'Nokia 800 Tough', '1000', 200, 'Daddy is back.');
INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1004', 'JBL Everest Elite 750NC', '1007', 100, 'Take a sound adventure with us');
INSERT INTO Product (Code, Name, Category, ReorderLevel, Description) VALUES ('1005', 'Apple iMac 21.5" MMQA2', '1001', 150, 'It''s Apple!');


CREATE TABLE Customer(
Code VARCHAR(255) PRIMARY KEY,
Name VARCHAR(255) NOT NULL,
Address VARCHAR(255),
Email VARCHAR(255) UNIQUE NOT NULL,
Contact VARCHAR(255) UNIQUE NOT NULL,
LoyalityPoint NUMERIC(18,2) NOT NULL
)

INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1000', 'Kodu Mia', 'Mirpur 12', 'kuddu@yahoo.com', '01527558885', 25);
INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1001', 'Kuddus Mia', 'Mirpur 10', 'kuddusmia22@yahoo.com', '01527555555', 25);
INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1002', 'Sukkur Mia', 'Azimpur', 'sukkurMiaisBeauty@yahoo.com', '01527588555', 15);
INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1003', 'Ful Banu', 'Mirpur 11.5', 'flowerBanu@gmail.com', '01927555555', 29);
INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1004', 'Bilkiss', 'Azimpur', 'killbill@yahoo.com', '01520555555', 120);
INSERT INTO Customer(Code, Name, Address, Email, Contact, LoyalityPoint) VALUES ('1005', 'Jordan', 'Uttara', 'imjordan@gmail.com', '01527555999', 254);


CREATE TABLE Supplier(
Code VARCHAR(255) PRIMARY KEY,
Name VARCHAR(255) UNIQUE NOT NULL,
Address VARCHAR(255),
Email VARCHAR(255) UNIQUE NOT NULL,
Contact VARCHAR(255) UNIQUE NOT NULL,
ContactPerson VARCHAR(255)
)

INSERT INTO Supplier(Code, Name, Address, Email, Contact, ContactPerson) VALUES ('1001', 'OK Mobile Bangladesh Limited', 'Mirpur 10', 'kuddusmia22@yahoo.com', '01527555555', '01527578555');
INSERT INTO Supplier(Code, Name, Address, Email, Contact, ContactPerson) VALUES ('1002', 'Famous BD', 'Bonani', 'korim@yahoo.com', '01527478555', '01527008555');
INSERT INTO Supplier(Code, Name, Address, Email, Contact) VALUES ('1003', 'Nasrin TElecom', 'Dhanmondi', 'nasrimabcd@gmail.com', '01527478885');
INSERT INTO Supplier(Code, Name, Address, Email, Contact, ContactPerson) VALUES ('1004', 'Best Electronics', 'Mirpur 10', 'be@yahoo.com', '01527555874', '01527578545');
INSERT INTO Supplier(Code, Name, Address, Email, Contact, ContactPerson) VALUES ('1005', 'Samsung BD', 'Mirpur 10', 'samsam@gamil.com', '01527559999', '01527578999');


CREATE TABLE Sales(
	SalesCode INT IDENTITY(20190001,1),
	Date DATE NOT NULL,
	Customer VARCHAR(255) NOT NULL,
	Category VARCHAR(255) NOT NULL,
	Product VARCHAR(255) NOT NULL,
	Quantity NUMERIC(18,2) NOT NULL,
	MRP NUMERIC(18,2) NOT NULL,
	CONSTRAINT PK_Sales PRIMARY KEY(SalesCode),
	CONSTRAINT FK_CustomerS FOREIGN KEY(Customer) REFERENCES Customer(Code),
	CONSTRAINT FK_CategoryS FOREIGN KEY(Category) REFERENCES Category(Code),
	CONSTRAINT FK_ProductS FOREIGN KEY(Product) REFERENCES Product(Code)
)

SET DATEFORMAT 'dmy';

INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('03-OCT-1999', '1000', '1001', '1000', '200', '200');
INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('2018-12-09', '1000', '1003', '1004', '2', '200');
INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('2018-08-03', '1003', '1000', '1002', '3', '200');
INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('2018-07-13', '1004', '1000', '1003', '1', '300');
INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('2018-07-23', '1001', '1003', '1004', '1', '100');
INSERT INTO Sales(Date, Customer, Category, Product, Quantity, MRP) VALUES ('2018-07-23', '1001', '1001', '1003', '43', '20');


CREATE TABLE Purchase(
	PurchaseCode INT IDENTITY(20190001,1),
	InvoiceNo VARCHAR(255) NOT NULL UNIQUE,
	Date DATE NOT NULL,
	Supplier VARCHAR(255) NOT NULL,
	Category VARCHAR(255) NOT NULL,
	Product VARCHAR(255) NOT NULL,
	ManufactureDate DATE,
	ExpireDate DATE,
	Quantity NUMERIC(18,2) NOT NULL,
	UnitPrice NUMERIC(18,2) NOT NULL,
	MRP NUMERIC(18,2) NOT NULL,
	Remarks TEXT,

	CONSTRAINT PK_Purchase PRIMARY KEY(PurchaseCode),
	CONSTRAINT FK_SupplierP FOREIGN KEY(Supplier) REFERENCES Supplier(Code),
	CONSTRAINT FK_CategoryP FOREIGN KEY(Category) REFERENCES Category(Code),
	CONSTRAINT FK_ProductP FOREIGN KEY(Product) REFERENCES Product(Code)
)

INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('2929cc', '2018-07-23', '1002', '1001', '1005', '2009-02-11', '250', '70000', '90000', 'Sell kom lav besi.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, ExpireDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('29287pc', '2018-07-23', '1003', '1000', '1000', '2007-01-01', '2017-12-30','500', '7000', '9500', 'Sell besi lav kom.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('77729cc', '2018-07-29', '1003', '1000', '1003', '2019-08-01', '550', '2000', '5000', 'Sell besi lav besi.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('292589cy', '2018-07-23', '1004', '1003', '1004', '2005-07-21', '750', '500', '1000', 'Sell besi lav mondo na.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('aa29cc', '2019-01-03', '1001', '1000', '1002', '2010-02-01', '1050', '25000', '45000', 'Sell kom lav valoi.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('888829cc', '2018-07-23', '1002', '1001', '1005', '2009-02-11', '250', '70000', '90000', 'Sell kom lav besi.');
INSERT INTO Purchase(InvoiceNo, Date, Supplier, Category, Product, ManufactureDate, Quantity, UnitPrice, MRP, Remarks) VALUES ('u9l29cc', '2018-07-23', '1002', '1000', '1003', '2009-02-11', '1', '70000', '90000', 'Sell kom lav besi.');

SELECT * FROM Supplier;
SELECT * FROM Product;
SELECT * FROM Category;

/*------------ Select queries -------*/
--Category--
SELECT Code, Name FROM Category;
--Product--
SELECT Code, Name, Category, ReorderLevel AS 'Reorder Level', Description FROM Product;
--Customer--
SELECT Code, Name, Address, Email, Contact, LoyalityPoint AS 'Loyalty Point' FROM Customer;
--Supplier--
SELECT Code, Name, Address, Email, Contact, ContactPerson AS 'Contact Person' FROM Supplier;
--Purchase--
SELECT Product AS 'Products(Code)', ManufactureDate AS 'Manufactured Date', ExpireDate AS 'Expired Date', Quantity, UnitPrice AS 'Unit Price(Tk)', UnitPrice*Quantity AS 'Total Price(Tk)', MRP AS 'MRP(Tk)', Remarks FROM Purchase;
SELECT LoyalityPoint FROM Customer WHERE Code = '1000';
SELECT MRP FROM Purchase WHERE Category = '1000' AND Product = '1000';
UPDATE Customer SET LoyalityPoint = '22' Where Code = '1000';
--Sales--


----------- Combined ----------
SELECT Name + '(' + Code + ')' AS Category FROM Category
SELECT Name + '(' + Code + ')' AS Produt FROM Product WHERE Category = '1000'

SELECT Quantity FROM Available WHERE Category = '1000' AND Product = '1000';


/*
CREATE VIEW AvailableTemp AS
SELECT P.Category AS Category, P.Product AS Product, P.Quantity AS PQ, S.Quantity AS SQ,
CASE
	WHEN S.Quantity IS NULL THEN P.Quantity
	ELSE P.Quantity-S.Quantity
END AS AvailableQuantity
FROM Purchase AS P LEFT JOIN Sales AS S ON P.Product = S.Product AND P.Category = S.Category;

CREATE VIEW Available AS
SELECT Category, Product, SUM(AvailableQuantity)AS Quantity FROM AvailableTemp GROUP BY Category, Product;

CREATE VIEW Available AS
SELECT P.Product, AvailableQuantity AS Quantity
FROM
SELECT P.Product AS Product,
CASE
	WHEN S.Quantity IS NULL THEN P.Quantity
	ELSE P.Quantity-S.Quantity
END AS AvailableQuantity
FROM Purchase AS P LEFT JOIN Sales AS S ON P.Product = S.Product GROUP BY P.Product;

SELECT P.Product AS Product, SUM(P.Quantity) AS PQ, SUM(S.Quantity) AS SQ 
FROM Purchase AS P LEFT JOIN Sales AS S ON P.Product = S.Product GROUP BY P.Product;

SELECT Product, PQ FROM 
 SELECT Category, Product,SUM(Quantity) AS PQ FROM Purchase GROUP BY  Category,Product;

 SELECT Product, SQ FROM 
 SELECT Category, Product,SUM(Quantity) AS SQ FROM Sales GROUP BY  Category,Product;

 SELECT P.Category AS Category, P.Product AS Product, SUM(P.Quantity)-SUM(S.Quantity) AS AvailableQuantity 
 FROM Purchase AS P LEFT JOIN Sales AS S ON P.Category = S.Category AND P.Product = S.Product GROUP BY P.Category, P.Product;

 SELECT P.Category AS Category, P.Product AS Product, P.Quantity AS PQ, S.Quantity AS SQ
 FROM Purchase AS P LEFT JOIN Sales AS S ON P.Category = S.Category AND P.Product = S.Product GROUP BY P.Category, P.Product;


 SELECT P.Category, P.Product, SUM(P.Quantity) AS PQ FROM Purchase AS P GROUP BY P.Category, P.Product;
 SELECT S.Category, S.Product, SUM(S.Quantity) AS SQ FROM Sales AS S GROUP BY S.Category, S.Product;
*/

 CREATE VIEW Available AS
 SELECT Pro.PC AS Category, Pro.PP AS Product, 
 CASE 
	WHEN SQ IS NULL THEN PQ
	ELSE PQ-SQ
 END AS Quantity FROM
	(SELECT P.Category AS PC, P.Product AS PP, SUM(P.Quantity) AS PQ FROM Purchase AS P GROUP BY P.Category, P.Product) AS Pro
		LEFT JOIN
		(SELECT S.Category AS SC, S.Product AS SP, SUM(S.Quantity) AS SQ FROM Sales AS S GROUP BY S.Category, S.Product) AS Sal 
		ON Pro.PC=Sal.SC AND Pro.PP=Sal.SP;

/*
SELECT * FROM Customer;
SELECT * FROM Sales;
SELECT * FROM Purchase;
SELECT * FROM AvailableTemp;
SELECT * FROM Available;
SELECT * FROM Available ORDER BY Category;
*/

/*
DROP TABLE Sales;
DROP TABLE Purchase;
DROP TABLE Product;
DROP TABLE Customer;
DROP VIEW AvailableTemp;
DROP VIEW Available;
*/
/*
CREATE DATABASE Project1
USE Project1
CREATE TABLE Category(


Code INT IDENTITY(1000,1) PRIMARY KEY ,
Name VARCHAR(255) UNIQUE NOT NULL

)

SELECT * FROM Category
DROP TABLE Category

CREATE TABLE Product(

Code INT IDENTITY(1000,1) PRIMARY KEY NOT NULL,
Name VARCHAR(255) UNIQUE NOT NULL,
Category VARCHAR(255) NOT NULL,
ReorderLevel INT NOT NULL,
Description TEXT

)
SELECT * FROM Product

CREATE TABLE Customer(
Code INT IDENTITY(1000,1) PRIMARY KEY NOT NULL,
Name VARCHAR(255) NOT NULL,
Address VARCHAR(255) NOT NULL,
Email VARCHAR(255) UNIQUE NOT NULL,
Contact VARCHAR(11) UNIQUE NOT NULL,
LoyalityPoint INT
)
select * from Customer

CREATE TABLE Supplier(
Code INT IDENTITY(1000,1) PRIMARY KEY NOT NULL,
Name VARCHAR(255) NOT NULL,
Address VARCHAR(255) NOT NULL,
Email VARCHAR(255) UNIQUE NOT NULL,
Contact VARCHAR(11) UNIQUE NOT NULL,
ContactPerson VARCHAR(11) NOT NULL
)

select * from Supplier
*/