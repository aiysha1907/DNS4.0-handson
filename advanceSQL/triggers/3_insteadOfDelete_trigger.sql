--INSTEAD OF DELETE trigger

CREATE TRIGGER trg_PreventDelete
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    RAISERROR('Deletion is not allowed from Employees table.', 16, 1);
END;


--test
DELETE FROM Employees WHERE EmployeeID = 2;  -- Should raise error
