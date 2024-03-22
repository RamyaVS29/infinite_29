create database assesmentdb
use assesmentdb

---1 Create a book table with id as primary key and provide the appropriate data type to other attributes .isbn no should be unique for each book
---  Write a query to fetch the details of the books written by author whose name ends with er.



create table Book(
    id int primary key,
    title varchar(200),
	author varchar(200),
    isbn bigint unique,
    published_date datetime
)

insert into Book (id, title, author, isbn, published_date) values
(1, 'my first sql book', 'mary parker', 981483029127, '2012-02-22 12:08:17'),
(2, 'my second sql book', 'john mayer', 857300923713, '1972-07-03 09:22:45'),
(3, 'my third sql book', 'cary flint', 523120967812, '2015-10-18 14:05:44')

select * from Book

select *from Book
where  author LIKE '%er'

--review------Display the Title ,Author and ReviewerName for all the books from the above table 
create table Reviews (
    id int primary key ,
    book_id int,
    reviewer_name varchar(55),
    content varchar(60),
    rating int,
    published_date datetime
)

insert into Reviews (id, book_id, reviewer_name, content, rating, published_date) values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-22 23:47:10')



SELECT b.title, b.author, r.reviewer_name
FROM Book b
JOIN Reviews r ON b.id = r.book_id

--2----Display the  reviewer name who reviewed more than one book.

Select reviewer_name from Reviews
group by reviewer_name
Having COUNT(distinct id) > 1


---3----Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

create table  Customer (
    ID int primary key ,
    Name varchar(20),
    Address varchar(50),
    Salary decimal(10, 2),
    Age int
)

insert into Customer (ID, name, address, Salary, Age)
values 
(1, 'Ramesh', 'Ahmedabad', 2000.00, 32),
(2, 'Khilan', 'Delhi', 1500.00, 25),
(3, 'Kaushik', 'Kota', 2000.00, 23),
(4, 'Chaitali', 'Mumbai', 6500.00, 25),
(5, 'Hardik', 'Bhopal', 8500.00, 27),
(6, 'Komal', 'MP', 4500.00, 22),
(7, 'Muffy', 'Indore', 10000.00, 24)

select name from Customer
where address  LIKE '%o%'

---4-----
---Write a query to display the   Date,Total no of customer  placed order on same Date --


create table orders (
    oid int,
    date DATE,
    customer_id int,
    amount decimal(10, 2)
)


insert into orders (oid, date, customer_id, amount) values
(102, '2009-10-08', 3, 3000.00),
(100, '2009-10-08', 3, 1500.00),
(101, '2009-11-20', 2, 1560.00),
(103, '2008-05-20', 4, 2060.00)


select date, count(distinct customer_id) as Total_Customers
from orders
group by date 

---5---
---Display the Names of the Employee in lower case, whose salary is null 


create table employee (
    ID int primary key,
    Name varchar(10),
    AGE int,
    Address varchar(50),
    Salary DECIMAL(10, 2)
)


insert into employee (ID, Name , AGE, Address, Salary) values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP',NULL),
(7, 'Muffy', 24, 'Indore',NULL)

select* from employee

select  lower(Name) as Lowercase_Name
from employee
where Salary IS NULL

--6---
--Write a sql server query to display the Gender,Total no of male and female from the above   relation    .

                 

create table Studentdetails (
    RegisterNo int primary key,
    Name varchar(30),
    Age int,
    Qualification varchar(50),
    MobileNo varchar(15),
    Mail_id varchar(50),
    Location varchar(50),
    Gender varchar(10)
)


insert into Studentdetails (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender) values
(1, 'Sai', 22, 'B.E', '9952836777', 'Sai@gmail.com', 'Chennai', 'M'),
(2, 'Kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(3, 'Selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(4, 'Nisha', 25, 'Μ.Ε', '7834672310', 'Nisha@gmail.com', 'Theni', 'F'),
(5, 'SaiSaran', 21, 'B.A', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(6, 'Tom', 23, 'BCA', '8901234675', 'Tom@gmail.com', 'Pune', 'M')



select Gender, COUNT(*) as Total
from Studentdetails
group by  Gender


