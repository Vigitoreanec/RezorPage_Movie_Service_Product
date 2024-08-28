using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Core;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Pages;
using Rezor_MoviePage.Services;
using Rezor_MoviePage.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

ConfigurationServices(builder.Services);

var app = builder.Build();
Configure(app, app.Environment);
app.Run();

void ConfigurationServices(IServiceCollection services)
{
    //services.AddSingleton<Order>();
    //services.AddSingleton<Ticket>();
    //services.AddSingleton<FormatedShedule>();

    services.AddSingleton<IPhotoService,PhotoService>();

    services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

    services.AddDbContext<MovieContext>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("MovieContext") ??
        throw new InvalidOperationException("Connection string 'MovieContext' not found.")));
    services.AddRazorPages();
}

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (!env.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseStaticFiles();

    app.UseRouting();
    app.UseEndpoints(x =>
    {
        x.MapRazorPages();
    });
}