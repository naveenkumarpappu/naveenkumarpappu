--creating department table

create table DEPT(DEPTNO int primary key,
 DNAME varchar(15),
 LOC varchar(15))

insert into DEPT
values(10,'ACCOUNTING','NEW YORK')
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

-- creating Employee table

create table EMP
(EMPNO int primary key,
ENAME varchar(10),
JOB varchar(15),
MGR int, 
HIREDATE varchar(20),
SAL int, 
COMM int,
DEPTNO int foreign key references DEPT(DEPTNO)) 

insert into EMP
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)
--1. List all employees whose name begins with 'A'. 
SELECT ENAME
FROM EMP
WHERE ENAME LIKE 'A%';

--2. Select all those employees who don't have a manager. 
SELECT ENAME 
FROM EMP
WHERE MGR IS NULL;

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
SELECT ENAME,EMPNO,SAL
FROM EMP
WHERE SAL BETWEEN 1200 AND 1400;

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
SELECT ENAME,SAL,SAL+SAL*0.1 AS PAYRISE
FROM EMP 
WHERE DEPTNO = (SELECT DEPTNO
                FROM DEPT
				WHERE DNAME = 'RESEARCH')
  
-- 5. Find the number of CLERKS employed. Give it a descriptive heading.  
SELECT COUNT(JOB) AS NO_OF_CLERKS
FROM EMP
WHERE JOB='CLERK'
GROUP BY JOB;
            
--6. Find the average salary for each job type and the number of people employed in each job.
SELECT JOB,AVG(SAL) AS AVGSAL,COUNT(*) AS NO_OF_PEOPLE
FROM EMP
GROUP BY JOB;

--7. List the employees with the lowest and highest salary. 
SELECT MIN(SAL) AS MIN_SAL,MAX(SAL) AS MAX_SAL
FROM EMP

--8. List full details of departments that don't have any employees. 
SELECT *
FROM DEPT
WHERE DEPTNO not in(SELECT DEPTNO
               FROM EMP );

 --9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
 SELECT ENAME,SAL
 FROM EMP
 WHERE JOB ='ANALYST' AND SAL>1200 AND DEPTNO = 20
 ORDER BY ENAME ASC;

 --10. For each department, list its name and number together with the total salary paid to employees in that department. 
 SELECT DNAME,COUNT(*)DEPTNO,SUM(SAL)
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 GROUP BY DNAME	  
 
 --11. Find out salary of both MILLER and SMITH.
 SELECT ENAME,SAL
 FROM EMP
 WHERE ENAME IN('MILLER','SMITH') 

 --12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
 SELECT ENAME
 FROM EMP
 WHERE ENAME LIKE ('A%')
 OR ENAME LIKE ('M%')

 --13. Compute yearly salary of SMITH. 
 SELECT SAL*12 AS ANNUAL_SAL
 FROM EMP
 WHERE ENAME ='SMITH'

 --14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
 SELECT ENAME,SAL
 FROM EMP
 WHERE SAL  NOT BETWEEN '1500' AND '2850'
