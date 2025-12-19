using Code.Parts.Api.Extensions;
using Microsoft.AspNetCore.Mvc;
using ExemploDois = Code.Parts.Api.ExemploDois.Interfaces;
using ExemploUm = Code.Parts.Api.ExemploUm.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", (
    ILogger<Program> logger,
    [FromServices] ExemploUm.ICustomerService serviceExemploUm,
    [FromServices] ExemploDois.ICustomerService serviceExemploDois) =>
{
    serviceExemploUm.ObterClientePorCpf("12345678900");
    serviceExemploDois.ObterClientePorCpf("12345678900");

    return "Sucesso";
})
.WithOpenApi();

app.Run();