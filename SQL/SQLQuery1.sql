SELECT 
	'https://www.google.com/search?q=' + ProductName + '&source=lnms&tbm=isch' 
	Link
FROM Products

--view--

CREATE VIEW DeAktifUrunler
AS
SELECT
	ProductName, UnitPrice
FROM Products
WHERE Discontinued = 1

SELECT TOP 5 * FROM DeAktifUrunler

SELECT * FROM AktifUrunler


CREATE VIEW DetailedOrders
AS
SELECT 
	o.OrderID,
	c.CompanyName, o.OrderDate,
	e.FirstName + ' ' + e.LastName 'Çalışan',
	s.CompanyName 'Kargo',
	sp.CompanyName 'Tedarikçi',
	cat.CategoryName,
	p.ProductName,
	od.Quantity,
	od.UnitPrice
FROM Employees as e JOIN Orders o
on e.EmployeeID = o.EmployeeID
join Customers c
on o.CustomerID = c.CustomerID
join Shippers s
on s.ShipperID = o.ShipVia
join [Order Details] od
on od.OrderID = o.OrderID
join Products p
on p.ProductID = od.ProductID
join Suppliers sp
on p.SupplierID = sp.SupplierID
Join Categories cat
on cat.CategoryID = p.CategoryID


SELECT 
	CategoryName, COUNT(OrderID) as TotalOrder
FROM DetailedOrders 
group by CategoryName
ORDER BY TotalOrder Desc

SELECT 
	CategoryName, Sum(UnitPrice) as TotalPrice
FROM DetailedOrders 
WHERE OrderDate BETWEEN '1996-08-01' AND '1996-08-31'
group by CategoryName
ORDER BY TotalPrice Desc