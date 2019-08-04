using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using StudentExercisesAPI;
using System;
using System.Net.Http;
using Xunit;

namespace TestStudentExercisesAPI
{
    class APIClientProvider : IClassFixture<WebApplicationFactory<Startup>>
    {
        public HttpClient Client { get; private set; }
        private readonly WebApplicationFactory<Startup> _factory = new WebApplicationFactory<Startup>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureAppConfiguration((webbuilder, configbuilder) =>
                {
                    configbuilder
                        .SetBasePath(webbuilder.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.Testing.json")
                        .AddEnvironmentVariables();
                    configbuilder.Build();
                });
            });

        public APIClientProvider()
        {
            Client = _factory.CreateClient();
        }

        public void Dispose()
        {
            _factory?.Dispose();
            Client?.Dispose();
        }
    }
}
