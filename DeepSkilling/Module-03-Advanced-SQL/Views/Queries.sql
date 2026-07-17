SELECT * FROM EmployeeDetails;
SELECT * FROM HighSalaryEmployees;
SELECT * FROM ITEmployees;


SELECT
    EmployeeID,
    FullName,
    DepartmentID,
    Salary
FROM Employees
LIMIT 10;


SELECT
    E.EmployeeID,
    E.FullName,
    D.DepartmentName
FROM Employees E
JOIN Departments D
ON E.DepartmentID = D.DepartmentID;


SELECT DATABASE();

SHOW TABLES;

SELECT COUNT(*) AS DepartmentCount FROM Departments;

SELECT COUNT(*) AS EmployeeCount FROM Employees;