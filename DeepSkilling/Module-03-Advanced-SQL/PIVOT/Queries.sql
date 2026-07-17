USE CompanyDB;

-- Employee Count by Department (Pivot)


SELECT
COUNT(CASE WHEN DepartmentID = 1 THEN 1 END) AS HR,
COUNT(CASE WHEN DepartmentID = 2 THEN 1 END) AS IT,
COUNT(CASE WHEN DepartmentID = 3 THEN 1 END) AS Finance,
COUNT(CASE WHEN DepartmentID = 4 THEN 1 END) AS Marketing,
COUNT(CASE WHEN DepartmentID = 5 THEN 1 END) AS Sales
FROM Employees;


-- Total Salary by Department


SELECT
SUM(CASE WHEN DepartmentID = 1 THEN Salary ELSE 0 END) AS HR,
SUM(CASE WHEN DepartmentID = 2 THEN Salary ELSE 0 END) AS IT,
SUM(CASE WHEN DepartmentID = 3 THEN Salary ELSE 0 END) AS Finance,
SUM(CASE WHEN DepartmentID = 4 THEN Salary ELSE 0 END) AS Marketing,
SUM(CASE WHEN DepartmentID = 5 THEN Salary ELSE 0 END) AS Sales
FROM Employees;


-- Average Salary by Department


SELECT
ROUND(AVG(CASE WHEN DepartmentID = 1 THEN Salary END),2) AS HR,
ROUND(AVG(CASE WHEN DepartmentID = 2 THEN Salary END),2) AS IT,
ROUND(AVG(CASE WHEN DepartmentID = 3 THEN Salary END),2) AS Finance,
ROUND(AVG(CASE WHEN DepartmentID = 4 THEN Salary END),2) AS Marketing,
ROUND(AVG(CASE WHEN DepartmentID = 5 THEN Salary END),2) AS Sales
FROM Employees;