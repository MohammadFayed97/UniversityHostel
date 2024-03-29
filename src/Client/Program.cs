using Blazored.Toast;
using UniversityHostel.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SmartUI.Grid.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#page-top");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.ConfigureFluentValidationServices();
builder.Services.ConfigureAuthentication(builder.HostEnvironment);
builder.Services.ConfigureHttpServices();
builder.Services.AddBlazoredToast();
builder.Services.AddSmartGrid();

await builder.Build().RunAsync();
