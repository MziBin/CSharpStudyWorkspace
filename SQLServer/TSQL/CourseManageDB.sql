--���������ǿ��Ա�д�κβ������ݿ�Ĵ���

--����Ҫָ����������ݿ�
use master
--go���ļ��ָ�(������)����ʾ������������ˣ����������¿�ʼ������䣬������û���κι�ϵ��
go
--�ж����ݿ��Ƿ���ڣ�����ɾ�����ڽ�
if exists(select * from sysdatabases where name='CourseManageDB')
--ɾ�����ݿ�
drop database CourseManageDB
go

--�������ݿ�
create database CourseManageDB
on primary  
(
         --���ݿ���߼��ļ���������ϵͳ�õģ�����Ψһ��
		 name='CourseManageDB_data',
		 --���ݿ������ļ���������·����
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_data.mdf',--�������ļ���
		 --���ݿ��ʼ�ļ���С(һ��Ҫ�������ʵ��������������)
		 size=20MB,
		 --�����ļ���ֵ����ҲҪ�ο��ļ�������С��
		 filegrowth=1MB
)
,
(     
		 name='CourseManageDB_data1',	
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_data1.ndf',--��Ҫ�����ļ���	
		 size=20MB,
		 filegrowth=1MB
)

log on
(
         name='CourseManageDB_log',	
		 filename='E:\ZeXi\CSharpCode\CSharpStudyWorkspace\SQLServer\DB\CourseManageDB_log.ldf',--��־�ļ���	
		 size=10MB,
		 filegrowth=1MB
)
go
--ָ��Ҫ���������ݿ�
use CourseManageDB
go
--������ʦ��
if exists(select * from sysobjects where name='Teacher')
drop table Teacher
go
create table Teacher
(
	TeacherId int identity(1000,1) primary key, --��ʦ��ţ�int���ͣ���ʶ�У�����Լ��
	LoginAccount varchar(50) not null,    --��¼�˺ţ�����Ϊ��
	LoginPwd varchar(18) check(len(LoginPwd)>=6 and len(LoginPwd)<=18) not null,  --���룬���ȴ��ڵ���6����С�ڵ���18
	TeacherName nvarchar(20) not null,  --����
	Phonenumber char(11) not null,     --�ֻ���
	NowAddress nvarchar(100) default('��ַ����')   --סַ��Ĭ�ϲ���
)
go
--�γ̷����
if exists (select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
     CategoryId  int identity(10,1) primary key,
     CategoryName varchar(20) not null    
)
go
--�γ̱�
if exists (select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
     CourseId  int identity(1000,1)  primary key,
     CourseName nvarchar(50) not null ,
	 CourseContent nvarchar(500) not null,
	 ClassHour int not null,--��ʱ
	 Credit int check(Credit>=1 and Credit<=30) not null, --ѧ��
	 CategoryId int references CourseCategory(CategoryId) not null,  --���Լ��
	 TeacherId int references Teacher(TeacherId) not null
)
go

--��ʦ����������
insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)
values('xiketang01','12345678','����ʦ','13600000001'),
('xiketang02','123456','����ʦ','13600000002'),
('xiketang03','123456','����ʦ','13600000003')

--�γ̷������������
insert into CourseCategory(CategoryName)
values()


select * from Course inner join CourseCategory on Course.CategoryId=CourseCategory.CategoryId