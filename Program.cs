using DatingApp;
using DatingApp.Data;
using DatingApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the DbContext with a check for the connection string
builder.Services.AddDbContext<DatingContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DatingConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Connection string 'DatingConnection' not found.");
    }
    options.UseSqlServer(connectionString);
});

builder.Services.AddQuickGridEntityFrameworkAdapter();

// Register UserService as a singleton or scoped, depending on your requirements.
//builder.Services.AddScoped<UserService>(); // Uncomment if you prefer scoped.
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

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
