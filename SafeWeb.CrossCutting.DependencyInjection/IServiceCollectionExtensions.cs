using Microsoft.Extensions.DependencyInjection;
using SafeWeb.CrossCutting.Security.Hash;
using SafeWeb.Data.Repositories;
using SafeWeb.Data.UnityOfWork;
using SafeWeb_Aplication.AppServices;
using SafeWeb_Aplication.Interfaces;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;
using SafeWeb_Domain.Services;

namespace SafeWeb.CrossCutting.DependencyInjection {
    public static class IServiceCollectionExtensions {
        public static IServiceCollection RegisterServices (this IServiceCollection services) {

            services.AddSingleton<IHash, Hash>();

            services.AddScoped<IUnityOfWork, UnityOfWork>();

            services.AddScoped(typeof (IAppService<>), typeof (AppService<>));
            services.AddScoped<IUsuarioAppService, UsuarioAppService> ();

            services.AddScoped(typeof (IService<>), typeof (Service<>));
            services.AddScoped<IUsuarioService, UsuarioService> ();

            services.AddScoped(typeof (IRepository<>), typeof (Repository<>));
            services.AddScoped<IUsuarioRepository, UsuarioRepository> ();

            return services;
        }
    }
}