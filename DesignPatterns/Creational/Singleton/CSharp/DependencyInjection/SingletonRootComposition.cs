using DesignPatterns.Creational.Singleton.CSharp.Examples;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.Singleton.CSharp.DependencyInjection
{
    public class SingletonRootComposition
    {
        public static ServiceProvider ConfigureServices()
        {
            // do not use the code below
            // it is an antipattern to register a singleton with another singleton lifecycle implementation
            // it's better to use the DI container to handle the lifecycle of an object or service
            // thus, creating your own singleton implementations should be done only if you're not using a DI container

            IServiceCollection serviceProvider = new ServiceCollection()
                .AddSingleton<Universe, Universe>();

            return serviceProvider
                .BuildServiceProvider();
        }
    }
}
