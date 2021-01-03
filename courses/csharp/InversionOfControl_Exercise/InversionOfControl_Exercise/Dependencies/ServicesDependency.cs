using InversionOfControl_Exercise.Domain.Interfaces;
using InversionOfControl_Exercise.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InversionOfControl_Exercise.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddClubServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceClub, ServiceClub>();
        }
    }
}
