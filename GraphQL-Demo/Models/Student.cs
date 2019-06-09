namespace GraphQL_Demo.Models
{
    public enum Gender
    {
        MALE,
        FEMALE,
        NONBINARY
    }

    public class StudentDetails
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string[] FriendIDs { get; set; }
    }

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public StudentDetails StudentDetails { get; set; }
    }
}

