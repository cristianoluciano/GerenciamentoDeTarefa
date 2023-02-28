using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarefas.Models;

namespace Tarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(EntityTypeBuilder<TarefaModel> builder)
        {
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
