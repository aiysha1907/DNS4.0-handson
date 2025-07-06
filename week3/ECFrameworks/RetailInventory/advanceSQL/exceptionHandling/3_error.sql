ALTER PROCEDURE AddEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2),
    @DepartmentID INT,
    @JoinDate DATE
AS
BEGIN
    IF @Salary <= 0
    BEGIN
        RAISERROR('Salary must be greater than zero.', 16, 1);
        RETURN;
    END

    BEGIN TRY
        INSERT INTO Employees (FirstName, LastName, Email, Salary, DepartmentID, JoinDate)
        VALUES (@FirstName, @LastName, @Email, @Salary, @DepartmentID, @JoinDate);
    END TRY
    BEGIN CATCH
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('AddEmployee', ERROR_MESSAGE());
        THROW;
    END CATCH
END;
