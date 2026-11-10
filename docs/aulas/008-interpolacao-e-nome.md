# Aula 8 — Exibir o nome normalizado

Explicação apresentada no chat antes da implementação: depois de criar o usuário com sucesso, ler sua propriedade dentro do try. O catch serve para a falha compatível, não para o caminho de sucesso.

Interpolação insere valores no texto usando o prefixo $ e expressões entre chaves. Exemplo independente:

```csharp
Console.WriteLine($"Descrição: [{produto.Descricao}]");
```

Os colchetes são caracteres literais que ajudam a visualizar espaços nas extremidades.

Exercício: criar Usuario com nome Eduardo cercado de espaços e email preenchido. Após a criação, dentro do try, imprimir Nome com interpolação e colchetes. Manter catch e encerramento fora do bloco. Executar o Playground.

Pergunta anterior à execução: qual será o texto exato exibido? Pergunta de revisão: se os espaços não aparecem, em que parte do código eles foram removidos?
