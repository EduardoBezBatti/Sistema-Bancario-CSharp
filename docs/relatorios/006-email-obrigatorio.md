# Etapa 6 — Obrigatoriedade e proteção de Email

## Implementação do aluno

Alterou Email para get público e private set. Adicionou a condição string.IsNullOrWhiteSpace(email) após a validação de nome e lançou ArgumentException com nameof(email). Mudou a atribuição para Email = email.Trim(). Ambas as validações ficam antes de Guid.NewGuid() e das atribuições às propriedades.

## Revisão

Etapa aprovada quanto à sintaxe, lógica e encapsulamento solicitados. Nome inválido interrompe o construtor antes da verificação de email; email inválido interrompe antes de gerar o identificador e chamar Trim. O tutor não alterou o código do aluno.

A mensagem implementada foi "O email e obrigatorio", em vez da redação sugerida "O e-mail é obrigatório.". Acentuação, pontuação, espaço após a vírgula em ArgumentException e espaço após if na verificação do nome são detalhes de apresentação pendentes, sem impacto na regra implementada.

## Verificação

dotnet build executado na raiz: quatro projetos compilados, zero erros e zero avisos. Diff revisado: somente proteção do setter de Email, nova validação e uso de Trim. Não foram executados testes de comportamento nem criados testes automatizados para esta alteração simples. A aprovação comportamental se baseia na revisão estática, não apenas no build.

## Aprendizado observado e limites

O aluno explicou corretamente antes da implementação que "ana" passa pela validação, pois ela verifica somente null ou branco. Formato de e-mail, unicidade e verificação de titularidade não foram implementados. Nenhuma conversão de maiúsculas ou minúsculas foi adicionada.

Na revisão da etapa anterior, reconheceu que Trim preserva espaços internos; o tutor precisou o exemplo em que três espaços internos permanecem três.

Próxima pergunta: prever qual validação interrompe o construtor quando ambos os argumentos são inválidos, reforçando ordem de execução e throw.

Commit: feat: valida email obrigatorio e protege sua alteracao.
