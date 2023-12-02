using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PokeCake.Web;
using PokeCake.Web.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseUrl = "https://localhost:7192";

builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient {
    BaseAddress = new Uri(baseUrl) 
});

builder.Services.AddScoped<IProdutoService, ProdutoService>();

await builder.Build().RunAsync();
