using Autofac;
using Autofac.Extensions.DependencyInjection;
using BlogProject.Core.Repositories;
using BlogProject.Core.Services;
using BlogProject.Core.UnitOfWorks;
using BlogProject.Repository;
using BlogProject.Repository.Repositories;
using BlogProject.Repository.UnitOfWorks;
using BlogProject.Service.Mapping;
using BlogProject.Service.Services;
using Microsoft.EntityFrameworkCore;
using BlogProject.Web.Modules;
using System.Reflection;
using FluentValidation.AspNetCore;
using BlogProject.Service.Validations;
using BlogProject.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<PostViewModelValidator>());
;

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>),typeof(Service<>));

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});

builder.Services.AddScoped(typeof(NotFoundFilter<>));

builder.Host.UseServiceProviderFactory
    (new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

var app = builder.Build();

app.UseExceptionHandler("/Home/Error");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
   
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




