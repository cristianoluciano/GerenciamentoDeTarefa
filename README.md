# Tarefas
API desenvolvida em Asp Net Core 6.0, cujo o objetivo é gerenciar as tarefas do usuário, podendo criar, atualizar, excluir e consultar todas ou consultar especificamente uma tarefa.
# Consultas
**Requisição GET: /api/Tarefa/BuscarTodas**
Este end-point retorna um JSON com todas as tarefas cadastradas.
.


**Requisição GET: /api/Tarefa/BuscarPorCodigo/{codigo}**
Este end-point recebe por parâmetro o código de tarefa que o usuário quer ter acesso às informações.

# Inclusão
**Requisição POST: /api/Tarefa/Criar**
End-point responsável por salvar uma tarefa. Ex de json aceito: 
{
  descricao: "Ir jogar futebol"
}

# Alteração
**Requisição PUT: /api/Tarefa/Editar/{codigo}**
End-point responsável por editar uma tarefa. É necessário o envio do código por parâmetro. Ex de json aceito: 
{
  descricao: "Ir ao cinema"
}
# Exclusão
**Requisição DELETE: /api/Tarefa/Excluir/{codigo}**
End-point responsável pela exclusão do registro. É necessário informar o código da tarefa a ser excluída.

