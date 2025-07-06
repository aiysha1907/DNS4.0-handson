--basic cursor to print employee details

DECLARE @ID INT,
        @FirstName VARCHAR(50),
        @LastName VARCHAR(50),
        @Salary DECIMAL(10,2);

DECLARE EmployeeCursor CURSOR FOR
    SELECT EmployeeID, FirstName, LastName, Salary FROM Employees;

OPEN EmployeeCursor;

FETCH NEXT FROM EmployeeCursor INTO @ID, @FirstName, @LastName, @Salary;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'ID: ' + CAST(@ID AS VARCHAR) +
          ', Name: ' + @FirstName + ' ' + @LastName +
          ', Salary: ' + CAST(@Salary AS VARCHAR);

    FETCH NEXT FROM EmployeeCursor INTO @ID, @FirstName, @LastName, @Salary;
END;

CLOSE EmployeeCursor;
DEALLOCATE EmployeeCursor;
