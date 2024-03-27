use assignmentDB

create table  tblpayslip (
    id int primary key,
	name varchar(20), 
    stipend decimal(10, 2)
)
 
insert into tblpayslip 
values
(101,'jothi',50000.00),
(102,'hemashree',30000.00),
(103,'sahana',null),
(107,'chaan',25000.00),
(105,'pav',25000.00),
(104,'danu',20000.00),
(108,'manu',null),       
(106,'sonu',10000.00),
(112,'amar',15000.00)
 
create OR alter procedure payslip
    @id int
as
begin
    declare  @stipend decimal(10, 2) = (select stipend FROM tblpayslip where  id = @id);
    declare @hra decimal(10, 2) = @stipend  * 0.1;
    declare @da decimal(10, 2) = @stipend* 0.2;
    declare @pf decimal(10, 2) = @stipend * 0.08;
    declare @it decimal(10, 2) = @stipend * 0.05;
    declare @deductions decimal(10, 2) = @hra + @da + @pf + @it;
    declare  @grossstipend decimal(10, 2) = @stipend + @hra + @da;
    declare  @netstipend decimal(10, 2) = @stipend - @deductions
 
    select 
        @id as empid,
        @stipend as Basicstipend,
        @hra as HRA,
        @da as DA,
        @pf as PF,
        @it as IT,
        @deductions as Deductions,
        @grossstipend as  Grossstipend,
        @netstipend as  Netstipend;
end
exec payslip @id = 101



