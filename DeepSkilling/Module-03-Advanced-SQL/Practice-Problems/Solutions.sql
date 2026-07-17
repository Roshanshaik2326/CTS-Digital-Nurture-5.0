USE CompanyDB;

-- 1
SELECT * FROM Employees;

-- 2
SELECT *
FROM Employees
WHERE Salary > 60000;

-- 3
SELECT E.*
FROM Employees E
JOIN Departments D
ON E.DepartmentID=D.DepartmentID
WHERE D.DepartmentName='IT';

-- 4
SELECT
DepartmentID,
COUNT(*) TotalEmployees
FROM Employees
GROUP BY DepartmentID
HAVING COUNT(*)>3;

-- 5
SELECT *
FROM Employees
ORDER BY Salary DESC
LIMIT 1;

-- 6
SELECT *
FROM Employees
WHERE Salary>
(
SELECT AVG(Salary)
FROM Employees
);

-- 7
SELECT
DepartmentID,
AVG(Salary)
FROM Employees
GROUP BY DepartmentID;

-- 8
SELECT *
FROM Employees
ORDER BY Salary DESC
LIMIT 2;

-- 9
SELECT *
FROM Employees
WHERE Salary >
ALL
(
SELECT Salary
FROM Employees
WHERE DepartmentID=1
);

-- 10
SELECT *
FROM Employees
WHERE DepartmentID IS NULL;

-- 11
SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
RANK() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) RankNo
FROM Employees;

-- 12
SELECT
EmployeeID,
FullName,
Salary,
SUM(Salary)
OVER(ORDER BY EmployeeID)
RunningTotal
FROM Employees;

-- 13
WITH AvgSalary AS
(
SELECT AVG(Salary) AvgSal
FROM Employees
)
SELECT *
FROM Employees
WHERE Salary>
(
SELECT AvgSal
FROM AvgSalary
);

-- 14
SELECT
COUNT(CASE WHEN DepartmentID=1 THEN 1 END) HR,
COUNT(CASE WHEN DepartmentID=2 THEN 1 END) IT,
COUNT(CASE WHEN DepartmentID=3 THEN 1 END) Finance,
COUNT(CASE WHEN DepartmentID=4 THEN 1 END) Marketing,
COUNT(CASE WHEN DepartmentID=5 THEN 1 END) Sales
FROM Employees;

-- 15
SELECT EmployeeID,'Name' Attribute,FullName Value
FROM Employees

UNION ALL

SELECT EmployeeID,'Salary',CAST(Salary AS CHAR)
FROM Employees;

-- 16
SELECT DISTINCT Salary
FROM Employees
ORDER BY Salary DESC
LIMIT 1 OFFSET 1;

-- 17
SELECT
Salary,
COUNT(*)
FROM Employees
GROUP BY Salary
HAVING COUNT(*)>1;

-- 18
SELECT *
FROM
(
SELECT *,
RANK() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) Rnk
FROM Employees
) X
WHERE Rnk=1;

-- 19
WITH RECURSIVE Numbers AS
(
SELECT 1 Num
UNION ALL
SELECT Num+1
FROM Numbers
WHERE Num<5
)
SELECT *
FROM Numbers;

-- 20
START TRANSACTION;

UPDATE Employees
SET Salary=Salary+1000
WHERE EmployeeID=101;

ROLLBACK;