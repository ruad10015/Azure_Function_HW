using Azure_Function_HW.Services.Abstract;
using Azure_Function_HW.Services.Concrete;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddSingleton<IEmailService>(es => 
    new EmailService(
        smtpHost: "smtp.gmail.com",
        smtpPort: 587,
        smtpUser: "seid13463@gmail.com", 
        smtpPass: "uxwunvyysqjhjgvn"
    ));

// Application Insights isn't enabled by default. See https://aka.ms/AAt8mw4.
// builder.Services
//     .AddApplicationInsightsTelemetryWorkerService()
//     .ConfigureFunctionsApplicationInsights();

builder.Build().Run();
