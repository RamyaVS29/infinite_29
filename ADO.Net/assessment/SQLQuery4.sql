create database Employeemanagement
use Employeemanagement

create table  Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10,2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('P', 'C'))
)
select * from Employee_Details

---Empno	EmpName	Empsal	Emptype---


create or alter procedure addemployee
    @EmpName varchar (50),
    @Empsal numeric(10,2),
    @Emptype char(1)
as
begin
declare @Empno int
   select @Empno = ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details;

    insert into Employee_Details (Empno, EmpName, Empsal, Emptype)
    values (@Empno, @EmpName, @Empsal, @Emptype)
end 

select * from Employee_Details
--output after first insertion---
--1	Ramya 	30000.00	C--
--after making bulk insertion--

Empno EmpName	Empsal	Emptype
1	Ramya 	30000.00	C
2	Hemshree25000.00	P
3	Sahana	26000.00	C
4	Pragya	27000.00	P
5	Lavanya	26000.00	P
6	Yash	27000.00	C