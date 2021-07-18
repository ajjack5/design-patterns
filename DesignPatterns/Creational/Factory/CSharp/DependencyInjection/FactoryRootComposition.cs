using DesignPatterns.Creational.Factory.CSharp.Examples.Generics;
using DesignPatterns.Creational.Factory.CSharp.Examples.NonGenerics;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.Factory.CSharp.DependencyInjection
{
    public class FactoryRootComposition
    {
        public static ServiceProvider ConfigureServices()
        {
            IServiceCollection serviceProvider = new ServiceCollection()
                .AddSingleton<IEmployeeManagementFactory, EmployeeManagementFactory>()
                .AddSingleton<IFruitFactory, FruitFactory>();

            return serviceProvider
                .BuildServiceProvider();
        }
    }
}
