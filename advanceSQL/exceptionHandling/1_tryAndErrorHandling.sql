

CREATE PROCEDURE AddEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(100),
    @Salary DECIMAL(10,2),
    @DepartmentID INT,
    @JoinDate DATE
AS
BEGIN
    BEGIN TRY
        INSERT INTO Employees (FirstName, LastName, Email, Salary, DepartmentID, JoinDate)
        VALUES (@FirstName, @LastName, @Email, @Salary, @DepartmentID, @JoinDate);
    END TRY
    BEGIN CATCH
        INSERT INTO AuditLog (Action, ErrorMessage)
        VALUES ('AddEmployee', ERROR_MESSAGE());
    END CATCH
END;



EXEC AddEmployee 'Test', 'User', 'john.doe@example.com', 4000, 2, '2024-01-01';  -- Should log error

