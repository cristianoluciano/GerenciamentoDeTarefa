using Tarefas.Models;

namespace Tarefas.Servicos.Interfaces
{
    public interface ITarefaServico
    {
        Task<TarefaModel> Criar(TarefaRequestModel tarefaRequest);
        Task<TarefaModel> Editar(int codigo, TarefaRequestModel tarefaRequest);
        Task<TarefaModel> Excluir(int codigo);
    }
}
