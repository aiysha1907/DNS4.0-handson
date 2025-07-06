-- Insert more orders to simulate monthly sales
INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(5, 1, '2023-01-10'),
(6, 2, '2023-02-12'),
(7, 3, '2023-03-15'),
(8, 4, '2023-03-28'),
(9, 1, '2023-02-20');

INSERT INTO OrderDetails (OrderDetailID, OrderID, ProductID, Quantity) VALUES
(5, 5, 1, 2),
(6, 6, 2, 1),
(7, 7, 1, 3),
(8, 8, 4, 2),
(9, 9, 3, 4);

-- Insert more orders to simulate monthly sales
INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(5, 1, '2023-01-10'),
(6, 2, '2023-02-12'),
(7, 3, '2023-03-15'),
(8, 4, '2023-03-28'),
(9, 1, '2023-02-20');

INSERT INTO OrderDetails (OrderDetailID, OrderID, ProductID, Quantity) VALUES
(5, 5, 1, 2),
(6, 6, 2, 1),
(7, 7, 1, 3),
(8, 8, 4, 2),
(9, 9, 3, 4);
-- UNPIVOT: Convert columns back to rows
SELECT 
    ProductName,
    SalesMonth,
    TotalQty
FROM (
    SELECT *
    FROM (
        SELECT 
            p.ProductName,
            FORMAT(o.OrderDate, 'MMM') AS SalesMonth,
            od.Quantity
        FROM OrderDetails od
        JOIN Orders o ON od.OrderID = o.OrderID
        JOIN Products p ON od.ProductID = p.ProductID
    ) AS SourceTable
    PIVOT (
        SUM(Quantity)
        FOR SalesMonth IN ([Jan], [Feb], [Mar])
    ) AS PivotTable
) AS PivotedData
UNPIVOT (
    TotalQty FOR SalesMonth IN ([Jan], [Feb], [Mar])
) AS UnpivotedData;
