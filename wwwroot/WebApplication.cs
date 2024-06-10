#region Assembly Microsoft.AspNetCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60
// /usr/local/share/dotnet/packs/Microsoft.AspNetCore.App.Ref/8.0.5/ref/net8.0/Microsoft.AspNetCore.dll
#endregion

#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Builder
{
    //
    // Summary:
    //     The web application used to configure the HTTP pipeline, and routes.
    [DebuggerDisplay("{DebuggerToString(),nq}")]
    [DebuggerTypeProxy(typeof(WebApplicationDebugView))]
    public sealed class WebApplication : IHost, IDisposable, IApplicationBuilder, IEndpointRouteBuilder, IAsyncDisposable
    {
        //
        // Summary:
        //     The list of URLs that the HTTP server is bound to.
        public ICollection<string> Urls { get; }
        //
        // Summary:
        //     Allows consumers to be notified of application lifetime events.
        public IHostApplicationLifetime Lifetime { get; }
        //
        // Summary:
        //     The application's configured Microsoft.AspNetCore.Hosting.IWebHostEnvironment.
        public IWebHostEnvironment Environment { get; }
        //
        // Summary:
        //     The application's configured Microsoft.Extensions.Configuration.IConfiguration.
        public IConfiguration Configuration { get; }
        //
        // Summary:
        //     The application's configured services.
        public IServiceProvider Services { get; }
        //
        // Summary:
        //     The default logger for the application.
        public ILogger Logger { get; }

        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplication
        //     class with preconfigured defaults.
        //
        // Parameters:
        //   args:
        //     The command line arguments.
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplication.
        public static WebApplication Create(string[]? args = null);
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with preconfigured defaults.
        //
        // Parameters:
        //   options:
        //     The Microsoft.AspNetCore.Builder.WebApplicationOptions to configure the Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        //
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateBuilder(WebApplicationOptions options);
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with preconfigured defaults.
        //
        // Parameters:
        //   args:
        //     The command line arguments.
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateBuilder(string[] args);
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with preconfigured defaults.
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateBuilder();
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with no defaults.
        //
        // Parameters:
        //   options:
        //     The Microsoft.AspNetCore.Builder.WebApplicationOptions to configure the Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        //
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateEmptyBuilder(WebApplicationOptions options);
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with minimal defaults.
        //
        // Parameters:
        //   args:
        //     The command line arguments.
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateSlimBuilder(string[] args);
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with minimal defaults.
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateSlimBuilder();
        //
        // Summary:
        //     Initializes a new instance of the Microsoft.AspNetCore.Builder.WebApplicationBuilder
        //     class with minimal defaults.
        //
        // Parameters:
        //   options:
        //     The Microsoft.AspNetCore.Builder.WebApplicationOptions to configure the Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        //
        //
        // Returns:
        //     The Microsoft.AspNetCore.Builder.WebApplicationBuilder.
        public static WebApplicationBuilder CreateSlimBuilder(WebApplicationOptions options);
        //
        // Summary:
        //     Disposes the application.
        public ValueTask DisposeAsync();
        //
        // Summary:
        //     Runs an application and block the calling thread until host shutdown.
        //
        // Parameters:
        //   url:
        //     The URL to listen to if the server hasn't been configured directly.
        public void Run([StringSyntax("Uri")] string? url = null);
        //
        // Summary:
        //     Runs an application and returns a Task that only completes when the token is
        //     triggered or shutdown is triggered.
        //
        // Parameters:
        //   url:
        //     The URL to listen to if the server hasn't been configured directly.
        //
        // Returns:
        //     A System.Threading.Tasks.Task that represents the entire runtime of the Microsoft.AspNetCore.Builder.WebApplication
        //     from startup to shutdown.
        public Task RunAsync([StringSyntax("Uri")] string? url = null);
        //
        // Summary:
        //     Start the application.
        //
        // Parameters:
        //   cancellationToken:
        //
        // Returns:
        //     A System.Threading.Tasks.Task that represents the startup of the Microsoft.AspNetCore.Builder.WebApplication.
        //     Successful completion indicates the HTTP server is ready to accept new requests.
        public Task StartAsync(CancellationToken cancellationToken = default);
        //
        // Summary:
        //     Shuts down the application.
        //
        // Parameters:
        //   cancellationToken:
        //
        // Returns:
        //     A System.Threading.Tasks.Task that represents the shutdown of the Microsoft.AspNetCore.Builder.WebApplication.
        //     Successful completion indicates that all the HTTP server has stopped.
        public Task StopAsync(CancellationToken cancellationToken = default);
        //
        // Summary:
        //     Adds the middleware to the application request pipeline.
        //
        // Parameters:
        //   middleware:
        //     The middleware.
        //
        // Returns:
        //     An instance of Microsoft.AspNetCore.Builder.IApplicationBuilder after the operation
        //     has completed.
        public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    }
}