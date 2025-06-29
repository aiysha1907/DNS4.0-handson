USE EmployeeDB;
GO

CREATE PROCEDURE sp_SafeSalaryUpdate
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY
        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        PRINT 'Salary updated successfully.';
    END TRY
    BEGIN CATCH
        PRINT 'An error occurred while updating salary: ' + ERROR_MESSAGE();
    END CATCH
END;


EXEC sp_SafeSalaryUpdate @EmployeeID = 2, @NewSalary = 7500.00;

EXEC sp_SafeSalaryUpdate @EmployeeID = 999, @NewSalary = 7500.00;
