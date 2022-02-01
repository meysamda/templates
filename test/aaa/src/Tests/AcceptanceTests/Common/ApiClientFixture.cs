using Test22.Presentation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using RESTFulSense.Clients;
using System.Net.Http;

namespace Test22.Tests.AcceptanceTests.Common
{
    public abstract class ApiClientFixture
    {
        protected readonly IRESTFulApiFactoryClient _client;
        protected readonly IRESTFulApiFactoryClient _authorizedClient;

        public ApiClientFixture()
        {
            var factory = new WebApplicationFactory<Startup>();
            var client = factory.CreateClient();

            var authorizedClient = factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication("Test").AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("Test",
                        options =>
                        {
                        });
                });
            }).CreateClient();

            _client = new RESTFulApiFactoryClient(client);
            _authorizedClient = new RESTFulApiFactoryClient(authorizedClient);
        }
    }
}
