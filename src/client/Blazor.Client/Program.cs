using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Blazored.Modal;
using Blazored.SessionStorage;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using blazor.Client.Pages.Utils;
using blazor.Client.Services;
using blazor.Client.Services.AccountServices;
using blazor.Client.Services.EntityServices;
// jhipster-needle-add-using-for-services - JHipster will add using services
using blazor.Client.Services.EntityServices.User;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace blazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services
                .AddBlazorise(options =>
                {
                    options.ChangeTextOnKeyPress = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();


            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<ISessionStorageService, SessionStorageService>().AddSingleton<ISyncSessionStorageService, SessionStorageService>();
            builder.Services.AddBlazoredModal();

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            builder.Services.AddSingleton<AuthenticationStateProvider, AuthenticationService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<IRegisterService, RegisterService>();

            // jhipster-needle-add-services-in-di - JHipster will add services in DI

            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            }.EnableIntercept(sp));

            builder.Services.AddAuthorizationCore();

            var host = builder.Build();

            host.Services
                .UseBootstrapProviders()
                .UseFontAwesomeIcons();

            await host.RunAsync();
        }
    }
}
