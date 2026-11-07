# Plano de aprendizado

## Como vamos trabalhar

Uma aula curta, um exercício, implementação no VS Code pelo aluno, revisão do código e validação. Quando aprovado, atualizar o relatório, fazer commit e enviar ao GitHub. Se houver ajustes, explicá-los e permitir nova tentativa. Dúvidas fazem parte da etapa.

## Etapas previstas

0. Preparação: solução, projetos, Swagger, Angular e documentação.
1. Classes, namespaces, propriedades e tipos: primeira entidade Usuario.
2. Construtores, encapsulamento e validações: proteger os dados do usuário.
3. Conta: decimal, saldo, condições e métodos de depósito/saque fictícios.
4. Interfaces, injeção de dependência, Commands e CommandHandlers.
5. HTTP, Controllers, ViewModels, códigos de resposta e Swagger.
6. PostgreSQL: banco, usuário da aplicação, tabelas, chaves, constraints e numeric.
7. Entity Framework Core com Npgsql, DbContext, mapeamentos, migrations e Repository.
8. Cadastro, criação de conta e consulta de saldo persistidos.
9. Transferências: validações, transação atômica, concorrência e histórico; impedir saldo negativo, valor não positivo e transferência para a mesma conta.
10. Testes das regras e integração com banco isolado, incluindo falhas e transferências concorrentes.
11. Fundamentos de HTML, CSS, TypeScript e Angular: componentes, templates e formulários.
12. HttpClient: telas de usuários, saldo e transferências, carregamento e erros.
13. Login, autorização e vínculo da conta ao usuário autenticado.

As etapas podem ser divididas em exercícios menores. Não usar dinheiro real. O saldo inicial e a origem de valores de demonstração serão definidos na etapa de Conta.

## Responsabilidades

- Domain: entidades e regras do negócio; não conhece banco, Angular ou HTTP.
- Application: casos de uso; Commands expressam pedidos e CommandHandlers coordenam sua execução. Interfaces de persistência ficam aqui.
- Infrastructure: acesso PostgreSQL, DbContext, migrations e implementações de Repository.
- Api: recebe HTTP em Controllers, valida entrada e expõe ViewModels; configura dependências e Swagger.
- frontend: aplicação Angular que consumirá a API.

Dependências: Application → Domain; Infrastructure → Application e Domain; Api → Application e Infrastructure. A API referencia Infrastructure para configurar as implementações.

ViewModel representa dados que entram ou saem da API. Não expor entidades de persistência diretamente. Começaremos com handlers simples, sem adicionar biblioteca de mediação.
