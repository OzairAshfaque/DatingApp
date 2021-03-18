using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using src.API.Interfaces;
using src.API.Services;

namespace src.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
                public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
                    services.AddScoped<ITokenService, TokenService>();
                    services.AddDbContext<DataContext>(options =>
                        {
                            options.UseSqlite(config.GetConnectionString("DafaultConnection"));
                    
                        });
                        
                    return services;

                    
        }
        
    }
}