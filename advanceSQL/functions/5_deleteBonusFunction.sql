USE EmployeeDB
GO


DROP FUNCTION fn_CalculateBonus;

SELECT dbo.fn_CalculateBonus(5000);  -- should fail
