--Stored Procedures -saklı yordamlar-: Parametrik olarak, sorgu üretebilen nesnelerdir.

CREATE PROC AddNewProduct
	@name nvarchar(40),
	@price money
AS
Insert into Products (ProductName, UnitPrice) 
	values(@name, @price)


AddNewProduct 'Suvagn', 25

-- ads

CREATE PROc GetOrdersByDate
	@start datetime,
	@finish datetime
AS
SELECT 
*
FROM Orders
WHERE OrderDate BETWEEN @start AND @finish

GetOrdersByDate '1997-12-05', '1998-12-05'



-- Bu ürünü alanlar bunu da aldılar!!

-- 1. O ürünü alan tüm siparişleri bul,
-- 2. O Ürün hariç, diğer ürünlere bak

CREATE PROC BoughtSameProd
	@productId int
as
SELECT top 5 ProductName, Sum(Quantity) as TotalQuantity
FROM Products JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID
where [Order Details].OrderID IN (
				SELECT OrderID FROM [Order Details] WHERE ProductID = @productID
			)
AND [Order Details].ProductID != @productID
Group By ProductName
Order BY TotalQuantity desc

BoughtSameProd 55