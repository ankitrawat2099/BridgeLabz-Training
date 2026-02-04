/* =========================================================
   COMPLETE RDBMS SQL SCRIPT
   Database: practice_db
   Table: student_records
   Covers:
   RDBMS, Normalization, DDL, DML, DCL, TCL,
   Indexes, Window Functions
   ========================================================= */


/* =========================================================
   DATABASE
   Syntax:
   CREATE DATABASE database_name;
   ========================================================= */
--CREATE DATABASE practice_db;


/* =========================================================
   USE DATABASE
   Syntax:
   USE database_name;
   ========================================================= */
USE practice_db;


/* =========================================================
   NORMALIZED SUPPORT TABLE (3NF)
   ========================================================= */


/* =========================================================
   DDL – CREATE TABLE
   Syntax:
   CREATE TABLE table_name (column datatype constraint);
   ========================================================= */

CREATE TABLE departments (
    dept_id INT PRIMARY KEY,
    dept_name VARCHAR(50) UNIQUE
);

CREATE TABLE student_records (
    student_id INT PRIMARY KEY,
    student_name VARCHAR(100) NOT NULL,
    marks INT CHECK (marks >= 0),
    dept_id INT,
    FOREIGN KEY (dept_id) REFERENCES departments(dept_id)
);


/* =========================================================
   DML – INSERT
   Syntax:
   INSERT INTO table VALUES (...);
   ========================================================= */

INSERT INTO departments VALUES
(1, 'Computer Science'),
(2, 'Mechanical'),
(3, 'Electrical');

INSERT INTO student_records VALUES
(101, 'Aman', 85, 1),
(102, 'Neha', 90, 1),
(103, 'Rohit', 78, 2),
(104, 'Pooja', 92, 3),
(105, 'Karan', 88, 2);


/* =========================================================
   DQL – SELECT
   Syntax:
   SELECT columns FROM table;
   ========================================================= */

SELECT * FROM student_records;


/* =========================================================
   RDBMS – JOIN
   Syntax:
   SELECT columns
   FROM table1 JOIN table2 ON condition;
   ========================================================= */

SELECT S.student_name, S.marks, D.dept_name
FROM student_records S
INNER JOIN departments D
ON S.dept_id = D.dept_id;


/* =========================================================
   DML – UPDATE
   Syntax:
   UPDATE table SET column=value WHERE condition;
   ========================================================= */

UPDATE student_records
SET marks = 95
WHERE student_id = 102;


/* =========================================================
   DML – DELETE
   Syntax:
   DELETE FROM table WHERE condition;
   ========================================================= */

DELETE FROM student_records
WHERE student_id = 105;


/* =========================================================
   DDL – ALTER
   Syntax:
   ALTER TABLE table ADD column datatype;
   ========================================================= */

ALTER TABLE student_records
ADD email VARCHAR(100);


/* =========================================================
   DCL – GRANT
   Syntax:
   GRANT privilege ON object TO user;
   ========================================================= */

GRANT SELECT ON student_records TO user1;


/* =========================================================
   DCL – REVOKE
   Syntax:
   REVOKE privilege ON object FROM user;
   ========================================================= */

REVOKE SELECT ON student_records FROM user1;


/* =========================================================
   TCL – TRANSACTION
   Syntax:
   BEGIN TRANSACTION;
   COMMIT;
   ROLLBACK;
   ========================================================= */

BEGIN TRANSACTION;

UPDATE student_records
SET marks = marks + 5
WHERE dept_id = 1;

ROLLBACK;
-- COMMIT;


/* =========================================================
   INDEXES
   ========================================================= */


/* -------------------------
   CLUSTERED INDEX
   Note:
   PRIMARY KEY creates it by default
   ------------------------- */


/* -------------------------
   NON-CLUSTERED INDEX
   Syntax:
   CREATE INDEX index_name ON table(column);
   ------------------------- */

CREATE INDEX idx_marks
ON student_records (marks);


/* -------------------------
   COMPOSITE INDEX
   Syntax:
   CREATE INDEX index_name ON table(col1, col2);
   ------------------------- */

CREATE INDEX idx_dept_marks
ON student_records (dept_id, marks);


/* =========================================================
   WINDOW FUNCTIONS
   ========================================================= */


/* -------------------------
   ROW_NUMBER()
   Syntax:
   ROW_NUMBER() OVER (ORDER BY column)
   ------------------------- */

SELECT student_name, marks,
ROW_NUMBER() OVER (ORDER BY marks DESC) AS row_num
FROM student_records;


/* -------------------------
   RANK()
   Syntax:
   RANK() OVER (ORDER BY column)
   ------------------------- */

SELECT student_name, marks,
RANK() OVER (ORDER BY marks DESC) AS rank_value
FROM student_records;


/* -------------------------
   DENSE_RANK()
   Syntax:
   DENSE_RANK() OVER (ORDER BY column)
   ------------------------- */

SELECT student_name, marks,
DENSE_RANK() OVER (ORDER BY marks DESC) AS dense_rank_value
FROM student_records;


/* -------------------------
   SUM() OVER()
   Syntax:
   SUM(column) OVER (PARTITION BY column)
   ------------------------- */

SELECT student_name, dept_id, marks,
SUM(marks) OVER (PARTITION BY dept_id) AS dept_total_marks
FROM student_records;


/* -------------------------
   AVG() OVER()
   Syntax:
   AVG(column) OVER ()
   ------------------------- */

SELECT student_name, marks,
AVG(marks) OVER () AS avg_marks
FROM student_records;


