using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyPatrolLogbook;
using MyPatrolLogbook.Models;
using MyPatrolLogbook.Services;
using System;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration.GetSection("AuthMessageSenderOptions"));

// Configure Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(config =>
{
    // config.SignIn.RequireConfirmedEmail = false;
    config.Tokens.ProviderMap.Add("CustomEmailConfirmation",
        new TokenProviderDescriptor(
            typeof(CustomEmailConfirmationTokenProvider<ApplicationUser>)));
    config.Tokens.EmailConfirmationTokenProvider = "CustomEmailConfirmation";
}).AddEntityFrameworkStores<AppDBContext>().AddDefaultTokenProviders();

// Add EmailSender
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddTransient<CustomEmailConfirmationTokenProvider<ApplicationUser>>();

builder.Services.Configure<DataProtectionTokenProviderOptions>(o =>
       o.TokenLifespan = TimeSpan.FromHours(3));

// Added
builder.Services.AddSession();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<ITroopRepository, TroopRepository>();
builder.Services.AddScoped<IPatrolRepository, PatrolRepository>();
builder.Services.AddScoped<ICampRepository, CampRepository>();
builder.Services.AddScoped<IHikeRepository, HikeRepository>();
builder.Services.AddScoped<ICommunityServiceRepository, CommunityServiceRepository>();
builder.Services.AddScoped<IPatrolActivityRepository, PatrolActivityRepository>();
builder.Services.AddScoped<IRegisterRepository, RegisterRepository>();
builder.Services.AddScoped<IPatrolInCouncilRepository, PatrolInCouncilRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
