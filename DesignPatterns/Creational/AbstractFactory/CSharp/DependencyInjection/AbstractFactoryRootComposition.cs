using DesignPatterns.Creational.AbstractFactory.CSharp.Examples.Generics;
using DesignPatterns.Creational.AbstractFactory.CSharp.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DesignPatterns.Creational.AbstractFactory.CSharp.DependencyInjection
{
    public class AbstractFactoryRootComposition
    {
        public static ServiceProvider ConfigureServices()
        {
            IServiceCollection serviceProvider = new ServiceCollection()
                .AddSingleton<IAbstractFactory, Factory1>() // this line shows only registering 1 abstract factory in a DI container, you cannot provide 2 implementations for 1 interface
                .AddHttpClient(); // this is the supported way to inject a factory such as IHttpClientFactory

            System.Reflection.Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(item => item.GetInterfaces()
                .Where(i => i.IsGenericType).Any(i => i.GetGenericTypeDefinition() == typeof(IFurnitureFactory<>)) && !item.IsAbstract && !item.IsInterface)
                .ToList()
                .ForEach(assignedTypes =>
                {
                    var serviceType = assignedTypes.GetInterfaces().First(i => i.GetGenericTypeDefinition() == typeof(IFurnitureFactory<>));
                    serviceProvider.AddScoped(serviceType, assignedTypes); // dependency injection with generics using reflection without needing to specify each sub factory
                });

            return serviceProvider
                .BuildServiceProvider();
        }
    }
}
