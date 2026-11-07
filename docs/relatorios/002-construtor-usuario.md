# Etapa 2 — Construtor de Usuario

## Trabalho do aluno

Adicionou um construtor público Usuario(string nome, string email), gerou Id com Guid.NewGuid() e atribuiu os parâmetros às propriedades Nome e Email. O tutor não alterou a implementação.

## Primeira revisão

Os parâmetros inicialmente foram declarados Nome e Email. A atribuição Nome = nome produziu CS0103 porque nome não existia naquele contexto: C# diferencia maiúsculas e minúsculas. Email = Email produziu CS1717, pois o parâmetro ocultava a propriedade e era atribuído a ele mesmo. A compilação dessa tentativa falhou com um erro e um aviso.

O tutor explicou a diferença entre propriedades em PascalCase e parâmetros em camelCase. O aluno fez a correção, preservando a geração do identificador.

## Revisão final e verificação

Etapa aprovada: parâmetros nome e email em camelCase, atribuições Nome = nome e Email = email corretas, construtor com nome igual ao da classe e sem tipo de retorno. Guid.NewGuid() gera o identificador na criação do objeto.

`dotnet build` na raiz após a correção: quatro projetos compilados, zero erros e zero avisos. Não foram adicionados testes automatizados para essas atribuições simples. O build confirma compilação; não comprova validação de dados.

## Limites atuais

Os setters seguem públicos, portanto o chamador ainda pode alterar as propriedades após a criação. Nome e e-mail vazios continuam permitidos. Encapsulamento e validações serão exercícios posteriores. As inicializações com string.Empty foram mantidas conforme o exercício; com atribuições no construtor, elas não são necessárias para satisfazer a inicialização das propriedades.

Após a aprovação do código, o aluno explicou que a expressão new Usuario("Ana", "ana@exemplo.com") criaria uma variável com esses valores. O tutor esclareceu que a expressão cria um objeto e executa o construtor; a declaração Usuario usuario = ... cria a variável que guarda a referência ao objeto. Foram diferenciados tipo, variável, parâmetros e propriedades. O aluno pediu que perguntas desse estilo sejam incluídas nos próximos exercícios; preferência registrada em AGENTS.md e docs/PLANO.md. A compreensão dessa distinção será retomada nas próximas perguntas.

Commit: `feat: inicializa Usuario com construtor e identificador`.
