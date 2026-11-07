# Etapa 0 — Preparação

Data: 07/11/2026. Responsável pelas alterações: tutor. Nenhuma funcionalidade bancária foi implementada pelo aluno nesta etapa.

## Perfil e acordo

O aluno conhece variáveis, condições, laços e operadores em C#, utiliza consultas SQL no trabalho e está começando Angular. Revisaremos os fundamentos em exercícios curtos. O aluno implementará o código e o tutor fará revisão após sua sinalização de conclusão. Login será posterior.

## Ambiente encontrado

Pasta inicialmente vazia: F:\Projetos\Sistema.Bancario.C#.
.NET SDK 10.0.402, runtime 10.0.13, Node.js 24.15.0, npm 11.12.1. Git, GitHub CLI e VS Code disponíveis. PostgreSQL 18 instalado e serviço postgresql-x64-18 em execução. Isso não comprova autenticação ou conexão SQL: elas serão verificadas na etapa do banco, sem solicitar senhas pelo chat.

## Preparação executada

Solução .NET com Api, Domain, Application e Infrastructure e referências entre camadas. SDK fixado em global.json, permitindo patches. Remoção de arquivos de exemplo dos templates. Pastas para entidades, interfaces, Commands, CommandHandlers, ViewModels, Controllers, persistência e Repositories. Arquivos .gitkeep mantêm pastas vazias no Git.

Swagger configurado apenas em Development e endpoint técnico GET /api/status para verificar o funcionamento. Não há endpoint bancário. Angular gerado pelo CLI 22.2.6 com routing e SCSS, sem SSR. O template Angular permanece como ponto de partida para aulas futuras.

Gitignore exclui bin, obj, node_modules, dist, cache Angular e configurações locais com segredos. AGENTS.md registra o acordo de ensino para futuras revisões. Plano e primeira aula salvos em docs.

## Limites e próximos passos

Não foram criados banco, tabelas, usuário de aplicação, connection string, modelos bancários, handlers ou repositories concretos. Integração PostgreSQL e integração Angular/API ainda não existem. Não há autenticação. Nenhum exercício do aluno deve ser marcado como concluído antecipadamente.

O próximo exercício é Usuario.cs, conforme docs/aulas/001-classes-e-propriedades.md. Após a tentativa do aluno, registrar código revisado, pontos acertados, correções justificadas, verificações e pendências no relatório 001.

## Fontes técnicas consultadas

## Validação e versionamento

- `dotnet build`: aprovado, zero erros e zero avisos nos quatro projetos.
- `npm.cmd run build` na pasta frontend: aprovado.
- API executada em Development na porta 5080: GET /api/status retornou HTTP 200 com mensagem JSON.
- GET /swagger/index.html retornou HTTP 200; /swagger/v1/swagger.json retornou OpenAPI 3.0.4 contendo /api/status.
- PostgreSQL: verificação limitada à instalação e ao serviço ativo; não houve conexão SQL.
- Repositório privado criado: https://github.com/EduardoBezBatti/Sistema-Bancario-CSharp.
- Commit da preparação: `chore: prepara estrutura inicial e plano de aprendizado`. O hash pode ser consultado no histórico Git; não é incluído no próprio commit para evitar referência circular.

## Referências

- https://angular.dev/reference/versions — compatibilidade de Node e Angular.
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-10.0 — API baseada em Controllers.
- https://www.nuget.org/packages/Swashbuckle.AspNetCore/ — pacote Swagger restaurado pelo NuGet.
