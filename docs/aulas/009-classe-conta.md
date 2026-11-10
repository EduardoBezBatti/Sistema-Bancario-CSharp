# Aula 9 — Conta e vínculo com o usuário

## Conceitos apresentados antes do exercício

Conta.Id identifica a conta; Conta.UsuarioId identifica o dono. Mesmo no escopo inicial de uma conta por usuário, são identificadores de conceitos diferentes. A regra de uma conta por usuário ainda precisará ser implementada na persistência e no caso de uso.

Saldo usa decimal, adequado à representação decimal dos valores monetários deste projeto. Exemplo independente: decimal preco = 19.90m;. O sufixo m indica um literal decimal; um número com ponto sem sufixo é double por padrão.

Private set permite consultar o saldo externamente e restringe a escrita ao código da classe. Não limita a escrita somente ao construtor: futuros métodos Depositar e Sacar controlarão alterações com regras.

## Exercício proposto

Criar Conta.cs em Domain/Entities, namespace SistemaBancario.Domain.Entities. Declarar classe pública e propriedades Id (Guid), UsuarioId (Guid) e Saldo (decimal), todas com get público e private set. Criar construtor recebendo apenas Guid usuarioId. Gerar Id, receber o identificador do dono e iniciar Saldo em 0m. Não acrescentar validações ou operações de saldo nesta etapa. Executar dotnet build.

## Revisão dos conceitos

O nome do construtor deve ser igual ao da classe e não declara retorno. Parâmetros devem representar dados necessários fornecidos pelo chamador. Se a conta gera seu próprio identificador e inicia com saldo zero, não precisa receber id e saldo.

Pergunta de acompanhamento: para criar a conta de um Usuario já existente, qual propriedade desse objeto deve ser passada ao construtor de Conta?
