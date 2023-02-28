# Tarefas
API desenvolvida em Asp Net Core 6 cujo o objetivo é Gerenciar as Tarefas do usuário, podendo criar, atualizar, excluir, consultar todas ou consultar especificamente uma tarefa.
# Consultas
**Exemplo de Requisição: /api/Tarefa/BuscarTodas**
Esse metódo, no controlador, é o responsável por chamar o metódo do Repositório que retorna uma lista do tipo "TarefaModel", com todas as tarefas existentes no banco de dados e retornando-as como um JSON.


**Exemplo de Requisição: /api/Tarefa/BuscarPorCodigo/{codigo}**
Esse metódo recebe por parâmetro um código, onde vai chamar um metódo do Repositório que pede por parâmetro um código do tipo inteiro e vai buscar no banco de dados uma tarefa que possua aquele código, retornando um objeto do tipo "TarefaModel".

# Inclusão
**Exemplo de Requisição: /api/Tarefa/Criar**
No controlador, vai chamar um metódo do Serviço passando por parâmetro o corpo de requisição do tipo "TarefaRequestModel" que foi preenchido. No serviço, irá gerar uma nova variável do tipo "TarefaModel" e irá deixar o Status, automaticamente, com status de 'P'. Após isso, irá chamar o metódo "Salvar()" do Repositório que fará a função de adicionar aquela tarefa no banco de dados.

# Alteração
**Exemplo de Requisição: /api/Tarefa/Editar/{codigo}**
Esse metódo recebe por parâmetro um código e um corpo de requisição do tipo "TarefaRequestModel" com a descrição definida, então irá chamar o Serviço e puxar seu metódo "Editar()", onde vai passar esse código e corpo de requisição. No serviço, através do código passado, irá chamar o metódo "BuscarPorCodigo()" do Repositório, que vai retornar um Objeto do tipo "TarefaModel", onde a descrição vai ser substituída pela descrição passada no corpo de requisição e o seu Status vai ser passado para 'C'.

# Exclusão
**Exemplo de Requisição: /api/Tarefa/Excluir/{codigo}**
Esse metódo recebe por parâmetro um código, onde irá chamar o Serviço e usar seu metódo "Excluir()", passando por parâmetro o código. no Serviço, irá buscar uma tarefa através do metódo do Repositório "BuscarPorCodigo()", onde irá retornar um Objeto do tipo "TarefaModel" e depois chamará outro metódo do Repositório chamado de "Deletar()", onde passa esse objeto e ele será excluído do banco de dados.

