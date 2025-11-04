using src.Repository;
using src.Repository.Interface;
using src.Service;
using src.Service.Interface;

namespace src;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddScoped<ICourseActivityService, CourseActivityService>();
        builder.Services.AddScoped<ICourseService, CourseService>();
        builder.Services.AddScoped<IProfileService, ProfileService>();

        builder.Services.AddScoped<ICourseActivityRepository, CourseActivityRepository>();
        builder.Services.AddScoped<ICourseRepository, CourseRepository>();
        builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

        builder.Services.AddControllers();

        var app = builder.Build();

        // app.UseHttpsRedirection();

        app.MapControllers();

        app.Run();
    }
}