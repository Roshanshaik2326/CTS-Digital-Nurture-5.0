# Ranking Functions

## ROW_NUMBER()

Assigns a unique sequential number to every row.

Example:

Salary

90000
90000
80000

ROW_NUMBER

1
2
3

--------------------------------

## RANK()

Same values receive the same rank.

Ranks skip numbers.

Example:

90000
90000
80000

Ranks

1
1
3

--------------------------------

## DENSE_RANK()

Same values receive the same rank.

No skipped numbers.

Example

90000
90000
80000

Ranks

1
1
2

--------------------------------

## Applications

• Leaderboards

• Top N Employees

• Student Rankings

• Sales Analysis

• Interview Questions

--------------------------------

Difference

ROW_NUMBER -> Unique numbers

RANK -> Gaps after ties

DENSE_RANK -> No gaps