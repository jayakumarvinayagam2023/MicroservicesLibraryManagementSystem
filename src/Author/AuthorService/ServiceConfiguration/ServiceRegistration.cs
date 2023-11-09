
using LibraryManagement.Application;
using LibraryManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Configuration;
public static class ServiceRegistration
{
    public static IServiceCollection AddAuthorServices(this IServiceCollection services, IConfiguration configuration)
    {
        string dbSource = configuration.GetConnectionString("dbSource")!;

        services.AddDbContext<AuthorDbContext>(options =>
            options.UseMySql(dbSource, ServerVersion.AutoDetect(dbSource)));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
        services.AddScoped<IAuthorRepository, AuthorRepository>();

        services.AddScoped<IAuthorService, AuthorApplicationService>();
        return services;
    }}