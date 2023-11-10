
using LibraryManagement.Application;
using LibraryManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Configuration;
public static class ServiceRegistration
{
    public static IServiceCollection AddBookServices(this IServiceCollection services, IConfiguration configuration)
    {
        string dbSource = configuration.GetConnectionString("dbSource")!;

        services.AddDbContext<BookDbContext>(options =>
            options.UseSqlServer(dbSource));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
        services.AddScoped<IBookRepository, BookRepository>();

        services.AddScoped<IBookService, BookApplicationService>();
        return services;
    }}