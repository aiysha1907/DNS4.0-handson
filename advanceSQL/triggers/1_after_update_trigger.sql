--create employee changes table
CREATE TABLE EmployeeChanges (
    ChangeID INT IDENTITY PRIMARY KEY,
    EmployeeID INT,
    OldSalary DECIMAL(10,2),
    NewSalary DECIMAL(10,2),
    ChangeDate DATETIME DEFAULT GETDATE()
);


--create AFTER UPDATE trigger
CREATE TRIGGER trg_AfterSalaryUpdate
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeChanges (EmployeeID, OldSalary, NewSalary)
    SELECT d.EmployeeID, d.Salary, i.Salary
    FROM deleted d
    JOIN inserted i ON d.EmployeeID = i.EmployeeID
    WHERE d.Salary <> i.Salary;
END;


--TEST (update a salary)

UPDATE Employees SET Salary = Salary + 500 WHERE EmployeeID = 2;

SELECT * FROM EmployeeChanges;
