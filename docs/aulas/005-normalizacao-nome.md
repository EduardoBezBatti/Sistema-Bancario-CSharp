# Aula 5 — Remover espaços das extremidades

## Conceito apresentado antes da implementação

IsNullOrWhiteSpace verifica o texto, sem modificá-lo. Trim retorna uma string sem espaços em branco no início e no fim, preservando espaços entre palavras. Strings são imutáveis: chamar Trim não altera a string original, e é necessário usar seu retorno.

```csharp
string texto = "  Teclado sem fio  ";
string resultado = texto.Trim();
```

Resultado contém "Teclado sem fio". Texto continua com os espaços originais.

## Exercício

No construtor de Usuario, atribuir o retorno de nome.Trim() à propriedade Nome. Manter a validação de obrigatoriedade antes dessa chamada e executar dotnet build.

Se nome for null, chamar nome.Trim() lança NullReferenceException. A validação anterior com IsNullOrWhiteSpace permite rejeitar esse argumento com a ArgumentException definida pelo domínio. Para somente espaços, a validação também lança ArgumentException antes da normalização.

## Pergunta de revisão

Ao criar um usuário com o nome "  Ana   Maria  ", qual texto exato fica em Nome? Os espaços entre Ana e Maria permanecem?
