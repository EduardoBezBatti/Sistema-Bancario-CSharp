# Registro de pausa — início do estudo de try/catch

Data: 08/11/2026. O aluno solicitou pausar até retornar e enviar as alterações para main. Este registro não aprova uma etapa 7 de implementação: o conteúdo de try/catch ainda está em discussão.

Após a etapa 6, o aluno explicou corretamente que nome inválido dispara a primeira validação e email inválido impede gerar o Id. Foram introduzidos try, catch e a propriedade Message das exceções com exemplos no chat.

O aluno reconheceu que uma exceção impede exibir a mensagem de sucesso dentro do try. O tutor destacou que, após um catch compatível que termina normalmente, a execução prossegue fora do bloco. No cenário válido, o aluno identificou sucesso sem entrada no catch, e foi reforçada a execução da linha posterior ao bloco.

Ao trocar catch de ArgumentException para InvalidOperationException, surgiu a ideia de que o usuário seria criado porque o catch não mencionava ArgumentException. Foi esclarecido que o lançamento vem do construtor e independe do catch; um catch incompatível não trata essa exceção. Uma pergunta simples de captura compatível permanece pendente e foi salva em docs/STATUS.md.

Antes do envio, o tutor encontrou alterações locais do aluno: ponto final nas duas mensagens de obrigatoriedade e espaço após a vírgula no ArgumentException de email. Revisou o diff e executou dotnet build: zero erros e zero avisos. Incluiu as alterações sem modificar o código do aluno. Acentuação das mensagens e espaço após if do nome permanecem detalhes de apresentação pendentes.

Próxima ação: retomar a pergunta salva no status, sem avançar automaticamente para funcionalidades bancárias ou implementar o exercício pelo aluno.
