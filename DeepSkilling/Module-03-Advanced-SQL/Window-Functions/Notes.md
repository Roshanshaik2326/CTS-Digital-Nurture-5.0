# SQL Window Functions

## Definition

Window Functions perform calculations across a set of rows without grouping the result.

Unlike GROUP BY, every row is retained.

---

## Functions Covered

### ROW_NUMBER()

Assigns a unique number to every row.

---

### RANK()

Assigns ranking with gaps after ties.

Example:

100
100
90

Ranks:

1
1
3

---

### DENSE_RANK()

Assigns ranking without gaps.

Example:

100
100
90

Ranks:

1
1
2

---

### LAG()

Returns previous row value.

---

### LEAD()

Returns next row value.

---

### FIRST_VALUE()

Returns the first value in the window.

---

### LAST_VALUE()

Returns the last value in the window.

---

## Advantages

- Reporting
- Ranking
- Running analysis
- Salary comparisons
- Time-series analysis