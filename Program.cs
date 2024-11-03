

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", static () => "Fala Brother!!!");

//para fazer validação de login e senha
app.MapPost("/login" , static (minimal_api.Domain.DTOs.LoginDTO loginDTO) => {
    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();




