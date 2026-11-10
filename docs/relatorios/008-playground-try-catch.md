# Etapa 7 — Playground e tratamento de exceções

Data: 09/11/2026. Etapa aprovada. Complementa o relatório 007 de pausa, que não aprovava implementação.

O aluno criou o projeto console, adicionou-o à solução e referenciou Domain. Implementou using, try criando Usuario, mensagem de sucesso, catch de ArgumentException imprimindo erro.Message e encerramento após o bloco. O tutor não alterou seu código.

Inicialmente o template Hello, World ainda estava salvo. O tutor indicou o Program.cs do Playground após dúvida sobre o arquivo da API. As revisões seguintes executaram nome inválido, dados válidos e, finalmente, nome Eduardo com email de um espaço. Um espaço atende ao cenário de somente espaços, assim como três.

## Verificações

Execução final: dotnet run --project playground/SistemaBancario.Playground, código 0. Saída:

```text
O email e obrigatorio. (Parameter 'email')
Tentativa Concluida
```

A mensagem de sucesso não apareceu e o encerramento foi alcançado após o catch. A indicação do parâmetro vem de nameof(email) passado à ArgumentException. O run compilou e executou a entrega final. Na revisão anterior, dotnet build da solução passou com zero erros e zero avisos; a alteração posterior foi apenas o argumento de email.

Não foram adicionados testes automatizados. Houve execução manual dos três cenários durante as revisões. Detalhe de estilo: preferir catch ( com espaço; grafia das mensagens mantida. Nenhuma correção automática feita.

## Aprendizado observado

O aluno inicialmente confundiu mensagem armazenada com impressão e considerou continuidade após throw e captura por tipo incompatível. Após explicações, identificou ArgumentException como tipo correto e descreveu o fluxo do email inválido, captura e encerramento. Explicou que o chamador deve tratar a falha.

Playground é um programa de experimentação, não uma API ou teste automatizado. Próxima pergunta: onde exibir usuario.Nome para observar a normalização após criação válida.

Commit: feat: adiciona Playground para praticar tratamento de excecoes.
