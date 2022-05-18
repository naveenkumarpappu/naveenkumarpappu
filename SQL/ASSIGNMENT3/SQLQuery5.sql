--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850
SELECT ENAME,SAL
FROM EMP
WHERE SAL NOT BETWEEN 1500 AND 2850

--2. Display the name and job of all employees who do not have a MANAGER. 
SELECT ENAME,JOB
FROM EMP
WHERE MGR IS NULL

--3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
 SELECT ENAME,JOB,SAL
 FROM EMP
 WHERE JOB IN('MANAGER','ANALYST')
 AND SAL NOT IN(1000,3000,5000);

 --4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
 SELECT ENAME,SAL,COMM
 FROM EMP
 WHERE COMM > SAL+SAL*.10

 --5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
 SELECT ENAME
 FROM EMP
 WHERE ENAME LIKE '%LL%'
 AND DEPTNO IN (30) OR MGR=7782

 --6. Display the names of employees with experience of over 10 years and under 20 yrs.Count the total number of employees.
 SELECT COUNT(*) AS NO_OF_EMPLOYEES,ENAME
FROM EMP
WHERE  CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))>10
AND CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))<20
GROUP BY ENAME

 --7. Retrieve the names of departments in ascending order and their employees in descending order.
 SELECT DNAME,ENAME
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 ORDER BY DNAME ASC,ENAME DESC
 
 --8. Find out experience of MILLER. 
 SELECT CONVERT(VARCHAR(5),DATEDIFF(YEAR,HIREDATE,GETDATE())) AS EXPERIENCE
 FROM EMP
 WHERE ENAME ='MILLER'

 --9. How many different departments are there in the employee table. 
 SELECT DNAME,COUNT(*) AS NO_OF_DEPARTMENTS
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 GROUP BY DNAME

 --10. Find out which employee either work in SALES or RESEARCH department. 
 SELECT ENAME
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 WHERE DNAME IN ('SALES','RESEARCH')

 --11. Print the name and average salary of each department. 
 SELECT DNAME,AVG(SAL) AS AVG_SAL
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 GROUP BY DNAME

 --12. Select the minimum and maximum salary from employee table. 
 SELECT MIN(SAL) AS MIN_SAL,MAX(SAL) AS MAX_SAL
 FROM EMP
 
 --13. Select the minimum and maximum salaries from each department in employee table. 
 SELECT DNAME,MIN(SAL) AS MIN_SAL,MAX(SAL) AS MAX_SAL
 FROM EMP JOIN DEPT ON EMP.DEPTNO=DEPT.DEPTNO
 GROUP BY DNAME

 --14. Select the details of employees whose salary is below 1000 and job is CLERK. 
 SELECT *
 FROM EMP
 WHERE SAL<1000 AND JOB='CLERK'