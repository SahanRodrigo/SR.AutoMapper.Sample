using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SR.AutoMapper.Sample.Domain.Repositories;

namespace SR.AutoMapper.Sample.Domain.Extensions
{
    public static class DomainServiceCollectionExtension
    {
        public static IServiceCollection AddDomainDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}