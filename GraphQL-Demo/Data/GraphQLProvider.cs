using GraphQL_Demo.Data;
using GraphQL_Demo.Models.Types;
using HotChocolate;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL_Demo.Models
{

    public class GraphQLProvider
    {
        public static void AddGraphQLProvider(IServiceCollection services)
        {
            services.AddGraphQL(
                schemaProvider =>
                SchemaBuilder.New()
                .AddType<StudentDetailsType>()
                .AddType<StudentType>()
                .AddQueryType<StudentRepository>()
                .AddServices(schemaProvider)
                .Create());
        }
    }
}
