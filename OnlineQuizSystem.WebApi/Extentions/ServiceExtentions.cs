using OnlineQuizSystem.Domain.Repositories;
using OnlineQuizSystem.Repository;
using OnlineQuizSystem.Service;
using OnlineQuizSystem.Service.Contracts;

namespace OnlineQuizSystem.WebApi.Extentions;

public static class ServiceExtentions
{
    //TODO: Use Scrator for simple registration
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    }

    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
    }
}
