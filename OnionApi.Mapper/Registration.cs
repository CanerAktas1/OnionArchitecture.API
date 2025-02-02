using Microsoft.Extensions.DependencyInjection;
using OnionApi.Application.Interfaces.AutoMapper;

namespace OnionApi.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
