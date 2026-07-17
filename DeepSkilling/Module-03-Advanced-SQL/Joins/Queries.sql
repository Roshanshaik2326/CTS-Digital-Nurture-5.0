INSERT INTO Employees
(EmployeeID, FullName, DepartmentID, Salary, Email)
VALUES
(101,'Aarav Sharma',1,45000,'aarav@gmail.com'),
(102,'Priya Reddy',2,62000,'priya@gmail.com'),
(103,'Rahul Verma',2,75000,'rahul@gmail.com'),
(104,'Sneha Gupta',3,54000,'sneha@gmail.com'),
(105,'Arjun Kumar',4,68000,'arjun@gmail.com'),
(106,'Kiran Rao',5,48000,'kiran@gmail.com'),
(107,'Ananya Singh',1,53000,'ananya@gmail.com'),
(108,'Vikram Patel',2,89000,'vikram@gmail.com'),
(109,'Meera Nair',3,61000,'meera@gmail.com'),
(110,'Suresh Kumar',4,71000,'suresh@gmail.com'),
(111,'Pooja Sharma',5,56000,'pooja@gmail.com'),
(112,'Ajay Reddy',1,47000,'ajay@gmail.com'),
(113,'Nikhil Verma',2,82000,'nikhil@gmail.com'),
(114,'Divya Rao',3,59000,'divya@gmail.com'),
(115,'Karthik Sai',4,76000,'karthik@gmail.com'),
(116,'Harsha Patel',5,52000,'harsha@gmail.com'),
(117,'Anil Kumar',1,49000,'anil@gmail.com'),
(118,'Bhavana Singh',2,68000,'bhavana@gmail.com'),
(119,'Deepak Gupta',3,64000,'deepak@gmail.com'),
(120,'Ishita Jain',4,72000,'ishita@gmail.com'),
(121,'Rakesh Reddy',5,58000,'rakesh@gmail.com'),
(122,'Keerthi Nair',1,51000,'keerthi@gmail.com'),
(123,'Manoj Varma',2,83000,'manoj@gmail.com'),
(124,'Rohit Sharma',NULL,47000,'rohit@gmail.com'),
(125,'Neha Kapoor',NULL,51000,'neha@gmail.com');

SELECT * FROM Employees;




USE CompanyDB;

SELECT
    'INNER JOIN' AS JoinType,
    E.EmployeeID,
    E.FullName,
    D.DepartmentName,
    E.Salary
FROM Employees E
INNER JOIN Departments D
ON E.DepartmentID = D.DepartmentID

UNION ALL

SELECT
    'LEFT JOIN',
    E.EmployeeID,
    E.FullName,
    D.DepartmentName,
    E.Salary
FROM Employees E
LEFT JOIN Departments D
ON E.DepartmentID = D.DepartmentID

UNION ALL

SELECT
    'RIGHT JOIN',
    E.EmployeeID,
    E.FullName,
    D.DepartmentName,
    E.Salary
FROM Employees E
RIGHT JOIN Departments D
ON E.DepartmentID = D.DepartmentID

UNION ALL

SELECT
    'CROSS JOIN',
    E.EmployeeID,
    E.FullName,
    D.DepartmentName,
    E.Salary
FROM Employees E
CROSS JOIN Departments D

UNION ALL

SELECT
    'SELF JOIN',
    E1.EmployeeID,
    E1.FullName,
    D.DepartmentName,
    E1.Salary
FROM Employees E1
JOIN Employees E2
ON E1.DepartmentID = E2.DepartmentID
JOIN Departments D
ON E1.DepartmentID = D.DepartmentID
WHERE E1.EmployeeID < E2.EmployeeID;