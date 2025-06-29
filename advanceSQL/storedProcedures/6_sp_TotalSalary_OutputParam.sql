USE EmployeeDB;
GO

CREATE PROCEDURE sp_GetTotalSalaryByDepartment
    @DepartmentID INT,
    @TotalSalary DECIMAL(18,2) OUTPUT
AS
BEGIN
    SELECT @TotalSalary = SUM(Salary)
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;


DECLARE @Result DECIMAL(18,2);

EXEC sp_GetTotalSalaryByDepartment 
    @DepartmentID = 3, 
    @TotalSalary = @Result OUTPUT;

SELECT @Result AS TotalSalary;
