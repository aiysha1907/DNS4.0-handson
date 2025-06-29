-- Static Cursor (snapshot, no changes reflected)
DECLARE static_cursor CURSOR STATIC FOR
    SELECT FirstName, Salary FROM Employees;
OPEN static_cursor;
FETCH NEXT FROM static_cursor;
CLOSE static_cursor;
DEALLOCATE static_cursor;

-- Dynamic Cursor (real-time data)
DECLARE dynamic_cursor CURSOR DYNAMIC FOR
    SELECT FirstName, Salary FROM Employees;
OPEN dynamic_cursor;
FETCH NEXT FROM dynamic_cursor;
CLOSE dynamic_cursor;
DEALLOCATE dynamic_cursor;

-- Forward-only Cursor (fastest, only moves forward)
DECLARE forward_cursor CURSOR FORWARD_ONLY FOR
    SELECT FirstName, Salary FROM Employees;
OPEN forward_cursor;
FETCH NEXT FROM forward_cursor;
CLOSE forward_cursor;
DEALLOCATE forward_cursor;

-- Keyset-driven Cursor (mix: keys static, data dynamic)
DECLARE keyset_cursor CURSOR KEYSET FOR
    SELECT FirstName, Salary FROM Employees;
OPEN keyset_cursor;
FETCH NEXT FROM keyset_cursor;
CLOSE keyset_cursor;
DEALLOCATE keyset_cursor;
