USE CompanyDB;


-- WINDOW FUNCTIONS


-- 1. ROW_NUMBER()
USE CompanyDB;

SELECT
    EmployeeID,
    FullName,
    DepartmentID,
    Salary,
    ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RowNum
FROM Employees;


-- 2. RANK()

SELECT
EmployeeID,
    FullName,
    DepartmentID,
    Salary,
    RANK() OVER(ORDER BY Salary DESC) AS Salary_Rank
FROM Employees;



-- DENSE_RANK
SELECT
    EmployeeID,
    FullName,
    Salary,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS DenseRankValue
FROM Employees;

-- LAG
SELECT
    EmployeeID,
    FullName,
    Salary,
    LAG(Salary) OVER (ORDER BY Salary DESC) AS PreviousSalary
FROM Employees;

-- LEAD
SELECT
    EmployeeID,
    FullName,
    Salary,
    LEAD(Salary) OVER (ORDER BY Salary DESC) AS NextSalary
FROM Employees;