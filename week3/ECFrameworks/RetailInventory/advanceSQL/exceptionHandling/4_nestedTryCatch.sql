CREATE PROCEDURE TransferEmployee
    @EmployeeID INT,
    @NewDeptID INT
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @NewDeptID)
        BEGIN
            RAISERROR('Invalid Department ID.', 16, 1);
            RETURN;
        END

        BEGIN TRY
            UPDATE Employees SET DepartmentID = @NewDeptID WHERE EmployeeID = @EmployeeID;
        END TRY
        BEGIN CATCH
            INSERT INTO AuditLog (Action, ErrorMessage)
            VALUES ('TransferEmployee.InnerCatch', ERROR_MESSAGE());
            THROW;
        END CATCH

    END TRY
    BEGIN CATCH
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('TransferEmployee.OuterCatch', ERROR_MESSAGE());
        THROW;
    END CATCH
END;
