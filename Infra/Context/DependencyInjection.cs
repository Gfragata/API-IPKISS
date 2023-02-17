using API_IPKISS.Service;
using API_IPKISS.Service.Interface;

namespace API_IPKISS.Infra.Context
{
    public class DependencyInjection
    {
        public static void ConfigureDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IBalanceService, BalanceService>();
        }
    }
}
