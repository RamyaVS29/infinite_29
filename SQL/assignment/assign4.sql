use assignmentDB
--transact sequel---
declare @num int =10
declare @result bigint = 1
declare @i int = 1
while @i <= @num
begin
    set @result = @result * @i
    set @i = @i + 1
end
select @result as Factorial

--2--
--multiplication table--
create  or alter procedure  multiplicationtable
@maxNumber int
as
begin
    declare @i int= 1
while @i <= @maxNumber
  begin
       declare @j int = 1

       while @j <= 10
        begin      print CONCAT(@i, ' * ', @j, ' = ', @i * @j)
            set @j = @j + 1
        end

      print''
        set @i = @i + 1
		if @i > @maxnumber
		break
    end
end
exec  multiplicationTable @maxNumber = 5

--3--holiday table
create table Holiday (
    holiday_date  date primary key ,
    holiday_name varchar(250)
 )

 insert into  Holiday (holiday_date, holiday_name) values
('2024-01-14', 'Pongal'),
('2024-11-04', 'Diwali'),
('2024-01-26','Republic Day'),
('2025-01-01', 'New Year')

select * from holiday


create OR alter trigger  restrictdatmanipulating
on tblEMP
after insert , update , delete 
as
begin
declare  @holiday_name varchar(250);
  select  @holiday_name = holiday_name
  from  Holiday
    where  holiday_date = '2024-08-26'
 if  @holiday_name is not null
   begin
       raiserror ('Due to %s, you cannot manipulate data', 16, 1, @HolidayName);
   rollback transaction
    end
end
insert into Holiday (holiday_date, holiday_name) values ('2024-08-26' , 'Republic Day')
insert into  tblEMP (empno, ename) values  (8888, 'swathi')
select * from tblEMP

delete from  tblEMP where  empno = 8888