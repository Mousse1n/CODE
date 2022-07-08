use [17bang];
go
create Database [19bang];
backup database [19bang] to Disk ='F:\\CODE\SQL\SQL19bang.bak';
Drop database [19bang];
Restore Database [19bang] from DIsk ='F:\\CODE\SQL\SQL19bang.bak';
--创建user表
go
Create Table [dbo].[User]
(
[Id] int not null primary key identity(1,1),
[UserName]  NVARCHAR(10) NULL, 
[PassWord]  Nvarchar(20) Null
);
drop Table dbo.[User]
Create Table [dbo].[KeyWord]
(
[Id] int not null primary key identity(1,1),
[Name] Nvarchar(10) null,
[Used] int null
);
drop Table dbo.[KeyWord]
--增加列邀请人（InvitedBy），类型为INT
--注意每次更改前必须要加一次Alter table [dbo].[User]

Alter table [dbo].[User] add InvitedBy int
Alter table [dbo].[User]
Alter Column InvitedBy NVARCHAR(10) null
Alter Table [dbo].[User] Drop Column InvitedBy
--观察“一起帮”的发布求助功能，试着建立表Problem
use [17bang]
go
create Table [dbo].[Problem]
(
[Id] int not null primary key identity(1,1),
[Title] nvarchar(20) null,
[Content] nvarchar(200) null,
[NeedRemoteHelp] bit null,
[Reward] int null,
[Createtime] DateTime not null,
[PublishTime] DateTime not null
)
drop Table dbo.Problem;
--在User表中插入以下四行数据
--文本类型数据，需要用单引号（''）括起来；而且，Unicode编码的文本，前面还要加上一个N
use[17bang]
go
insert dbo.[User]([UserName],[PassWord])values(N'17bang',1234);
insert dbo.[User]([UserName],[PassWord])values(N'Admin',N'NULL');
insert dbo.[User]([UserName])values(N'Admin-1');
insert dbo.[User]([UserName],[PassWord])values(N'SuperAdmin',123456);
insert dbo.[User]([UserName],[PassWord])values(N'17banggggg',12345);
insert dbo.[User]([UserName],[PassWord])values(N'S1',123456);
--将Problem表中的Reward全部更新为0
use [17bang]
go
update dbo.Problem set Reward = 0;
declare @errorSum int 
set @errorSum = 0
begin transaction
	begin 
	insert dbo.[User]([UserName],[PassWord])values(N'17bang',1234);
	set @errorSum = @errorSum+@@ERROR
	insert dbo.[User]([UserName],[PassWord])values(N'Admin',N'NULL');
	set @errorSum = @errorSum+@@ERROR
	insert dbo.[User]([UserName])values(N'Admin-1');
	set @errorSum = @errorSum+@@ERROR
	insert dbo.[User]([UserName],[PassWord])values(N'SuperAdmin',123456);
	set @errorSum = @errorSum+@@ERROR
	if(@errorSum>0)
	rollback transaction
	else
	commit transaction
	end 
	use[17bang]
	go 
	select * from [User]
	--回滚事务，撤销之前的删除行为
	use[17bang]
	go
	begin tran
	Delete dbo.[User]
	rollback
	commit
--	在User表中：

--查找没有录入密码的用户
--删除用户名（UserName）中包含“Admin”或者“17bang”字样的用户
use [17bang]
go
select [Id],[UserName] from [User] 
where [PassWord] IS NULL;
--如何判断一个值是不是NULL呢？我们只能使用 IS NULL：
--删除用户名（UserName）中包含“Admin”或者“17bang”字样的用户
begin tran 
select * from [User] 
where [UserName] LIKE'%17bang%' OR [UserName] LIKE '%Admin%'
Delete  [User]
where [UserName] LIKE'%17bang%' OR [UserName] LIKE '%Admin%'
rollback
commit
--在Problem表中：

--给所有悬赏（Reward）大于10的求助标题加前缀：【推荐】
use [17bang]
go
select * from dbo.Problem
begin tran 
update dbo.Problem set title =N'【推荐】'+title where Reward>10
rollback
--给所有悬赏大于20且发布时间（Created）在2019年10月10日之后的求助标题加前缀：【加急】
begin tran 
update dbo.Problem set title =N'【加急】'+title where Reward > 20 And CreateTime > '2019-10-10 00:00:00.000'
commit
--删除所有标题以中括号【】开头（无论其中有什么内容）的求助
begin tran 
Delete dbo.Problem where title Like N'【%】%'
commit
--查找Title中第5个起字符不为“数据库”且包含了百分号（%）的求助
select *from dbo.Problem 
where title NOT LIKE N'_数据库_' AND Title LIKE N'%#%%' ESCAPE N'#'
--在Keyword表中：
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
use [17bang]
go
select * from keyword
--找出所有被使用次数（Used）大于10小于50的关键字名称（Name）
select [Name] from KeyWord 
where Used>10AND Used<50
--如果被使用次数（Used）小于等于0，或者是NULL值，或者大于100的，将其更新为1
update KeyWord set Used =1 where Used <= 0 or USed >100 or Used is NUll
--删除所有使用次数为奇数的Keyword
delete KeyWord where not Used%2 =0
--在User表上的基础上：

--添加Id列，让Id成为主键
--添加约束，让UserName不能重复
use [17bang]
go
Delete [dbo].[User] where UserName = N's1';
ALTER TABLE [DBO].[User]
ADD CONSTRAINT UQ_UN UNIQUE(UserName); 
--在Problem表的基础上：

--为NeedRemoteHelp添加NOT NULL约束，再删除NeedRemoteHelp上NOT NULL的约束
--添加自定义约束，让Reward不能小于10
use [17bang]
go
ALTER TABLE [dbo].[Problem]
ALTER COlUMN NeedRemoteHelp bit NOT NULL
ALTER TABLE [dbo].[Problem]
ALTER COlUMN NeedRemoteHelp bit NULL
--添加自定义约束，让Reward不能小于10
ALTER TABLE [DBO].[Problem]
ADD CONSTRAINT CK_Problem_Reward CHECK(Reward>10); 

--将User表中Id列修改为可存储GUID的类型，并存入若干条包含GUID值的数据
--修改User表中Id列

Create Table [dbo].[NewIDUser]
(
[Id] varchar(50) not null primary key ,
[UserName]  NVARCHAR(10) NULL, 
[PassWord]  Nvarchar(20) Null
);

insert [dbo].[NewIDUser] VALUES(NEWID(),N'haha1',N'xixi')
insert [dbo].[NewIDUser] VALUES(NEWID(),N'haha2',N'xixi')
insert [dbo].[NewIDUser] VALUES(NEWID(),N'haha3',N'xixi')
insert [dbo].[NewIDUser] VALUES(NEWID(),N'haha4',N'xixi')

select * from NewIDUser

--在Problem中插入不同作者（Author）不同悬赏（Reward）的若干条数据，以便能完成以下操作：
ALTER Table [dbo].[problem]
ADD Author Nvarchar(20) null;
--查找出Author为“飞哥”的、Reward最多的3条求助
select TOP 3 * from Problem
where Author =N'飞哥'
Order by Reward DESC  
--所有求助，先按作者“分组”，然后在“分组”中按悬赏从大到小排序
select Author,Reward from dbo.Problem
Group by Author ,Reward
Order by Reward DESC
select * from Problem
--查找并统计出每个作者的：求助数量、悬赏总金额和平均值
select Author,count(*)As ProblemNumber,SUM(Reward) AS RewardSum,AVG(Reward) AS RewardAvg
from dbo.problem
Group by Author
--找出平均悬赏值少于10的作者并按平均值从小到大排序
select Author,  Avg(Reward) AS AvgReward from problem
Group by Author
Having Avg(Reward)<10
order by AvgReward ASC