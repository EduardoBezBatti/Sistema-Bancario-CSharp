# Etapa 9 — Primeira entidade Conta

Data: 09/11/2026. Implementação do aluno; tutor revisou e orientou sem alterar sua classe.

## Entrega e revisões

O aluno criou Conta com namespace correto e propriedades Id, UsuarioId e Saldo com tipos corretos e setters privados. Inicialmente nomeou o construtor UsuarioId: dotnet build apontou CS1520, método sem tipo de retorno. O tutor explicou que o construtor precisa ter o mesmo nome da classe. Explicou também a atribuição encadeada Saldo = saldo = 0m e a ausência de necessidade de receber saldo.

Na segunda tentativa, corrigiu o nome para Conta e as atribuições para Id = Guid.NewGuid(), UsuarioId = usuarioId e Saldo = 0m. Manteve parâmetros id e saldo que não eram utilizados; compilou com zero erros e avisos. O tutor orientou remover esses parâmetros para representar corretamente os dados necessários à criação.

Na entrega final, deixou somente Conta(Guid usuarioId), mantendo as três atribuições corretas. Etapa aprovada. Namespace com ponto e vírgula é válido, embora Usuario use namespace com chaves.

## Verificação

dotnet build na raiz após a entrega final: cinco projetos compilados com zero erros e zero avisos. Nenhum teste automatizado ou cenário de execução de Conta foi acrescentado; revisão estática verificou os tipos, acessos, assinatura e inicialização.

## Aprendizado e limites

O aluno relacionou private set à proteção do saldo. O tutor esclareceu que métodos da própria classe, além do construtor, poderão alterar o saldo. O aluno distinguiu conta e usuário argumentando que um usuário poderia ter mais de uma conta; foi reforçado que, no escopo inicial, planejamos uma por usuário e que os identificadores são diferentes mesmo assim.

UsuarioId apenas armazena o Guid recebido: ainda não há validação de Guid.Empty, verificação de existência do usuário ou restrição de uma conta por usuário. Não há depósito, saque, transferência, persistência ou vínculo de chave estrangeira implementados. Esses limites seguem o exercício solicitado.

Próxima pergunta: qual propriedade de um Usuario existente fornece o argumento para criar sua Conta? Ainda não houve exercício posterior.

Commit: feat: adiciona entidade Conta com saldo inicial zero.
