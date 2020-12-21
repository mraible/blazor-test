using blazor.Configuration;
using blazor.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace blazor.Configuration {
    public static class NhipsterSettingsConfiguration {
        public static IServiceCollection AddNhipsterModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JHipsterSettings>(configuration.GetSection("jhipster"));
            return services;
        }
    }
}
