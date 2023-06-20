using GoFast.UI.Client;
using GoFast.UI.Shared.Services.Interfaces;
using GoFast.UI.Shared.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("GoFast.UI.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("GoFast.UI.ServerAPI"));

builder.Services.AddApiAuthorization();

builder.Services.AddHttpClient<IMotoristaService, MotoristaService>();
builder.Services.AddHttpClient<IBlobService, BlobService>();
builder.Services.AddScoped<IFileConverter, FileConverter>();

await builder.Build().RunAsync();
