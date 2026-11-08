# Aula 4 — Validar o nome na criação

## Aula apresentada no chat antes da implementação

Private set controla quem pode atribuir uma propriedade, mas não verifica se o valor recebido é válido. O construtor precisa rejeitar entradas inválidas antes de atribuí-las.

Exemplo independente:

```csharp
public Produto(string nome)
{
    if (string.IsNullOrWhiteSpace(nome))
    {
        throw new ArgumentException("O nome é obrigatório.", nameof(nome));
    }

    Nome = nome;
}
```

IsNullOrWhiteSpace retorna verdadeiro para null, texto vazio ou somente espaços. O if decide executar o bloco; throw lança a exceção e interrompe a execução normal. ArgumentException informa um argumento inválido e nameof(nome) identifica o parâmetro sem escrever seu nome em uma string literal.

## Exercício

Em Usuario, tornar o setter de Nome privado. No início do construtor, rejeitar nome inválido usando IsNullOrWhiteSpace e ArgumentException. Manter geração de Id e atribuições depois da verificação. Compilar com dotnet build. Não alterar Email nesta etapa.

## Perguntas trabalhadas

- Ler usuario.Id e atribuir Guid.Empty a usuario.Id têm a mesma permissão com private set?
- Alterar uma variável Guid que recebeu usuario.Id altera a propriedade original?
- Reatribuir uma variável string que recebeu usuario.Nome altera a propriedade original?
- Por que um setter público permitiria contornar a validação do construtor?
- Se nome contiver somente espaços, a execução chegará à atribuição Nome = nome?

As respostas foram discutidas uma por vez no chat. Guid é tipo por valor; Usuario é classe e suas variáveis guardam referências. String é tipo por referência imutável: reatribuir a variável local não altera a propriedade de onde foi lida.
