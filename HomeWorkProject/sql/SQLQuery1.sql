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