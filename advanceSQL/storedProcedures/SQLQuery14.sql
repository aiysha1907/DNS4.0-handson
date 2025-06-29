




CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;


ALTER PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        Salary
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;














EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
