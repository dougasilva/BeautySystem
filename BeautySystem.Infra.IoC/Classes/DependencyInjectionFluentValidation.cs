using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace BeautySystem.Infra.IoC.Classes
{
    public static class DependencyInjectionFluentValidation
    {
        public static IServiceCollection AddFluentValidationServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            
            return services;
        }
    }
}
