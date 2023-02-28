using Tarefas.Data;
using Tarefas.Models;
using Tarefas.Repositorios.Interfaces;

namespace Tarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public TarefaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public TarefaModel BuscarPorCodigo(int codigo)
        {
            TarefaModel tarefa = _bancoContext.Tarefas.Where(x => x.Codigo == codigo).FirstOrDefault();
            if (tarefa == null)
            {
                throw new Exception("Tarefa não encontrada pelo Código.");
            }
            return tarefa;
        }

        public List<TarefaModel> BuscarTodasAsTarefas()
        {
            List<TarefaModel> tarefas = _bancoContext.Tarefas.ToList();
            return tarefas;
        }

        public async Task Salvar(TarefaModel tarefaModel)
        {
            await _bancoContext.Tarefas.AddAsync(tarefaModel);
            await _bancoContext.SaveChangesAsync();
        }

        public async Task Atualizar(TarefaModel tarefaModel)
        {
            _bancoContext.Tarefas.Update(tarefaModel);
            await _bancoContext.SaveChangesAsync();
        }

        public async Task Deletar(TarefaModel tarefaModel)
        {
            _bancoContext.Tarefas.Remove(tarefaModel);
            await _bancoContext.SaveChangesAsync();
        }
    }
}
