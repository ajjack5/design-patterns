using DesignPatterns.Creational.Builder.CSharp.Examples.Normal;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.Builder.CSharp.DependencyInjection
{
    public class BuilderRootComposition
    {
        public static ServiceProvider ConfigureServices()
        {
            IServiceCollection serviceProvider = new ServiceCollection()
                .AddScoped<IEmailOrchestrator, EmailOrchestrator>();

            return serviceProvider
                .BuildServiceProvider();
        }
    }
}
