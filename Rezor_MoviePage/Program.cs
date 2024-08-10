using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Pages;


var builder = WebApplication.CreateBuilder(args);

ConfigurationServices(builder.Services);

var app = builder.Build();
Configure(app, app.Environment);
app.Run();

void ConfigurationServices(IServiceCollection service)
{
    service.AddDbContext<MovieContext>(
        options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("MovieContext")));
    service.AddRazorPages();
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