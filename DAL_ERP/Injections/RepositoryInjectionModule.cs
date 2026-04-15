using Microsoft.AspNetCore.Http;
using DAL_ERP.IRepository;
using DAL_ERP.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace DAL_ERP.Injections
{
    public static class RepositoryInjectionModule
    {
        /// <summary>
        ///  Dependency inject DbContextFactory and CustomerRepository
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// 
       
        public static IServiceCollection InjectPersistence(this IServiceCollection services)
        {
            services.AddScoped<IDbContextFactory, DbContextFactory>();
            services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            
            return services;
        }
    }
}


