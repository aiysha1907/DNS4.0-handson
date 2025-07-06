USE EmployeeDB;
GO

CREATE PROCEDURE sp_GiveBonus
    @DepartmentID INT,
    @BonusAmount DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = Salary + @BonusAmount
    WHERE DepartmentID = @DepartmentID;
END;


EXEC sp_GiveBonus 
    @DepartmentID = 3, 
    @BonusAmount = 500.00;

SELECT * FROM Employees WHERE DepartmentID = 3;
