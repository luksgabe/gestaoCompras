using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SafeWeb.CrossCutting.DependencyInjection;

namespace SafeWeb_Web
{
    public static class Extensions
    {
        public static void AddDependencyInjectionCustom(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterServices();
        }
    }
}
