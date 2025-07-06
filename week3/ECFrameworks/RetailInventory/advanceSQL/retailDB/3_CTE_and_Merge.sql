USE RetailDB;
GO

-- Recursive CTE to generate dates from 2025-01-01 to 2025-01-31
WITH CalendarCTE AS (
    SELECT CAST('2025-01-01' AS DATE) AS CalendarDate
    UNION ALL
    SELECT DATEADD(DAY, 1, CalendarDate)
    FROM CalendarCTE
    WHERE CalendarDate < '2025-01-31'
)
SELECT * FROM CalendarCTE
OPTION (MAXRECURSION 1000);  -- Allow deeper recursion

-- Create a staging table
CREATE TABLE StagingProducts (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2)
);

-- Insert new and updated product records
INSERT INTO StagingProducts VALUES
(1, 'Laptop', 'Electronics', 1100.00),    -- Existing product, new price
(5, 'Smartwatch', 'Electronics', 500.00); -- New product
-- Merge StagingProducts into Products table
MERGE INTO Products AS Target
USING StagingProducts AS Source
ON Target.ProductID = Source.ProductID

WHEN MATCHED THEN
    UPDATE SET 
        Target.ProductName = Source.ProductName,
        Target.Category = Source.Category,
        Target.Price = Source.Price

WHEN NOT MATCHED THEN
    INSERT (ProductID, ProductName, Category, Price)
    VALUES (Source.ProductID, Source.ProductName, Source.Category, Source.Price);

USE RetailDB;
GO

SELECT * FROM Products;
