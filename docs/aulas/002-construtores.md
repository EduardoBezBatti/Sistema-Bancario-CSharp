# Aula 2 — Construtores e parâmetros

## Conceito

Um construtor é executado ao criar um objeto com new. Seu nome é igual ao da classe e ele não declara tipo de retorno, nem void. Parâmetros recebem os valores enviados por quem cria o objeto.

Exemplo em outro contexto:

```csharp
public class Livro
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;

    public Livro(string titulo)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
    }
}
```

Em `Livro livro = new Livro("Aprendendo C#");`, o texto é o argumento passado ao parâmetro titulo. No construtor, Titulo é a propriedade do objeto e titulo é o parâmetro recebido; C# diferencia maiúsculas e minúsculas. O sinal = atribui o valor da direita ao destino à esquerda.

Guid.NewGuid() chama um método que gera um identificador. Guid.Empty representa o identificador com todos os valores zerados; não é a mesma coisa que gerar um novo.

Quando nenhum construtor é declarado nessa classe, C# fornece um construtor público sem parâmetros. Ao declarar apenas um construtor com parâmetros, `new Livro()` deixa de ser válido: é preciso fornecer o título. Não adicione outro construtor apenas para contornar essa exigência.

## Sua tarefa

1. No arquivo Usuario.cs, mantenha as propriedades existentes.
2. Adicione um construtor público com dois parâmetros string: nome e email.
3. Dentro dele, gere Id usando Guid.NewGuid().
4. Atribua nome à propriedade Nome e email à propriedade Email.
5. Execute `dotnet build` na raiz.

Não acrescente validações nem altere os setters neste exercício. O construtor por enquanto organiza a inicialização; ele ainda não impede dados inválidos ou alterações posteriores.

Não cole comandos de criação de objetos diretamente no arquivo da biblioteca. Usaremos instâncias em exercícios posteriores.

Ao terminar, diga “terminei a etapa 2” e explique: em `Nome = nome;`, qual é a propriedade e qual é o parâmetro?
