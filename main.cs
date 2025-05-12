using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); // Enables serving wwwroot/*

app.MapGet("/", async context =>
{
    context.Response.Redirect("/index.html");
});

app.Run("http://0.0.0.0:8080");