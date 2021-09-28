using DesignPatterns.Behavioural.Command.CSharp.Examples;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.Factory.CSharp.DependencyInjection
{
    public class CommandRootComposition
    {
        public static ServiceProvider ConfigureServices()
        {
            IServiceCollection serviceProvider = new ServiceCollection();

            serviceProvider.AddSingleton<UserContext, UserContext>();
            serviceProvider.AddTransient<IGetUserCommand, GetUserCommand>();
            serviceProvider.AddTransient<IUpdateUserCommand, UpdateUserCommand>();

            return serviceProvider
                .BuildServiceProvider();
        }
    }
}
