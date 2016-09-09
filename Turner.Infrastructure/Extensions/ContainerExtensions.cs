using FluentValidation;
using SimpleInjector;
using System.Reflection;

namespace Turner.Infrastructure.Extensions
{
    public static class ContainerExtensions
    {
        public static void ConfigureInfrastructure(this Container container)
        {
            container.Register(typeof(IValidator<>), new[] { Assembly.GetCallingAssembly() });
        }
    }
}