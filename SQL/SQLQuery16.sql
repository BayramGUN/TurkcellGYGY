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

--OUTER JOİN
--UPDATE Categories set [Description] = 'datluuu' where CategoryID = 9

SELECT 
	 CategoryName, ProductName 
FROM Categories FULL OUTER JOIN Products
ON Products.CategoryID = Categories.CategoryID
Where CategoryName is NULL or ProductName is NULL


SELECT 
	 CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories LEFT JOIN Products
ON Products.CategoryID = Categories.CategoryID
GROUP BY CategoryName
Order by CategoryName



--kim kimin müdürü

SELECT 
	Calisanlar.Title 'İşi',
	Calisanlar.FirstName + ' ' + Calisanlar.LastName 'Calisan',
	Mudurler.FirstName + ' ' + Mudurler.LastName 'Müdür',
	Mudurler.Title 'İşi'
FROM Employees AS Calisanlar LEFT JOIN Employees AS Mudurler
ON Calisanlar.ReportsTo = Mudurler.EmployeeID
--WHERE Mudurler.FirstName + ' ' + Mudurler.LastName IS NULL
ORDER BY 'Calisan'

SELECT COUNT(*) FROM Orders CROSS JOIN [Order Details] 



select 
	ProductName, UnitPrice, 
	
	Durum = 
		CASE 
			WHEN UnitsInStock = 0 THEN 'yok!'
			WHEN UnitsInStock <= 20 THEN 'kritik!'
			WHEN UnitsInStock <= 50 THEN 'normal!'
			WHEN UnitsInStock > 50 THEN 'fazla!'
		END

FROM Products
Order By Durum

-- en pahalı ürünüm hangisi

SELECT MAX(UnitPrice) FROM Products

SELECT 
*
FROM Products
WHERE UnitPrice = (
		SELECT MAX(UnitPrice) FROM Products
	)


/*SELECT 
	 CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories LEFT JOIN Products
ON Products.CategoryID = Categories.CategoryID
GROUP BY CategoryName
Order by CategoryName */

SELECT 
	c.CategoryName, (SELECT COUNT(ProductID) FROM Products WHERE CategoryID = c.CategoryID)
FROM Categories AS c


--ARAŞTIRMA ÖDEV: execution plan nasıl okunmalıdır?



--Aynı ülkede bulunan tedarikçi firmalar ve müşterilerimi istiyorum

SELECT 
	CompanyName, Address, City, Country, 'Musteri' as Kim
FROM Customers
UNION
SELECT 
	CompanyName, Address, City, Country, 'Tedarikci' 
FROM Suppliers 
Order By Country