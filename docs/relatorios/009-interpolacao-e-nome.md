# Etapa 8 — Leitura de propriedade e interpolação

O aluno explicou corretamente que a leitura do nome de uma criação válida deve ficar no try após o construtor. O tutor refinou a explicação: catch captura tipos compatíveis lançados dentro do try; erro recebe a exceção.

O aluno alterou o Playground para criar Usuario com o nome " Eduardo " e email preenchido e imprimir Console.WriteLine($"Nome: [{usuario.Nome}]"). Embora o exemplo proposto tivesse dois espaços em cada extremidade, usar um também atende ao objetivo. Manteve catch e encerramento. O tutor não alterou a implementação.

Etapa aprovada. dotnet run --project playground/SistemaBancario.Playground compilou e executou com código 0. Saída observada:

```text
Nome: [Eduardo]
Tentativa Concluida
```

A leitura está após a criação e no caminho de sucesso. O nome foi normalizado pelo construtor, não pela impressão. Interpolação e colchetes permitem observar o resultado. Não foram adicionados testes automatizados para este experimento simples.

A previsão do texto antes de executar não foi respondida. A próxima pergunta verifica onde ocorre a remoção dos espaços. O detalhe de estilo catch( continua pendente.

Commit: feat: exibe nome normalizado no Playground.
