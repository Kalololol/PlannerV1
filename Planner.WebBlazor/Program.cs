using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Planner.Data;
using Planner.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Planner.Application.Mediator;
using System.Reflection;
using Planner.Infrastructure.ContainerConfigurations.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<ApplicationDbContext>(
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("PlanowaniePracyConnectionStrings"))
    );


//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(typeof(MediatorConfiguration).Assembly);

builder.Services.AddSingleton(AutoMapperConfig.Initialize());
builder.Services.AddSingleton(Planner.WebBlazor.AutoMapperConfig.Initialize());
//builder.Services.AddAutoMapper(AutoMapperConfig.Initialize());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
