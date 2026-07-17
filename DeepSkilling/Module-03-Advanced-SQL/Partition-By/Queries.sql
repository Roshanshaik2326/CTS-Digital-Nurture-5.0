USE CompanyDB;

-- Department-wise Average Salary


SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
AVG(Salary)
OVER(PARTITION BY DepartmentID) AS AvgDepartmentSalary
FROM Employees;


-- Department-wise Total Salary

SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
SUM(Salary)
OVER(PARTITION BY DepartmentID) AS TotalDepartmentSalary
FROM Employees;

-- Department-wise Employee Count


SELECT
EmployeeID,
FullName,
DepartmentID,
COUNT(*)
OVER(PARTITION BY DepartmentID) AS EmployeesInDepartment
FROM Employees;


-- Department-wise Highest Salary


SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
MAX(Salary)
OVER(PARTITION BY DepartmentID) AS HighestDepartmentSalary
FROM Employees;

-- Department-wise Lowest Salary


SELECT
EmployeeID,
FullName,
DepartmentID,
Salary,
MIN(Salary)
OVER(PARTITION BY DepartmentID) AS LowestDepartmentSalary
FROM Employees;