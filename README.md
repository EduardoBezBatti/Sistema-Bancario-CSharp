# Sistema Bancário — aprendizado prático

Projeto educacional com C#, ASP.NET Core 10, Angular e PostgreSQL. Começa com usuários, contas, saldo e transferências fictícias; login será acrescentado depois.

Leia [o plano](docs/PLANO.md), [o relatório de preparação](docs/relatorios/000-preparacao.md) e [a primeira aula](docs/aulas/001-classes-e-propriedades.md).

## Backend

No terminal da pasta raiz:

```powershell
dotnet build
dotnet run --project backend/SistemaBancario.Api --no-launch-profile -- --urls http://localhost:5080 --environment Development
```

Swagger: http://localhost:5080/swagger
Verificação: http://localhost:5080/api/status
Use Ctrl+C para parar. HTTPS e autenticação serão estudados posteriormente.

## Frontend

Em outro terminal, na pasta frontend:

```powershell
npm.cmd ci
npm.cmd start
```

Abra http://localhost:4200. Para validar a compilação: `npm.cmd run build`.
O uso de npm.cmd evita depender da política de execução de scripts PowerShell. O frontend ainda não consome a API.

## PostgreSQL

PostgreSQL 18 foi encontrado instalado com o serviço em execução. Banco e conexão da aplicação serão configurados durante as aulas. Não salve senhas no repositório.

## Fluxo de aprendizado

Leia a aula, implemente o exercício e diga “terminei a etapa 1”. Após revisão e aprovação, atualizamos o relatório e fazemos commit e push. A preparação é a etapa 0; a etapa 1 permanece pendente.
