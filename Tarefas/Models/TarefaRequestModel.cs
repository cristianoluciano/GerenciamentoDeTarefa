using System.ComponentModel.DataAnnotations;

namespace Tarefas.Models
{
    public class TarefaRequestModel
    {
        [Required(ErrorMessage = "O campo 'Descrição' é obrigatório. Por favor, preencha-o.")]
        public string Descricao { get; set; }
    }
}
