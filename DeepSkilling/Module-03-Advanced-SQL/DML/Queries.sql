USE CompanyDB;

-- Insert Departments
INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance'),
(4, 'Marketing'),
(5, 'Sales');

-- View Departments
SELECT * FROM Departments;

SELECT DATABASE();

SHOW TABLES;

SELECT COUNT(*) FROM Departments;

SELECT * FROM Departments;

-- Insert Employees
INSERT INTO Employees (EmployeeID, FullName, DepartmentID, Salary, Email)
VALUES
(101, 'Rahul Sharma', 2, 75000, 'rahul@company.com'),
(102, 'Priya Reddy', 1, 60000, 'priya@company.com'),
(103, 'Arjun Kumar', 3, 85000, 'arjun@company.com'),
(104, 'Sneha Patel', 4, 55000, 'sneha@company.com'),
(105, 'Vikram Singh', 5, 70000, 'vikram@company.com');

-- View Employees
SELECT * FROM Employees;


-- UPDATE
UPDATE Employees
SET Salary = 80000
WHERE EmployeeID = 101;

-- DELETE
DELETE FROM Employees
WHERE EmployeeID = 104;

-- WHERE
SELECT * FROM Employees
WHERE Salary > 65000;

-- ORDER BY
SELECT * FROM Employees
ORDER BY Salary DESC;

-- LIMIT
SELECT * FROM Employees
LIMIT 3;