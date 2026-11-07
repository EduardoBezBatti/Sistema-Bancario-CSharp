# Etapa 3 — Encapsulamento do Id

## Implementação do aluno

Alterou a propriedade em Usuario.cs para public Guid Id { get; private set; }. Preservou Id = Guid.NewGuid() no construtor e manteve Nome e Email sem alterações. O tutor não alterou o código do aluno.

## Revisão e resultado

Etapa aprovada. A leitura externa do identificador permanece pública e a atribuição direta por código de outras classes fica restrita. O construtor continua autorizado a gerar e atribuir o identificador. Private set permite futuras atribuições pela própria classe; não significa imutabilidade absoluta.

dotnet build executado na raiz após a alteração: quatro projetos compilados com zero erros e zero avisos. Revisão do diff confirmou que somente o setter de Id foi modificado. Não foram adicionados testes para essa alteração simples de controle de acesso.

## Perguntas e aprendizado observado

Nas perguntas após a etapa 2, o aluno identificou que duas execuções de new criam dois objetos e que os identificadores gerados diferem. O tutor esclareceu que identidade de objeto e valor do Id são conceitos distintos: dois objetos podem ter propriedades iguais e continuar separados. O aluno previu corretamente que alterar Nome de um desses objetos não altera o outro.

Ao receber o exemplo Usuario segundo = primeiro, sem outro new, o aluno explicou corretamente que existe um objeto compartilhado pelas duas referências e que uma alteração é visível por ambas.

O aluno apontou o risco de duplicidade e confusão ao permitir alteração externa do identificador. O tutor relacionou isso aos vínculos entre usuário, conta e transações e esclareceu que a chave primária também protege a unicidade no banco, quando configurada.

Antes de implementar private set, o aluno explicou que a atribuição funciona internamente. O tutor refinou a expressão para código dentro da classe, em vez de dentro do objeto. A próxima pergunta verifica a diferença entre leitura pública e escrita privada.

## Pendências

Nome e Email ainda permitem alterações externas e valores inválidos. Validações serão estudadas em exercício posterior. A aula 003 registra a explicação já apresentada no chat e a tarefa entregue.

Commit: feat: protege alteracao externa do identificador de Usuario.
