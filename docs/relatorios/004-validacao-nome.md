# Etapa 4 — Validar e proteger Nome

## Implementação e revisão

O aluno adicionou ao início do construtor a verificação string.IsNullOrWhiteSpace(nome) e lançou ArgumentException com nameof(nome). Id e propriedades são atribuídos somente após a verificação.

Na primeira revisão, Nome ainda tinha setter público. O tutor explicou que uma atribuição externa posterior poderia contornar a validação. O aluno corrigiu para private set na segunda tentativa. O tutor não alterou seu código.

Etapa aprovada: regra de obrigatoriedade no construtor e bloqueio de atribuição externa direta a Nome. Email permanece com setter público e sem validação, conforme escopo.

## Verificação e limites

dotnet build na raiz nas duas revisões: zero erros e zero avisos. Revisão estática confirmou a condição, o lançamento antes das atribuições e a alteração do setter. Não foram executados testes de comportamento nesta etapa; compilação por si só não comprova os casos de entrada.

Dois detalhes de apresentação sugeridos continuam pendentes e não impedem aprovação funcional: espaço entre if e parêntese e acentuação/pontuação da mensagem, atualmente "O nome e obrigatorio". Nenhuma correção automática foi aplicada.

A validação rejeita null, vazio e somente espaços, mas não remove espaços ao redor de um nome válido nem impõe outras regras. Private set permite alterações internas pela classe; futuros métodos precisarão preservar a regra.

## Aprendizado observado

O aluno inicialmente confundiu leitura do Id com ausência de valor. Após explicação do fluxo do construtor, identificou corretamente a leitura pública e a cópia do Guid para variável independente. Também previu que reatribuir uma variável local de nome não altera usuario.Nome.

Relacionou setter público ao risco de atribuir nome vazio posteriormente. O tutor esclareceu que private set permite escrita pelo construtor e por métodos da própria classe. O aluno previu corretamente que a exceção impede chegar à atribuição quando nome contém apenas espaços.

## Próximo acompanhamento

Confirmar os diferentes resultados para nome somente com espaços e nome válido com espaços nas extremidades, antes de introduzir normalização ou outra regra.

Commit: feat: valida nome obrigatorio e restringe sua alteracao.
