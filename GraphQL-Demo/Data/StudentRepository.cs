using GraphQL_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL_Demo.Data
{
    public class StudentRepository
    {
        private static Dictionary<string, Student> Students = new Dictionary<string, Student>();

        static StudentRepository()
        {
            Student[] studentsList = new[] {
                new Student { Id = "001", Name = "Vaishnavi", StudentDetails = new StudentDetails { Age = 32, Gender = Gender.FEMALE, FriendIDs = new []{ "002" } } },
                new Student { Id = "002", Name = "Karthik",   StudentDetails = new StudentDetails { Age = 33, Gender = Gender.MALE,   FriendIDs = new []{ "003" } } },
                new Student { Id = "003", Name = "Papa",      StudentDetails = new StudentDetails { Age = 15, Gender = Gender.FEMALE, FriendIDs = new []{ "001" } } }
            };
            Students = studentsList.ToDictionary(student => student.Id);
        }

        public StudentRepository()
        {
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students.Values;
        }

        /// <param name="Id">The Student Id.</param>
        public Student GetStudent(string Id)
        {
            Console.WriteLine(Id);

            if (Id == null || !Students.ContainsKey(Id))
                return null;
            return Students[Id];
        }

        public void RemoveStudent(String Id)
        {
            Students.Remove(Id);
        }

        public void UpdateStudent(String Id, Student Value)
        {
            if (Id.Equals(Value.Id))
            {
                Students[Id] = Value;
            }
        }

        public void AddStudent(Student Value)
        {
            Students.Add(Value.Id, Value);
        }

    }
}
