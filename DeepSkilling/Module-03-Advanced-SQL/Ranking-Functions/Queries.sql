USE CompanyDB;


-- ROW_NUMBER


SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
ROW_NUMBER() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) AS RowNum
FROM Employees;

-- RANK

SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
RANK() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) AS SalaryRank
FROM Employees;

-- DENSE_RANK

SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
DENSE_RANK() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) AS DenseRank
FROM Employees;

-- Top Paid Employee Per Department

SELECT *
FROM
(
SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
ROW_NUMBER() OVER(
PARTITION BY DepartmentID
ORDER BY Salary DESC
) AS RN
FROM Employees
) X
WHERE RN = 1;