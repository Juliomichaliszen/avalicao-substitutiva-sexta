using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
    var app = builder.Build();

    //Usuario 

app.MapGet("/Usuario", () => "Obter usuario");

    app.MapPost("/Usuario", (Usuario usuario) => {
        return "Usuario inserido com sucesso!";
    });
        app.MapPut("/Usuario/{id}", (int id, Usuario usuario) => {
            return "Usuario atualizado com sucesso!";
        });
            app.MapDelete("/Usuario/{id}", (int id) => {
                return "Usuario deletado com sucesso!";
            });

// Medidas de peso

app.MapGet("/Peso/{id}", (int id) => {
    return "Medidas de peso do usuario";
});
    app.MapPost("/MedidasDePeso/{peso}", (double peso, MedidasDePeso) => {
        return "Medidas de peso inseridas com sucesso!";
    });
        app.MapPut("/Peso/{id}/{data}", (int id, string data, MedidasDePeso medidasDePeso) => {
            return "Medidas de peso atualizadas com sucesso!";
        });
            app.MapDelete("/Peso/{id}/{data}", (int id, string data) => {
                return "Medidas de peso deletadas com sucesso!";
            });

// Medidas de altura

app.MapGet("/Altura/{id}", (int id) => {
    return "Medidas de altura do usuario";
});
    app.MapPost("/Altura/{id}", (int id, MedidasDeAltura medidasDeAltura) => {
        return "Medidas de altura inseridas com sucesso!";
    });
        app.MapPut("/Altura/{id}/{data}", (int id, string data, MedidasDeAltura medidasDeAltura) => {
            return "Medidas de altura atualizadas com sucesso!";
        });
            app.MapDelete("/Altura/{id}/{data}", (int id, string data) => {
                return "Medidas de altura deletadas com sucesso!";
            });

// cadastras imc

app.MapGet("/IMC/{id}", (int id) => {
    return "Calculo do IMC do usuario";
});
    app.MapPost("/IMC/{id}", (int id, CadastroImc cadastroImc) => {
        return "Cadastro do IMC inserido com sucesso!";
    });



app.Run();

