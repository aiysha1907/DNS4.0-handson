USE EmployeeDB;
GO

DROP PROCEDURE sp_GetEmployeesByDepartment;

EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;

