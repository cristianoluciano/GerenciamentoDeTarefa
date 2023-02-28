using System.ComponentModel.DataAnnotations;
using Tarefas.Enums;

namespace Tarefas.Models
{
    public class TarefaModel
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo 'Descrição' é obrigatório. Por favor, preencha-o.")]
        public string Descricao { get; set; }
        public StatusEnum Status { get; set; }
    }
}
