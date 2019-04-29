using System.Collections.Generic;
using System.Linq;
using Excalibur;
using Xunit;

namespace ExTest
{
    public class LinqTest
    {
        [Fact]
        public void DistinctBy()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("tom", 12, "male"));
            students.Add(new Student("jerry", 12, "male"));
            students.Add(new Student("alice", 12, "female"));

            var list1 = students.DistinctBy(stu => new {stu.Age}).ToArray();
            var list2 = students.DistinctBy(stu => new {stu.Age, stu.Gender}).ToArray();
            var list3 = students.DistinctBy(stu => new {stu.Age, stu.Name}).ToArray();
        }

        [Fact]
        public void NewTest()
        {
            Student alice = new Student("alice", 12, "female");
            var foo = new {alice.Name, alice.Age};
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }

            public Student(string name, int age, string gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }

            public Student()
            {
            }
        }
    }
}