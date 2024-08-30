
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Core;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.Services;
using Rezor_MoviePage.Services.Interfaces;


var builder = WebApplication.CreateBuilder(args);

ConfigurationServices(builder.Services);

var app = builder.Build();

await Seed.SeedUsersAndRolesAsync(app);

Configure(app, app.Environment);
app.Run();

void ConfigurationServices(IServiceCollection services)
{
    //services.AddSingleton<Order>();
    //services.AddSingleton<Ticket>();
    //services.AddSingleton<FormatedShedule>();

    services.AddSingleton<IPhotoService,PhotoService>();

    services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

    services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<MovieContext>();
    services.AddMemoryCache();
    services.AddSession();
    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie();

    services.AddDbContext<MovieContext>(options => 
        options.UseSqlServer(builder.Configuration.GetConnectionString("MovieContext") ??
        throw new InvalidOperationException("Connection string 'MovieContext' not found.")));
    
    services.AddServerSideBlazor();
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
        x.MapBlazorHub();
        x.MapRazorPages();
    });
}