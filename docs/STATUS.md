# Status e ponto de retomada

Atualizado em 08/11/2026 (America/Sao_Paulo). Pausa solicitada pelo aluno; retomar somente quando ele enviar nova mensagem. Não há lembrete agendado.

## Implementado

- Estrutura ASP.NET Core 10: Api, Domain, Application e Infrastructure com referências entre projetos.
- Swagger em Development e endpoint técnico /api/status.
- Estrutura Angular gerada; ainda sem telas bancárias ou consumo da API.
- Entidade Usuario com Id, Nome e Email, todos com setters privados.
- Construtor gera Guid, rejeita nome e email null/vazios/somente espaços e aplica Trim antes de armazenar os textos.
- Etapas 0 a 6 revisadas e aprovadas; aulas e relatórios em docs.

## Ainda não implementado

Conta, saldo, transações, persistência PostgreSQL, DbContext, migrations, Repositories concretos, Commands/CommandHandlers, Controllers bancários e ViewModels. As pastas dessas responsabilidades estão preparadas. Formato e unicidade de email não são validados. Login será posterior.

PostgreSQL 18 está instalado e seu serviço foi encontrado ativo na preparação; a aplicação ainda não tem conexão configurada e nenhuma conexão SQL foi validada.

## Aprendizado atual

Foram praticados classes, objetos, variáveis, referências compartilhadas, Guid por valor, strings imutáveis, construtores, parâmetros, propriedades, private set, IsNullOrWhiteSpace, Trim, if, throw e ArgumentException.

A etapa 7, sobre try/catch, foi apenas iniciada conceitualmente no chat. Nenhum exercício de código de tratamento de exceções foi solicitado ou entregue. O aluno entendeu o lançamento no construtor e a ordem das validações. Ainda precisa consolidar a continuação depois do catch e a compatibilidade entre o tipo lançado e o tipo capturado.

## Retomar exatamente aqui

Revisar brevemente que o construtor lança a exceção e o catch apenas trata tipos compatíveis; trocar o tipo do catch não impede o lançamento nem faz um objeto inválido ser criado.

Pergunta pendente, ainda sem resposta do aluno:

```csharp
try
{
    throw new ArgumentException("Nome inválido.");
}
catch (ArgumentException erro)
{
    Console.WriteLine("Erro tratado.");
}
```

A mensagem "Erro tratado." será exibida?

Aguardar a resposta, explicar e usar mais uma pergunta curta antes de propor implementação. Manter exemplos independentes; não acessar o projeto Longo Percurso.

## Última verificação

dotnet build em 08/11/2026: quatro projetos compilados, zero erros e zero avisos. Nenhum teste automatizado ou nova compilação Angular foi necessário nesta pausa: as últimas alterações de código são somente pontuação nas mensagens e espaço após vírgula.

Branch de trabalho: main. Repositório: https://github.com/EduardoBezBatti/Sistema-Bancario-CSharp.
