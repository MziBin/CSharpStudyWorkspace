using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    public class 集合泛型
    {
        public void StudentList()
        {
            #region List集合的使用
            //集合初始化:方式一
            List<Student> students1 = new List<Student>();
            students1.Add(new Student { Id = 1, Name = "Tom", Age = 18, Class = "1班", Score = 90 });
            students1.Add(new Student { Id = 2, Name = "Jerry", Age = 19, Class = "2班", Score = 85 });
            students1.Add(new Student { Id = 3, Name = "Mike", Age = 17, Class = "1班", Score = 95 });
            //集合初始化:方式二，list初始化器语法
            List<Student> students2 = new List<Student>()
            { 
                //拆用的是对象初始化语法
                new Student { Id = 4, Name = "Lily", Age = 18, Class = "2班", Score = 80 },
                new Student { Id = 5, Name = "Lucy", Age = 19, Class = "1班", Score = 85 },
                new Student { Id = 6, Name = "Lucas", Age = 17, Class = "2班", Score = 90 }
            };
            //集合遍历
            foreach (var student in students1)
            {
                Console.WriteLine("Id:{0},Name:{1},Age:{2},Class:{3},Score:{4}", student.Id, student.Name, student.Age, student.Class, student.Score);
            }
            //集合排序
            //students1.Sort();//这样会报错，因为没有指定排序的条件
            //会调用我们重写的CompareTo方法，按照Score属性进行排序
            students1.Sort();
            students1.Reverse();//倒序

            //根据我们自定义的比较器进行排序，原理是多态的应用
            students1.Sort(new StudentDesc());//降序
            students1.Sort(new StudentAsc());//升序

            //集合获取
            Student studentA = students1[0];//索引获取

            //集合添加

            //集合修改

            //集合查找

            //集合删除

            //集合统计

            //集合转换

            //集合合并

            //集合分组

            #endregion

            #region Dictionary集合的使用
            //集合初始化
            Dictionary<string, Student> studentsDict1 = new Dictionary<string, Student>();
            studentsDict1.Add("Tom", new Student { Id = 1, Name = "Tom", Age = 18, Class = "1班", Score = 90 });
            studentsDict1.Add("Jerry", new Student { Id = 2, Name = "Jerry", Age = 19, Class = "2班", Score = 85 });
            studentsDict1.Add("Mike", new Student { Id = 3, Name = "Mike", Age = 17, Class = "1班", Score = 95 });
            //集合的初始化方式二，使用字典初始化器语法
            Dictionary<string, Student> studentsDict2 = new Dictionary<string, Student>()
            {
                {"Lily", new Student { Id = 4, Name = "Lily", Age = 18, Class = "2班", Score = 80 }},
                {"Lucy", new Student { Id = 5, Name = "Lucy", Age = 19, Class = "1班", Score = 85 }},
                {"Lucas", new Student { Id = 6, Name = "Lucas", Age = 17, Class = "2班", Score = 90 }}
            };
            //Dictionary的获取
            Student studentC = studentsDict1["Tom"];


            //集合添加
            studentsDict1.Add("Lily", new Student { Id = 4, Name = "Lily", Age = 18, Class = "2班", Score = 80 });

            //集合遍历
            foreach (var student in studentsDict1)
            {
                Console.WriteLine("Key:{0},Value:{1}", student.Key, student.Value);
            }

            Dictionary<int, Student> students3 = new Dictionary<int, Student>();
            students3.Add(1, new Student { Id = 1, Name = "Tom", Age = 18, Class = "1班", Score = 90 });
            students3.Add(2, new Student { Id = 2, Name = "Jerry", Age = 19, Class = "2班", Score = 85 });
            students3.Add(3, new Student { Id = 3, Name = "Mike", Age = 17, Class = "1班", Score = 95 });
            //集合遍历
            foreach (var student in students3)
            {
                Console.WriteLine("Id:{0},Name:{1},Age:{2},Class:{3},Score:{4}", student.Value.Id, student.Value.Name, student.Value.Age, student.Value.Class, student.Value.Score);
            }
            //集合添加
            students3.Add(4, new Student { Id = 4, Name = "Lily", Age = 18, Class = "2班", Score = 80 });
            //集合修改
            students3[1] = new Student { Id = 1, Name = "Tom", Age = 18, Class = "1班", Score = 95 };
            //集合查找
            Student studentB = students3[1];
            //集合删除
            students3.Remove(2);
            //集合统计
            int count = students3.Count;
            //集合转换
            List<Student> students4 = students3.Values.ToList();
            //集合合并
            //students3.Union(students2);
            //集合分组
            //var groups = students3.GroupBy(s => s.Class);
            //foreach (var group in groups)
            //{
            //    Console.WriteLine("Class:{0},Count:{1}", group.Key, group.Count());
            //}
            #endregion

        }
    }

    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public int Score { get; set; }
        //重写IComparable<Student>接口的CompareTo方法
        public int CompareTo(Student other)
        {
            //this在前面是升序，如果想降序，则改为other.Score.CompareTo(this.Score)
            return this.Score.CompareTo(other.Score);//这里调用的是int的CompareTo方法
        }
    }

    //自定义比较器
    class StudentDesc : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //降序
            return y.Score.CompareTo(x.Score);
        }
    }
    //自定义比较器
    class StudentAsc : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            //升序
            return x.Score.CompareTo(y.Score);
        }
    }
}
