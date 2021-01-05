using InversionOfControl_Exercise.Domain.Interfaces;
using InversionOfControl_Exercise.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InversionOfControl_Exercise.Dependencies
{
    public static class ServicesDependency
    {
        /*
        This extension method allows us to “add” methods to existing types without creating a new derived type.
        In this case, we extended the IServiceCollection type. This type provides an internal container service 
        called IServiceProvider which allows us to register our dependencies. 
        So, we can create a static method into the dependency class.
        */
        public static void AddClubServiceDependency(this IServiceCollection services)
        {
            /*
            Transient: services that will be created each time they are requested
            Scoped: services that will be created once per client request (connection)
            Singleton: services that will be created only at the first time they are requested
            */
            services.AddTransient<IServiceClub, ServiceClub>();
        }
    }
}
