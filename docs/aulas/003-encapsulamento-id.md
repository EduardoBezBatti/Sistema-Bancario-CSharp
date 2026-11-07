# Aula 3 — Controlar a alteração do identificador

## Conceito apresentado antes do exercício

Encapsulamento controla como os dados de uma classe podem ser acessados e alterados. Um setter público permite atribuições a partir de outras classes; private set restringe essa atribuição ao código da própria classe.

Exemplo didático:

```csharp
public class Produto
{
    public Guid Id { get; private set; }

    public Produto()
    {
        Id = Guid.NewGuid();
    }
}
```

O get público permite ler o identificador externamente. O private set permite atribuí-lo no construtor e nos métodos da própria classe. O controle de acesso é definido pela classe, não pela identidade de uma instância. Private set não torna a propriedade imutável: a própria classe ainda pode alterá-la.

## Exercício proposto e entregue

Alterar somente Id em Usuario para usar private set, manter sua geração no construtor e executar dotnet build. Nome e Email permanecem com setters públicos neste exercício.

## Pergunta feita antes da implementação

Por que Id = Guid.NewGuid() continua funcionando dentro do construtor, mesmo com o setter privado?

O aluno associou a permissão ao acesso interno ao objeto. O tutor precisou a terminologia: a atribuição é permitida no código da própria classe Usuario, incluindo construtor e métodos.

## Pergunta de revisão

Em outra classe, qual destas linhas compila após criar um Usuario: Console.WriteLine(usuario.Id) ou usuario.Id = Guid.Empty? Explique considerando os acessos get e set.
