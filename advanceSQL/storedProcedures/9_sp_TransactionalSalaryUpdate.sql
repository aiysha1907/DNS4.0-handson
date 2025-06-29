USE EmployeeDB;
GO

CREATE PROCEDURE sp_TransactionalSalaryUpdate
    @EmployeeID INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmployeeID = @EmployeeID;

        -- Simulate failure (optional test)
        -- THROW 50000, 'Simulated error', 1;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        PRINT 'Error occurred: ' + ERROR_MESSAGE();
    END CATCH
END;



EXEC sp_TransactionalSalaryUpdate 
    @EmployeeID = 2, 
    @NewSalary = 7200.00;



SELECT * FROM Employees WHERE EmployeeID = 2;
