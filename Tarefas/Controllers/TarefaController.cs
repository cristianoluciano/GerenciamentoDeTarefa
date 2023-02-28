using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Repositorios.Interfaces;
using Tarefas.Servicos.Interfaces;

namespace Tarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaServico _tarefaServico;
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaController(ITarefaServico tarefaServico, ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaServico = tarefaServico;
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet("BuscarTodas")]
        public async Task<ActionResult<List<TarefaModel>>> BuscarTodas()
        {
            List<TarefaModel> Tarefas = _tarefaRepositorio.BuscarTodasAsTarefas();
            return Ok(Tarefas);
        }
        [HttpGet("BuscarPorCodigo/{codigo}")]
        public async Task<ActionResult<TarefaModel>> BuscarPorCodigo(int codigo)
        {
            try
            {
                TarefaModel tarefa = _tarefaRepositorio.BuscarPorCodigo(codigo);
                return tarefa;
            }
            catch (Exception erro)
            {
                return BadRequest($"Não foi possível buscar sua tarefa. Detalhe do erro: {erro.Message}");
            }
        }
        [HttpPost("Criar")]
        public async Task<ActionResult> Criar([FromBody] TarefaRequestModel criarTarefa)
        {
            try
            {
                TarefaModel resultado = await _tarefaServico.Criar(criarTarefa);
                return Ok($"Tarefa criada com sucesso ! O código dela é: {resultado.Codigo}.");
            }
            catch (Exception erro)
            {
                return BadRequest($"Não foi possível criar sua tarefa. Detalhe do erro: {erro.Message}");
            }
        }
        [HttpPut("Editar/{codigo}")]
        public async Task<ActionResult> Editar(int codigo, [FromBody] TarefaRequestModel editarTarefa)
        {
            try
            {
                TarefaModel resultado = await _tarefaServico.Editar(codigo, editarTarefa);
                return Ok($"Tarefa atualizada com sucesso ! Ela teve descrição atualizada para: '{resultado.Descricao}'.");
            }
            catch (Exception erro)
            {
                return BadRequest($"Não foi possível editar sua tarefa. Detalhe do erro: {erro.Message}");
            }
        }
        [HttpDelete("Excluir/{codigo}")]
        public async Task<ActionResult> Excluir(int codigo)
        {
            try
            {
                TarefaModel tarefa = await _tarefaServico.Excluir(codigo);
                return Ok($"Tarefa '{tarefa.Descricao}' foi excluída com sucesso !");
            }
            catch (Exception erro)
            {
                return BadRequest($"Não foi possível excluir sua tarefa. Detalhe do erro: {erro.Message}");

            }
        }
    }
}
