# Aula 1 — Classes e propriedades

## Objetivo

Criar sua primeira entidade, revisando tipos e conhecendo classes. Nesta etapa não há banco, Controller nem validação de cadastro.

Uma variável guarda um valor. Uma classe define um tipo que agrupa dados e, futuramente, comportamentos. Um objeto é uma instância desse tipo.

Exemplo de outro contexto:

```csharp
namespace Catalogo.Domain.Entities;

public class Livro
{
    public Guid Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
}
```

- `namespace`: organiza nomes; o ponto separa partes do nome e não executa nada. O ponto e vírgula encerra essa declaração.
- `public class Livro`: declara um tipo público chamado Livro; as chaves delimitam seu corpo.
- `Guid`: identificador de 128 bits. A propriedade não gera um identificador sozinha; sem atribuição, vale Guid.Empty. Geração será estudada com construtores.
- `string`: texto. `string.Empty` é uma string vazia e evita deixar a propriedade sem inicialização com nullable habilitado. Não garante que o texto seja válido.
- `{ get; set; }`: propriedade automática; get permite ler e set permite atribuir. Começaremos assim para entender a sintaxe; depois restringiremos alterações com encapsulamento.
- Classes e propriedades usam PascalCase. Variáveis locais normalmente usam camelCase.

Exemplo de criação de objeto, apenas para leitura nesta aula:

```csharp
Livro livro = new Livro();
livro.Titulo = "Introdução à programação";
```

`new` cria uma instância. `livro.Titulo` acessa a propriedade do objeto. Este exemplo não deve ser colado fora de uma classe no projeto Domain: esse projeto é uma biblioteca, não um programa de console.

## Sua tarefa no VS Code

1. Abra a pasta raiz do projeto.
2. Em backend/SistemaBancario.Domain/Entities, crie Usuario.cs.
3. Use o namespace SistemaBancario.Domain.Entities.
4. Declare uma classe pública Usuario.
5. Crie propriedades públicas Id (Guid), Nome (string) e Email (string), com leitura e escrita.
6. Inicialize os textos com string.Empty.
7. Salve e execute no terminal da raiz: `dotnet build`.

Não acrescente senha nem regras nesta etapa. Seu objetivo é entender e escrever a declaração da classe.

## O que será revisado

Nome do arquivo, namespace, visibilidade, tipos, PascalCase, inicialização de strings e resultado da compilação. Explique com suas palavras: qual é a diferença entre uma classe e um objeto? Um build bem-sucedido verifica compilação, não todas as regras de negócio.

Ao terminar, diga “terminei a etapa 1”. Se o build falhar, pode deixar o código como está e pedir ajuda: vamos interpretar o erro juntos.
