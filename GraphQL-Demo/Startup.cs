using GraphQL_Demo.Models;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL_Demo
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Enable InMemory messaging services for subscription support.
            // services.AddInMemorySubscriptionProvider();
            services.AddMvc();
            // Add GraphQL Services
            GraphQLProvider.AddGraphQLProvider(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseMvc();
            app.UseGraphiQL();
            app.UsePlayground();
            app.UseGraphQL();
            //app.UseWebSockets();
            app.UseHsts();
        }
    }
}
