USE CompanyDB;


-- View Employee Table


SELECT * FROM Employees;

-- Create Index on FullName


CREATE INDEX idx_FullName
ON Employees(FullName);


-- Create Index on Salary


CREATE INDEX idx_Salary
ON Employees(Salary);


-- Show All Indexes


SHOW INDEX
FROM Employees;


-- Search using Indexed Column


SELECT *
FROM Employees
WHERE FullName='Priya Reddy';


-- Search using Salary Index


SELECT *
FROM Employees
WHERE Salary>70000;