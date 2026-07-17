USE CompanyDB;


-- View Existing Employees


SELECT * FROM Employees;

-- INSERT New Employee


INSERT INTO Employees
(EmployeeID, FullName, DepartmentID, Salary, Email)
VALUES
(301,'Merge Demo',2,60000,'merge@example.com')
ON DUPLICATE KEY UPDATE
FullName=VALUES(FullName),
DepartmentID=VALUES(DepartmentID),
Salary=VALUES(Salary),
Email=VALUES(Email);

SELECT *
FROM Employees
WHERE EmployeeID=301;


-- UPDATE Existing Employee


INSERT INTO Employees
(EmployeeID, FullName, DepartmentID, Salary, Email)
VALUES
(301,'Merge Demo Updated',3,75000,'updated@example.com')
ON DUPLICATE KEY UPDATE
FullName=VALUES(FullName),
DepartmentID=VALUES(DepartmentID),
Salary=VALUES(Salary),
Email=VALUES(Email);

SELECT *
FROM Employees
WHERE EmployeeID=301;


-- Verify Employee Count


SELECT
COUNT(*) AS TotalEmployees
FROM Employees;