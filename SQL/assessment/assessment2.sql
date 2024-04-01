use assesmentdb
--1. Write a query to display your birthday( day of week)----
select datename(weekday, '2001-09-29') as birthday_of_the_week 
--output--
Saturday

--2---Write a query to display your age in days
select DATEDIFF (day, '2001-09-29', getdate()) as my_age_in_days
--output--
8216

--3-----Write a query to display all employees information those who joined before 5 years in the current month
 
select * from tblEMP

update  tblEMP
set hiredate = '2019-03-10'
where empno between 7698 and  7782

select  * from tblEMP where  hiredate < DATEADD(YEAR, -5, GETDATE())  
 and  MONTH(hiredate) = MONTH(GETDATE())    

7499	jo	   designer	        8990	2019-03-05	70000.00	1000.00	30
7521	ram	  fashion designer	9000	2019-03-05	80000.00	2000.00	30
7566	JONES	MANAGER	        7839	2019-03-05	2975.00	     NULL	20
7654	MARTIN	SALESMAN	    7698	2019-03-05	1250.00	    1400.00	30
7698	BLAKE	MANAGER	        7839	2019-03-10	2850.00	     NULL	30
7782	CLARK	MANAGER	        7839	2019-03-10	2450.00	     NULL	10
 
 --output---


----4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
---a. First insert 3 rows 
----b. Update the second row sal with 15% increment  
---- c. Delete first row.
--After completing above all actions how to recall the deleted row without losing increment of second row.

--solution---
begin transaction 
create table  tblemployeee(
    empno int primary key ,
    ename varchar (30),
    sal decimal (10, 2),
    doj date 
)


insert into tblemployeee (empno, ename, sal, doj) values 
(1, 'ram', 20000, '2023-01-05'),
(2, 'sita', 10000, '2023-01-10'),
(3, 'hanuman', 5000, '2023-01-15')

select * from tblemployeee
--oo--
1	ram	    20000.00	   2023-01-05
2	sita	11500.00	2023-01-10
3	hanuman	5000.00	   2023-01-15


update tblemployeee set  sal = sal * 1.15 where  empno = 2

--output--
1	ram	    20000.00	    2023-01-05
2	sita	13225.00	2023-01-10
3	hanuman	5000.00	    2023-01-15

save transaction tillupd
delete from tblemployeee where  empno = 1
--oo---
2	sita	13225.00	2023-01-10
3	hanuman	5000.00	   2023-01-15

rollback transaction tillupd
select * from tblemployeee
commit transaction





---5--Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
--a.For Deptno 10 employees 15% of sal as bonus.
--b.For Deptno 20 employees  20% of sal as bonus
--c.For Others employees 5%of sal as bonus

create or alter function CalculateBonus (@deptno int , @sal decimal (10, 2)) 
returns decimal (10, 2)
as
begin
    declare @bonus decimal (10, 2)

   if  @deptno = 10
        set @bonus = @sal * 0.15;
   else if  @deptno = 20
        set @bonus = @sal * 0.20;
   else
        set @bonus = @sal * 0.05;

   return  @bonus
end 

---output1---
select  ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from  tblEmp
where  deptno = 10

CLARK	2450.00	367.50
KING	5000.00	750.00
MILLER	1300.00	195.00

--output2--

select  ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from  tblEmp
where  deptno = 20


JONES	2975.00	595.00
SCOTT	3000.00	600.00
ramya	7000.00	1400.00
ADAMS	1100.00	220.00
FORD	3000.00	600.00

--output3--
select  ename, sal, dbo.CalculateBonus(deptno, sal) as bonus from  tblEmp
where  deptno not in (10,20)

jo	70000.00	3500.00
ram	80000.00	4000.00
MARTIN	1250.00	62.50
BLAKE	2850.00	142.50
TURNER	1500.00	75.00
JAMES	950.00	47.50
























