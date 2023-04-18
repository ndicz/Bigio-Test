using Bigio.Service;
using Bigio.Services.Abstraction;
using BigioWebAPI.Extensions;
using Microsoft.Extensions.FileProviders;

internal class Program
{

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ILoggerManager logger = new LoggerManager();

        // Add services to the container.
        builder.Services.ConfigureCors();
        builder.Services.ConfigureIISIntegration();
        builder.Services.ConfigureDbContext(builder.Configuration);
        builder.Services.ConfigureRepositoryManager();
 
        builder.Services.ConfigureLoggerService();


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseStaticFiles();

        app.ConfigureExceptionHandler(logger);
        app.UseHttpsRedirection();

        //add custom
        app.UseStaticFiles();
        app.UseCors("CorsPolicy");

        // add custome

        // set folder resources to static file
      

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}