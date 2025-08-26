var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (minimalApi.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@test.com" && loginDTO.Senha == "12345")
    {
        return Results.Ok("Login bem sucedido!");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.Run();
