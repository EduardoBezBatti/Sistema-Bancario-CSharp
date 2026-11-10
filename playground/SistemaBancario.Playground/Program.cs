using SistemaBancario.Domain.Entities;

try
{
    Usuario usuario = new Usuario("Eduardo", "eduardobezbatti2015@gmail.com");
    Console.WriteLine("Usuario criado!");
}
catch(ArgumentException erro)
{
    Console.WriteLine(erro.Message);
}
Console.WriteLine("Tentativa Concluida");