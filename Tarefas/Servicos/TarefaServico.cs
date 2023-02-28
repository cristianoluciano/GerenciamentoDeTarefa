using Tarefas.Models;
using Tarefas.Repositorios.Interfaces;
using Tarefas.Servicos.Interfaces;

namespace Tarefas.Servicos
{
    public class TarefaServico : ITarefaServico
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaServico(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        public async Task<TarefaModel> Criar(TarefaRequestModel tarefaRequest)
        {
            TarefaModel tarefa = new TarefaModel()
            {
                Descricao = tarefaRequest.Descricao,
                Status = Enums.StatusEnum.P
            };
            await _tarefaRepositorio.Salvar(tarefa);
            return tarefa;
        }

        public async Task<TarefaModel> Editar(int codigo, TarefaRequestModel tarefaRequest)
        {
            TarefaModel tarefa = _tarefaRepositorio.BuscarPorCodigo(codigo);
            tarefa.Descricao = tarefaRequest.Descricao;
            tarefa.Status = Enums.StatusEnum.C;
            await _tarefaRepositorio.Atualizar(tarefa);
            return tarefa;
        }

        public async Task<TarefaModel> Excluir(int codigo)
        {
            TarefaModel tarefa = _tarefaRepositorio.BuscarPorCodigo(codigo);
            await _tarefaRepositorio.Deletar(tarefa);
            return tarefa;
        }
    }
}
