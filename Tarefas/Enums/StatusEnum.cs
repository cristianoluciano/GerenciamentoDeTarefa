using System.ComponentModel;

namespace Tarefas.Enums
{
    public enum StatusEnum
    {
        [Description("Tarefa com status pendente")]
        P = 1,
        [Description("Tarefa com status de concluída")]
        C = 2
    }
}
