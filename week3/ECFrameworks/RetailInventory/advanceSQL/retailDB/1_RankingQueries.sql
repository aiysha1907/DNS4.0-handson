USE RetailDB;
GO

SELECT * FROM Customers;


-- ROW_NUMBER() Example
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

-- RANK() Example
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank
FROM Products;

-- DENSE_RANK() Example
SELECT 
    ProductID,
    ProductName,
    Category,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DensePriceRank
FROM Products;
-- Top 3 using ROW_NUMBER()
WITH RankedProducts AS (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
)
SELECT * FROM RankedProducts
WHERE RowNum <= 3;
