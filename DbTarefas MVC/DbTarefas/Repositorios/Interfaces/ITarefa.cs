using DbTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Repositorios.Interfaces
{
	public interface ITarefa
	{
		Task<List<Tarefa>> ListarTarefas();

		Task<Tarefa> TarefaPorId(int id);

		Task Cadastrar(Tarefa tarefa);

		Task Atualizar(Tarefa tarefa);

		Task Desativar(int id);
	}
}
