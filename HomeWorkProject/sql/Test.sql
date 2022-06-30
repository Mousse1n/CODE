use [19bang]
go 
select 888+98
--select 'aaa'+ 123
select N'aaa'+'bbb'
print 'aaa'+ 123
--print 'abc' = 'abc '
--print 100+10
SELECT 1 WHERE(NULL > 0);
SELECT 1 WHERE(NULL < 0);
SELECT 1 WHERE(NULL = 0);
SELECT 1 WHERE(NULL <> 0); 
SELECT 1 WHERE(NULL = '');
SELECT 1 WHERE(NULL = NULL); 
SELECT 1 WHERE(NULL <> NULL);
PRINT NULL+23;
PRINT NULL+'23';
SELECT 1 WHERE(NULL IS NULL);
create table Student
(
 [Id] int not null primary key identity(1,1),
 [Name] nvarchar(5) null,
 [Age] int null,
);
insert dbo.Student(Name,Age) values(N'可可',19);
insert dbo.Student(Name,Age) values(N'爱爱',21);
insert dbo.Student(Name,Age) values(N'aa',19);
insert dbo.Student(Name,Age) values(N'bb',28);
insert dbo.Student(Name,Age) values(N'cc',14);
insert dbo.Student(Name,Age) values(N'dd',26);
insert dbo.Student(Name,Age) values(N'ff',15);
insert dbo.Student(Name,Age) values(N'gg',21);
Alter TABLE Student ADD [Description] Nvarchar(100) Null;
Alter Table Student Alter Column[Name] Nvarchar(5) null;
update Student set [Description] =N'小可爱' where Id between 1 AND 2;
Select [Name]+[Description] from student;
select * from Student where Id<>3;
--<>或 !=。<> 仅出现在SQL中，而且是“标准”的，!=是T-SQL特有的，^_^
select * from Student
where Id Between 4 AND 7;
update Student set [Name] = N'没有' where Id= 3

begin tran;
--UPDATE Student set Age = Age+2;
--UPDATE Student set Age += 5;
--update Student Set [Name] = 
Rollback