using DynaBlazor.Common.Interfaces.Components;
using DynaBlazor.Common.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DynaBlazor.Common.DependencyInjection
{
    public static class ToastRegistration
    {
        public static IServiceCollection AddDynToast(this IServiceCollection services)
        {
            services.AddScoped<IDynToast,ToastComponentService>();
            return services;
        }
    }
}
