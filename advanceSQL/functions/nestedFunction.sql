--recreate bonus function
CREATE FUNCTION fn_CalculateBonus (@Salary DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    RETURN @Salary * 0.15;
END;


--create nested function

CREATE FUNCTION fn_CalculateTotalCompensation (@Salary DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    RETURN dbo.fn_CalculateAnnualSalary(@Salary) + dbo.fn_CalculateBonus(@Salary);
END;

--test 
SELECT FirstName, LastName, Salary,
       dbo.fn_CalculateTotalCompensation(Salary) AS TotalCompensation
FROM Employees;
