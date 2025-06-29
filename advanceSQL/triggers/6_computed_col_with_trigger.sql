--update computed column with trigger

ALTER TABLE Employees
ADD AnnualSalary AS (Salary * 12);

ALTER TABLE Employees ADD AnnualSalary DECIMAL(10, 2);

CREATE TRIGGER trg_UpdateAnnualSalary
ON Employees
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE e
    SET AnnualSalary = i.Salary * 12
    FROM Employees e
    INNER JOIN inserted i ON e.EmployeeID = i.EmployeeID;
END;


--test
UPDATE Employees SET Salary = 6200 WHERE EmployeeID = 3;
SELECT EmployeeID, Salary, AnnualSalary FROM Employees;
