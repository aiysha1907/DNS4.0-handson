SELECT FirstName, LastName, Salary, dbo.fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees;

SELECT dbo.fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees
WHERE EmployeeID = 1;

SELECT * FROM fn_GetEmployeesByDepartment(3);
