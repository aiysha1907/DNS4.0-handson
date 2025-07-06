USE EmployeeDB;
GO


CREATE VIEW vw_EmployeeAnnualSalary AS
SELECT 
    EmployeeID,
    FirstName,
    LastName,
    Salary * 12 AS AnnualSalary
FROM Employees;



SELECT * FROM vw_EmployeeAnnualSalary;
