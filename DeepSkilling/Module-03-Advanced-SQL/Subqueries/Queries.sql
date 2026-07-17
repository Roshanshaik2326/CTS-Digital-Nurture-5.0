

-- Dashboard (Scalar Subqueries)
SELECT
    (SELECT COUNT(*) FROM Employees) AS TotalEmployees,
    (SELECT COUNT(*) FROM Departments) AS TotalDepartments,
    (SELECT AVG(Salary) FROM Employees) AS AverageSalary,
    (SELECT MAX(Salary) FROM Employees) AS HighestSalary,
    (SELECT MIN(Salary) FROM Employees) AS LowestSalary,
    (SELECT FullName
     FROM Employees
     ORDER BY Salary DESC
     LIMIT 1) AS HighestPaidEmployee;

-- Single Row Subquery
SELECT *
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees);

-- Multiple Row Subquery (IN)
SELECT *
FROM Employees
WHERE DepartmentID IN
(
    SELECT DepartmentID
    FROM Departments
    WHERE DepartmentName IN ('HR','IT')
);

-- Correlated Subquery
SELECT *
FROM Employees E
WHERE Salary =
(
    SELECT MAX(Salary)
    FROM Employees
    WHERE DepartmentID = E.DepartmentID
);

-- EXISTS
SELECT *
FROM Departments D
WHERE EXISTS
(
    SELECT 1
    FROM Employees E
    WHERE E.DepartmentID = D.DepartmentID
);

-- NOT EXISTS
SELECT *
FROM Departments D
WHERE NOT EXISTS
(
    SELECT 1
    FROM Employees E
    WHERE E.DepartmentID = D.DepartmentID
);

-- ANY
SELECT *
FROM Employees
WHERE Salary > ANY
(
    SELECT Salary
    FROM Employees
    WHERE DepartmentID = 1
);

-- ALL
SELECT *
FROM Employees
WHERE Salary > ALL
(
    SELECT Salary
    FROM Employees
    WHERE DepartmentID = 1
);