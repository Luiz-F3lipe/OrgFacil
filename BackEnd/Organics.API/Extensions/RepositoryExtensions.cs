using Microsoft.Extensions.DependencyInjection;
using Organics.API.Domain.Repositorie;
using Organics.API.Infra.Repositories;

namespace Organics.API.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IProviderRepositorie, ProviderRepositorieWithList>();
            return services;
        }
    }
}
