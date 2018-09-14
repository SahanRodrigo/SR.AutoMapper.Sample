using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SR.AutoMapper.Sample.Domain.Extensions;

namespace SR.AutoMapper.Sample.Services.Extensions
{
    public static class ServicesServiceCollectionExtension
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDomainDependencies(configuration);
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}