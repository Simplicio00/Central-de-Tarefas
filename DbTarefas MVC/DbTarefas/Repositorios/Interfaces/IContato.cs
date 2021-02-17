using DbTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Repositorios.Interfaces
{
	public interface IContato
	{
		Task CadastrarContato(Contato contato);

		Task<List<Contato>> Listar();
	}
}
