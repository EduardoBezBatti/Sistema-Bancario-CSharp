# Etapa 1 — Primeira entidade Usuario

## Implementação do aluno

O aluno criou backend/SistemaBancario.Domain/Entities/Usuario.cs com namespace SistemaBancario.Domain.Entities, classe pública Usuario e propriedades públicas Id (Guid), Nome e Email (string). As strings foram inicializadas com string.Empty e todas as propriedades possuem get e set.

## Revisão do tutor

Etapa aprovada. Nome do arquivo e da classe correspondem; classe e propriedades usam PascalCase; tipos e visibilidade atendem ao exercício. O namespace com bloco de chaves é válido, assim como a alternativa com ponto e vírgula apresentada na aula. Não há necessidade de mudar esse estilo.

O único ajuste aplicado pelo tutor foi adicionar espaços em `{ get; set; }` nas três propriedades para melhorar legibilidade. Não houve mudança de comportamento.

## Conceitos reforçados e limites

A classe define um tipo; um objeto é uma instância criada a partir desse tipo. string.Empty inicializa texto vazio, mas não valida nome ou e-mail. Id ainda assume Guid.Empty quando não atribuído; a geração será estudada com construtores. Setters públicos permitem alterações externas e serão restringidos em uma etapa de encapsulamento. Esses pontos são limites intencionais do exercício, não erros da entrega.

## Verificação

`dotnet build` executado na raiz antes e depois da formatação: solução compilada com zero erros e zero avisos. Não foram adicionados testes automatizados para esta declaração simples de propriedades. A compilação não comprova regras de cadastro, que ainda não existem.

## Próxima etapa

Construtor com parâmetros para Nome e Email e geração do Id com Guid.NewGuid(). Validações e encapsulamento serão desenvolvidos em exercícios seguintes. A explicação do aluno sobre classe versus objeto ainda não foi coletada.

Commit previsto: `feat: adiciona entidade Usuario e registra revisao da etapa 1`.
