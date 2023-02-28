using Microsoft.EntityFrameworkCore;
using Tarefas.Data;
using Tarefas.Repositorios;
using Tarefas.Repositorios.Interfaces;
using Tarefas.Servicos;
using Tarefas.Servicos.Interfaces;

namespace Tarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            //REPOSITÓRIO
            builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

            //SERVIÇO
            builder.Services.AddScoped<ITarefaServico, TarefaServico>();
            builder.Services.AddEntityFrameworkNpgsql().AddDbContext<BancoContext>
            (options =>
            options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=Tarefas;User Id=postgres;Password=1234"));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}