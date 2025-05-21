
-- 判断数据库是否存在，如果存在则删除
DROP DATABASE IF EXISTS CourseManageDB;

-- 创建数据库
CREATE DATABASE CourseManageDB;

-- 切换到新创建的数据库上下文
USE CourseManageDB;

-- 创建讲师表
DROP TABLE IF EXISTS Teacher;
CREATE TABLE Teacher (
    TeacherId INT AUTO_INCREMENT PRIMARY KEY, -- 讲师编号，int 类型，自增主键
    LoginAccount VARCHAR(50) NOT NULL,        -- 登录账号，不能为空
    LoginPwd VARCHAR(18) NOT NULL CHECK (LENGTH(LoginPwd) BETWEEN 6 AND 18), -- 密码，长度大于等于 6 并且小于等于 18
    TeacherName VARCHAR(20) NOT NULL,         -- 名字
    Phonenumber CHAR(11) NOT NULL,            -- 手机号
    NowAddress VARCHAR(100) DEFAULT '地址不详' -- 住址，默认不详
) ENGINE = InnoDB;

-- 课程分类表
DROP TABLE IF EXISTS CourseCategory;
CREATE TABLE CourseCategory (
    CategoryId INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(20) NOT NULL
) ENGINE = InnoDB;

-- 课程表
DROP TABLE IF EXISTS Course;
CREATE TABLE Course (
    CourseId INT AUTO_INCREMENT PRIMARY KEY,
    CourseName VARCHAR(50) NOT NULL,
    CourseContent TEXT NOT NULL, -- 使用 TEXT 类型存储较长的内容
    ClassHour INT NOT NULL,      -- 课时
    Credit INT NOT NULL CHECK (Credit BETWEEN 1 AND 30), -- 学分，检查约束
    CategoryId INT,
    TeacherId INT,
    FOREIGN KEY (CategoryId) REFERENCES CourseCategory(CategoryId), -- 外键约束
    FOREIGN KEY (TeacherId) REFERENCES Teacher(TeacherId) -- 外键约束
) ENGINE = InnoDB;

-- 添加测试数据
-- 老师表添加数据
INSERT INTO Teacher (LoginAccount, LoginPwd, TeacherName, Phonenumber)
VALUES ('xiketang01', '12345678', '常老师', '13600000001'),
       ('xiketang02', '123456', '刘老师', '13600000002'),
       ('xiketang03', '123456', '张老师', '13600000003');

-- 课程分类表添加数据
INSERT INTO CourseCategory (CategoryName) VALUES ('SQLServer开发'), ('.Net开发高级');

-- 课程表添加数据
-- 注意：由于 CourseCategory 和 Teacher 表中已经插入了数据，我们可以使用这些数据的 ID
INSERT INTO Course (CourseName, CourseContent, ClassHour, Credit, CategoryId, TeacherId)
VALUES ('.Net/C#上位机开发VIP课程09', 'C#基础/OOP/SQL/WinFORM/ASP.NET/WPF/WCF', 500, 10, 1, 1),
       ('JAVA开发VIP课程10', 'Java基础/Springboot', 500, 10, 2, 2);

-- 联合查询
SELECT * FROM Course
INNER JOIN CourseCategory ON Course.CategoryId = CourseCategory.CategoryId;

-- 单独查询
SELECT * FROM CourseCategory;
SELECT * FROM Course;
SELECT * FROM Teacher;

-- 修改
UPDATE Teacher SET LoginPwd = '922605', TeacherName = '李老师' WHERE TeacherId = 1;

-- -- 删除
-- -- DELETE FROM Teacher WHERE TeacherId = 2;
-- ```
-- 
-- 通过以上修改，确保了创建的表使用支持外键约束的存储引擎，并且在数据库配置正确的情况下，外键约束能够正常生效。