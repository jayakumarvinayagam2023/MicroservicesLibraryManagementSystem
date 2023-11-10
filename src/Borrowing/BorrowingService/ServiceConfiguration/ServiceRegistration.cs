
using LibraryManagement.Application;
using LibraryManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Configuration;
public static class ServiceRegistration
{
    public static IServiceCollection AddBorrowingServices(this IServiceCollection services, IConfiguration configuration)
    {
        string dbSource = configuration.GetConnectionString("dbSource")!;

        services.AddDbContext<BorrowingDbContext>(options =>
            options.UseNpgsql(dbSource));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
        services.AddScoped<IBorrowingRepository, BorrowingRepository>();

        services.AddScoped<IBorrowingService, BorrowingApplicationService>();
        return services;
    }
}