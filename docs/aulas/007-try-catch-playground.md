# Aula 7 — Try/catch no Playground

Aula apresentada no chat antes do exercício. O try delimita a tentativa; throw lança a exceção e interrompe o fluxo normal; catch trata um tipo compatível. A mensagem não é impressa automaticamente: Console.WriteLine(erro.Message) a exibe. Após um catch que termina normalmente, a execução continua fora do bloco.

Exemplo independente:

```csharp
try
{
    throw new ArgumentException("Descrição inválida.");
}
catch (ArgumentException erro)
{
    Console.WriteLine(erro.Message);
}
Console.WriteLine("Fim da tentativa.");
```

Catch de InvalidOperationException não captura ArgumentException. Mudar o catch não muda o lançamento. Usuario protege suas regras e o chamador trata a falha.

## Exercício proposto

Criar SistemaBancario.Playground com dotnet new console, adicioná-lo à solução com dotnet sln add e referenciar Domain com dotnet add reference. Editar Program.cs do Playground, não o da API. Importar o namespace de Usuario. No try, criar usuário com nome válido e email somente com espaços, seguido de mensagem de sucesso. Capturar ArgumentException, imprimir erro.Message e escrever mensagem de encerramento fora do bloco.

Executar: dotnet run --project playground/SistemaBancario.Playground.

## Perguntas trabalhadas

Prever quais mensagens aparecem e sua ordem, distinguir mensagem armazenada e impressão, identificar tipo compatível no catch e explicar onde tratar a falha. As perguntas foram feitas uma por vez no chat.
