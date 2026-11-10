# Status e ponto de retomada

Atualizado em 09/11/2026. Aprendizado retomado; etapas 0 a 8 aprovadas.

## Implementado

Estrutura .NET com Api, Domain, Application e Infrastructure; Swagger e endpoint técnico /api/status; estrutura Angular sem telas bancárias. Usuario tem setters privados, Guid gerado no construtor, validação de nome/email obrigatórios e Trim nas atribuições. Playground console referencia Domain e pratica try/catch. Aulas e relatórios em docs; relatório 007 registra a pausa e 008 a conclusão da etapa 7.

## Pendente

Conta, saldo, transferências, conexão PostgreSQL, DbContext, migrations, Repositories concretos, Commands/CommandHandlers, Controllers bancários, ViewModels e integração Angular/API. Pastas preparadas. Formato e unicidade de email não validados. Login posterior. PostgreSQL 18 foi encontrado instalado e ativo na preparação; conexão SQL ainda não validada.

## Aprendizado e próxima interação

Praticados objetos, referências, Guid por valor, string imutável, construtores, propriedades, private set, validações, Trim, throw e try/catch. O aluno explicou corretamente o fluxo de email inválido e o tratamento pelo chamador.

O aluno identificou corretamente a leitura de Nome dentro do try após a criação. Implementou a interpolação com colchetes e nome cercado de espaços. Próxima pergunta: quem removeu os espaços, o Console.WriteLine ou o construtor de Usuario? Aguardar resposta antes de propor novo exercício. Manter perguntas curtas, exemplos independentes e não acessar Longo Percurso.

## Última verificação

Último run do Playground compilou e executou a etapa 8, código 0: Nome: [Eduardo], seguido de Tentativa Concluida. A etapa 7 verificou o erro de email obrigatório; o cenário atual é válido. Revisão anterior da solução com dotnet build: zero erros e zero avisos. Nome inválido e dados válidos também foram executados durante as revisões.

Detalhes de estilo pendentes: espaço após catch e if do nome e acentuação de mensagens. Tutor não modificou o código do aluno.

Branch main. Repositório: https://github.com/EduardoBezBatti/Sistema-Bancario-CSharp.
