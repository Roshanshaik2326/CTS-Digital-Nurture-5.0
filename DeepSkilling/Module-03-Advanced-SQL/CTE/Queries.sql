USE CompanyDB;


-- 1. Basic CTE


WITH EmployeeCTE AS
(
    SELECT
        EmployeeID,
        FullName,
        Salary
    FROM Employees
)
SELECT *
FROM EmployeeCTE;


-- 2. Employees Above Average Salary


WITH AvgSalaryCTE AS
(
    SELECT AVG(Salary) AS AvgSalary
    FROM Employees
)
SELECT
    EmployeeID,
    FullName,
    Salary
FROM Employees
WHERE Salary >
(
    SELECT AvgSalary
    FROM AvgSalaryCTE
);

-- 3. Department-wise Average Salary


WITH DeptAverage AS
(
    SELECT
        DepartmentID,
        AVG(Salary) AS AverageSalary
    FROM Employees
    GROUP BY DepartmentID
)
SELECT *
FROM DeptAverage;

-- 4. Multiple CTEs


WITH EmployeeCount AS
(
    SELECT
        DepartmentID,
        COUNT(*) AS TotalEmployees
    FROM Employees
    GROUP BY DepartmentID
),
DepartmentSalary AS
(
    SELECT
        DepartmentID,
        AVG(Salary) AS AverageSalary
    FROM Employees
    GROUP BY DepartmentID
)
SELECT
    E.DepartmentID,
    E.TotalEmployees,
    D.AverageSalary
FROM EmployeeCount E
JOIN DepartmentSalary D
ON E.DepartmentID = D.DepartmentID;