# Aula 6 — E-mail obrigatório e setter privado

## Conceitos apresentados antes da implementação

A mesma regra de obrigatoriedade estudada para Nome pode proteger Email: verificar o parâmetro no construtor antes da atribuição. IsNullOrWhiteSpace identifica null, texto vazio e somente espaços; não verifica formato de endereço de e-mail.

Exemplo independente de campo obrigatório:

```csharp
if (string.IsNullOrWhiteSpace(descricao))
{
    throw new ArgumentException("A descrição é obrigatória.", nameof(descricao));
}
```

Um setter privado impede atribuição direta por outras classes. Trim remove espaços das extremidades e seu retorno precisa ser atribuído à propriedade. A validação deve ocorrer antes do Trim para rejeitar null sem chamar um método de instância sobre ele.

## Exercício apresentado no chat

1. Usar private set em Email.
2. Após a verificação de nome, verificar email com IsNullOrWhiteSpace.
3. Lançar ArgumentException com mensagem de obrigatoriedade e nameof(email) para entrada inválida.
4. Atribuir email.Trim() a Email.
5. Manter ambas as validações antes de gerar Id e preencher propriedades; executar dotnet build.

## Perguntas

Antes da implementação: essa verificação aceita "ana" como e-mail? O aluno respondeu corretamente que aceita, pois verifica apenas ausência de preenchimento.

Revisão: se nome e email contiverem somente espaços, qual validação lança a primeira exceção? A execução chega à segunda validação?
