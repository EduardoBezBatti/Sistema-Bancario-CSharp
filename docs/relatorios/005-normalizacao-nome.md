# Etapa 5 — Normalização do nome

## Implementação e revisão

O aluno substituiu Nome = nome por Nome = nome.Trim() no construtor. O tutor leu o código atual e o diff: somente essa atribuição foi alterada. A verificação IsNullOrWhiteSpace e o lançamento de ArgumentException permanecem antes do Trim. O setter de Nome continua privado.

Etapa aprovada. Não houve alteração do código pelo tutor. Nomes válidos passam a ser armazenados sem espaços em branco nas extremidades; espaços internos são preservados. Email permanece fora do escopo desta etapa.

## Aprendizado observado

O aluno identificou corretamente a rejeição de nome contendo somente espaços e a aceitação de nome com letras cercadas de espaços. Inicialmente generalizou Trim como remoção de todos os espaços; o tutor esclareceu que espaços internos permanecem e que o método não altera a variável original.

O aluno propôs corretamente Nome = nome.Trim(). Ao discutir null, inicialmente considerou que o método atribuiria null; foi explicado que chamar um método de instância sobre null lança NullReferenceException. Depois identificou corretamente que a verificação anterior de nome contendo somente espaços resulta em ArgumentException.

## Validação e limites

dotnet build na raiz: quatro projetos compilados, zero erros e zero avisos. Revisão estática confirmou a ordem da validação e da normalização. Não foram executados testes de comportamento nem adicionados testes automatizados para essa alteração simples.

Continuam pendentes os detalhes de apresentação já registrados na etapa 4: espaço após if e acentuação/pontuação da mensagem de erro. Não impedem a aprovação funcional e não foram alterados automaticamente.

## Próximo acompanhamento

Confirmar a preservação dos espaços internos com a pergunta da aula 005 antes de avançar para outra regra.

Commit: feat: remove espacos das extremidades do nome de Usuario.
