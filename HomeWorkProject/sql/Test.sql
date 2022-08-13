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
 [Score] int null
);
insert dbo.Student([Name],Age,SCore) values(N'可可',19,91);
insert dbo.Student([Name],Age,SCore) values(N'爱爱',21,82);
insert dbo.Student([Name],Age,SCore) values(N'aa',19,70);
insert dbo.Student([Name],Age,SCore) values(N'bb',28,69);
insert dbo.Student([Name],Age,SCore) values(N'cc',14,81);
insert dbo.Student([Name],Age,SCore) values(N'dd',26,19);
insert dbo.Student([Name],Age,SCore) values(N'ff',15.23);
insert dbo.Student([Name],Age,SCore) values(N'gg',21,72);
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
Drop Table IF Exists Teacher
create Table Teacher
(
Id int primary key identity(1,1),
[Name] Nvarchar (25),
Age Int,
Gender BIT


)
DROP TABLE Teacher
ALTER Table Teacher 
--ADD Constraint UQ_Teacher_Name UNIQUE([Name])
Drop Constraint UQ_Teacher_Name
Select [name],[type],is_unique,is_primary_key,is_unique_constraint
FROM sys.indexes
where object_id = OBJECT_ID('Teacher')





create unique Clustered Index IX_Teacher_Id on Teacher(Id)
Create UNique Index IX_Teacher_Name ON Teacher([Name])
Create Index IX_Teacher_Age ON Teacher(Age)
Create unique Index IX_Teacher_Name_Age on Teacher([Name],Age)
insert Teacher(Id,[Name]) Values(1,N'飞哥')
Drop INdex Teacher.IX_Teacher_Name_Age
Create  Index IX_Teacher_Name ON Teacher([Name])
ALTER Table Teacher
ALTER Column Age int NOT NULL

--分组
select age from student
where age>19
group By Age

--Having Age>19

select age from student
group By Age
Having Age>19



Select * from Teacher




INsert Teacher VALUes(N'飞哥',40,1) 
INsert Teacher VALUes(N'飞哥',40,1) 
INsert Teacher VALUes(N'飞哥',40,1) 
INsert Teacher VALUes(N'飞哥',40,1) 
INsert Teacher VALUes(N'飞哥',40,1) 
 
Select * From Teacher
--Where[name] = N'飞哥'
where Age >100

insert Teacher 
Select [Name],Age, Gender From Teacher

select * from Teacher where 150 =Id+23
ALTER TABLE Student 
ADD SCore int

ALTER TABLE Student 
ADD Grade NVARCHAR(25)

insert Student(Id,[Name],Age,SCore) VALUES(1,N'可可',19,91)

ALTER TABLE Student 
ADD Grade NVARCHAR(25)

UPDATE Student 
SET Grade = CASE
-- CASE 的启动
WHEN SCORE >= 80 THEN 'EXCELLENT'
WHEN SCORE >= 68 THEN 'Pass'
ELSE 'Failed'
END
select * from Student

Create TABlE ChangeTableSLS
(
	Id int primary key identity(1,1),
	[Name] Nvarchar(25),
	[Subject] Nvarchar(25),
	[Score] int
)

insert ChangeTableSLS Values (N'飞哥',N'SQL',98)
insert ChangeTableSLS Values (N'飞哥',N'C#',89)
insert ChangeTableSLS Values(N'飞哥',N'JavaScript',76)
insert ChangeTableSLS Values(N'路伟',N'C#',87)
insert ChangeTableSLS Values(N'路伟',N'SQL',95)
insert ChangeTableSLS Values(N'路伟',N'JavaScript',88)

SELECT[Name],
MAX(CASE [Subject] WHEN N'C#' THEN Score ELSE 0 END)AS N'C#',
MAX(CASE [Subject] WHEN N'SQL' THEN Score ELSE 0 END)AS N'SQL',
MAX(CASE [Subject] WHEN N'Javascript' THEN Score ELSE 0 END)AS N'JavaScript'
From ChangeTableSLS
GROUP By[Name]

select * from ChangeTableSLS