--LOGON trigger

CREATE TRIGGER trg_LimitLogon
ON ALL SERVER
FOR LOGON
AS
BEGIN
    IF DATEPART(HOUR, GETDATE()) BETWEEN 2 AND 3
    BEGIN
        ROLLBACK;
        THROW 51000, 'Login not allowed during maintenance window (2–3 AM).', 1;
    END
END;


