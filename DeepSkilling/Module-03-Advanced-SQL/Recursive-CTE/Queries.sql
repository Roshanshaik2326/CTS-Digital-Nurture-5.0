USE CompanyDB;


-- Example 1: Numbers 1 to 10


WITH RECURSIVE Numbers AS
(
    SELECT 1 AS Num

    UNION ALL

    SELECT Num + 1
    FROM Numbers
    WHERE Num < 10
)

SELECT *
FROM Numbers;


-- Example 2: Squares of Numbers


WITH RECURSIVE Squares AS
(
    SELECT 1 AS Num

    UNION ALL

    SELECT Num + 1
    FROM Squares
    WHERE Num < 10
)

SELECT
    Num,
    Num * Num AS Square
FROM Squares;

-- Example 3: Even Numbers


WITH RECURSIVE EvenNumbers AS
(
    SELECT 2 AS Num

    UNION ALL

    SELECT Num + 2
    FROM EvenNumbers
    WHERE Num < 20
)

SELECT *
FROM EvenNumbers;


-- Example 4: Multiplication Table of 5


WITH RECURSIVE TableFive AS
(
    SELECT 1 AS Num

    UNION ALL

    SELECT Num + 1
    FROM TableFive
    WHERE Num < 10
)

SELECT
    Num,
    Num * 5 AS Result
FROM TableFive;