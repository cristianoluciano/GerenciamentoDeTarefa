using Tarefas.Models;

namespace Tarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        List<TarefaModel> BuscarTodasAsTarefas();
        TarefaModel BuscarPorCodigo(int codigo);
        Task Salvar(TarefaModel tarefaModel);
        Task Atualizar(TarefaModel tarefaModel);
        Task Deletar(TarefaModel tarefaModel);
    }
}
