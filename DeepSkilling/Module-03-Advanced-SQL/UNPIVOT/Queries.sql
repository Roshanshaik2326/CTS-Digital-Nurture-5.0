USE CompanyDB;


-- UNPIVOT Employee Information


SELECT
EmployeeID,
'FullName' AS Attribute,
FullName AS Value
FROM Employees

UNION ALL

SELECT
EmployeeID,
'Salary',
CAST(Salary AS CHAR)
FROM Employees

UNION ALL

SELECT
EmployeeID,
'Email',
Email
FROM Employees

ORDER BY EmployeeID;