--在这里我们可以编写任何操作数据库的代码

--首先要指向操作的数据库
use master
--go是文件分隔(类似类)，表示上面的语句结束了，下面是重新开始的新语句，和上面没有任何关系。
go
--判断数据库是否存在，存在删除了在建
if exists(select * from sysdatabases where name='CourseManageDB')
--删除数据库
drop database CourseManageDB
go

--创建数据库
create database CourseManageDB
on primary  
(
         --数据库的逻辑文件名（就是系统用的，必须唯一）
		 name='CourseManageDB_data',
		 --数据库物理文件名（绝对路径）
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_data.mdf',--主数据文件名
		 --数据库初始文件大小(一定要根据你的实际生产需求来定)
		 size=20MB,
		 --数据文件增值量（也要参考文件本身大小）
		 filegrowth=1MB
)
,
(     
		 name='CourseManageDB_data1',	
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_data1.ndf',--次要数据文件名	
		 size=20MB,
		 filegrowth=1MB
)

log on
(
         name='CourseManageDB_log',	
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_log.ldf',--日志文件名	
		 size=10MB,
		 filegrowth=1MB
)
go
--指向要操作的数据库
use CourseManageDB
go
--创建表格

--创建讲师表
if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go
create table Teacher
(
	TeacherId int identity(1000,1) primary key, --讲师编号，int类型，标识列(用于ID自增)，主键约束
	LoginAccount varchar(50) not null,    --登录账号，不能为空
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18) not null,  --check表的检查约束，密码，长度大于等于6并且小于等于18
	TeacherName nvarchar(20) not null,  --名字
	Phonenumber char(11) not null,     --手机号
	NowAddress nvarchar(100) default('地址不详')   --住址，默认不详，默认约束
)
go
--课程分类表
if exists (select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
     CategoryId  int identity(10,1) primary key,
     CategoryName varchar(20) not null    
)
go
--课程表
if exists (select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
     CourseId  int identity(1000,1)  primary key,
     CourseName nvarchar(50) not null ,
	 CourseContent nvarchar(500) not null,
	 ClassHour int not null,--课时
	 Credit int check(Credit>=1 and Credit<=30) not null, --学分，检查约束
	 CategoryId int references CourseCategory(CategoryId) not null,  --外键约束，名字最好和CourseCategory的CategoryId一样
	 TeacherId int references Teacher(TeacherId) not null
)
go

--添加测试数据
--老师表添加数据
insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)
values('xiketang01','12345678','常老师','13600000001'),
('xiketang02','123456','刘老师','13600000002'),
('xiketang03','123456','张老师','13600000003')

--课程分类表添加数据
insert into CourseCategory(CategoryName)values('SQLServer开发')
insert into CourseCategory values('.Net开发高级')


insert into Course(CourseName,CourseContent,ClassHour,Credit,CategoryId,TeacherId)
values('.Net/C#上位机开发VIP课程09','C#基础/OOP/SQL/WinFORM/ASP.NET/WPF/WCF','500','10','10','1000')

insert into Course
values('JAVA开发VIP课程10','Java基础/Springboot','500','10','11','1001')

--联合查询
select * from Course inner join CourseCategory on Course.CategoryId=CourseCategory.CategoryId

select * from CourseCategory
select * from Course
select * from Teacher

--修改
update Teacher set LoginPwd='922605',TeacherName='李老师' where TeacherId=1000


--删除
delete from Teacher where TeacherId='1002'

