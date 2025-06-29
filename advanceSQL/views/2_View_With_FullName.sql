USE EmployeeDB;
GO


CREATE VIEW vw_EmployeeFullName AS
SELECT 
    EmployeeID,
    FirstName + ' ' + LastName AS FullName
FROM Employees;




SELECT * FROM vw_EmployeeFullName;
