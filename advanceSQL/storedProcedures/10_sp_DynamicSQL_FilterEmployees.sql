USE EmployeeDB;
GO

CREATE PROCEDURE sp_FilterEmployees
    @FilterColumn NVARCHAR(50),
    @FilterValue NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);

    SET @SQL = 'SELECT * FROM Employees WHERE ' + QUOTENAME(@FilterColumn) + ' = @val';

    EXEC sp_executesql @SQL, N'@val NVARCHAR(100)', @val = @FilterValue;
END;
EXEC sp_FilterEmployees @FilterColumn = 'FirstName', @FilterValue = 'Jane';


EXEC sp_FilterEmployees @FilterColumn = 'DepartmentID', @FilterValue = '2';
