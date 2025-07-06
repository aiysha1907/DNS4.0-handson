USE EmployeeDB;
GO
USE EmployeeDB;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;


EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
