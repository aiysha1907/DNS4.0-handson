CREATE PROCEDURE BatchInsertEmployees
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Simulate success
        INSERT INTO Employees (FirstName, LastName, Email, Salary, DepartmentID, JoinDate)
        VALUES ('New', 'One', 'new.one@example.com', 5000, 1, '2023-05-10');

        -- Simulate failure (duplicate email)
        INSERT INTO Employees (FirstName, LastName, Email, Salary, DepartmentID, JoinDate)
        VALUES ('New', 'Two', 'john.doe@example.com', 5000, 2, '2023-06-01');

        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('BatchInsertEmployees', ERROR_MESSAGE());
        THROW;
    END CATCH
END;
