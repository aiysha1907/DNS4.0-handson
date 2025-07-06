-- Basic Join to show sales by Region and Category
SELECT 
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM OrderDetails od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.Region, p.Category;


-- Using GROUPING SETS
SELECT 
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM OrderDetails od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY GROUPING SETS (
    (c.Region),
    (p.Category),
    (c.Region, p.Category)
);


-- Using ROLLUP
SELECT 
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM OrderDetails od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY ROLLUP (c.Region, p.Category);


-- Using CUBE
SELECT 
    c.Region,
    p.Category,
    SUM(od.Quantity) AS TotalQuantity
FROM OrderDetails od
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
GROUP BY CUBE (c.Region, p.Category);
