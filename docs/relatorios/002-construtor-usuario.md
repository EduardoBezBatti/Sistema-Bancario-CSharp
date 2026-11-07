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

A explicação conceitual do aluno sobre propriedade e parâmetro ainda não foi coletada; a correção de código foi confirmada.

Commit: `feat: inicializa Usuario com construtor e identificador`.
