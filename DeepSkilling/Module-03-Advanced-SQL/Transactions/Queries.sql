SELECT * FROM Employees;

START TRANSACTION;

UPDATE Employees
SET Salary = Salary + 5000
WHERE EmployeeID = 101;

SELECT * FROM Employees WHERE EmployeeID = 101;

COMMIT;


START TRANSACTION;

UPDATE Employees
SET Salary = Salary + 10000
WHERE EmployeeID = 102;

SELECT * FROM Employees WHERE EmployeeID = 102;

ROLLBACK;

SELECT * FROM Employees WHERE EmployeeID = 102;

START TRANSACTION;

UPDATE Employees
SET Salary = Salary + 2000
WHERE EmployeeID = 103;

SAVEPOINT sp1;

UPDATE Employees
SET Salary = Salary + 3000
WHERE EmployeeID = 104;

ROLLBACK TO sp1;

COMMIT;

SELECT * FROM Employees
WHERE EmployeeID IN (103,104);