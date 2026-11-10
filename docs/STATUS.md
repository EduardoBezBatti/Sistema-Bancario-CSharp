# Status e ponto de retomada

Atualizado em 09/11/2026. Aprendizado retomado; etapas 0 a 9 aprovadas.

## Implementado

Estrutura .NET com Api, Domain, Application e Infrastructure; Swagger e endpoint técnico /api/status; estrutura Angular sem telas bancárias. Usuario tem setters privados, Guid gerado no construtor, validação de nome/email obrigatórios e Trim nas atribuições. Playground console referencia Domain e pratica try/catch. Aulas e relatórios em docs; relatório 007 registra a pausa e 008 a conclusão da etapa 7.

## Pendente

Conta básica agora implementada: Id e UsuarioId Guid, Saldo decimal, setters privados e construtor que recebe somente usuarioId, gera Id e inicia saldo zero. Ainda não possui validações ou operações. Detalhes na aula 009 e relatório 010.

Operações de saldo, transferências, conexão PostgreSQL, DbContext, migrations, Repositories concretos, Commands/CommandHandlers, Controllers bancários, ViewModels e integração Angular/API. Pastas preparadas. Formato e unicidade de email não validados. Login posterior. PostgreSQL 18 foi encontrado instalado e ativo na preparação; conexão SQL ainda não validada.

## Aprendizado e próxima interação

Praticados objetos, referências, Guid por valor, string imutável, construtores, propriedades, private set, validações, Trim, throw e try/catch. O aluno explicou corretamente o fluxo de email inválido e o tratamento pelo chamador.

O aluno identificou corretamente que o construtor remove espaços com Trim. Implementou a classe Conta após orientações sobre nome do construtor e parâmetros necessários. Próxima pergunta: qual propriedade de um Usuario existente passar ao construtor da Conta? Aguardar resposta antes de propor novo exercício. Manter perguntas curtas, exemplos independentes e não acessar Longo Percurso.

## Última verificação

Última entrega, etapa 9: dotnet build da solução com cinco projetos, zero erros e zero avisos. Conta ainda não foi executada no Playground. Os resultados abaixo pertencem às etapas anteriores.

Último run do Playground compilou e executou a etapa 8, código 0: Nome: [Eduardo], seguido de Tentativa Concluida. A etapa 7 verificou o erro de email obrigatório; o cenário atual é válido. Revisão anterior da solução com dotnet build: zero erros e zero avisos. Nome inválido e dados válidos também foram executados durante as revisões.

Detalhes de estilo pendentes: espaço após catch e if do nome e acentuação de mensagens. Tutor não modificou o código do aluno.

Branch main. Repositório: https://github.com/EduardoBezBatti/Sistema-Bancario-CSharp.
