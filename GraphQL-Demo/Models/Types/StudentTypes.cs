using HotChocolate.Types;

namespace GraphQL_Demo.Models.Types
{

    public class StudentDetailsType
    : ObjectType<StudentDetails>
    {
        protected override void Configure(IObjectTypeDescriptor<StudentDetails> descriptor)
        {
            descriptor.Name("StudentDetails");
            descriptor.Field(t => t.Age).Type<IntType>();
            descriptor.Field(t => t.Gender).Type<EnumType<Gender>>();
            descriptor.Field(t => t.FriendIDs).Type<ListType<IdType>>();
        }

    }

    public class StudentType
        : ObjectType<Student>
    {
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
            descriptor.Name("Student");
            descriptor.Field(t => t.Id).Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Name).Type<NonNullType<NameType>>();
            descriptor.Field(t => t.StudentDetails).Type<StudentDetailsType>();
        }
    }

}
