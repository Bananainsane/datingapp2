using DatingApp.Components;
using DatingApp.Data;
using DatingApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddDbContext<DatingContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection") ?? throw new InvalidOperationException("Connection string 'DatingConnection' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

//builder.Services.AddScoped<UserService>();
builder.Services.AddSingleton<UserService>();

builder.Services.AddBlazorBootstrap();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();
app.MapBlazorHub();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
