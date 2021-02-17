using DbTarefas.Context;
using DbTarefas.Models;
using DbTarefas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Repositorios
{
	public class TarefaRepository : ITarefa, IContato
	{
		private DBContext ctx;
		public TarefaRepository(DBContext ctx)
		{
			this.ctx = ctx;
		}

		public async Task CadastrarContato(Contato contato)
		{
			try
			{
				await ctx.Contato.AddAsync(contato);
				await ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			
		}


		public async Task<List<Contato>> Listar() => await ctx.Contato.AsTracking().ToListAsync();


		public async Task Cadastrar(Tarefa tarefa)
		{
			try
			{
				await ctx.Tarefa.AddAsync(tarefa);
				await ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task<List<Tarefa>> ListarTarefas() => await ctx.Tarefa.AsTracking()
																.Include(a => a.ContatoIdNavigation)
																.Where(a => a.Ativo == true).ToListAsync();

		public async Task<Tarefa> TarefaPorId(int id) => await ctx.Tarefa.Where(a => a.IdTarefa == id && a.Ativo == true).FirstOrDefaultAsync();



		public async Task Atualizar(Tarefa tarefa)
		{
			try
			{
				ctx.Tarefa.Update(tarefa);
				await ctx.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public async Task Desativar(int id)
		{
			var tarefa = await TarefaPorId(id);

			if(tarefa != null)
			{
				try
				{
					tarefa.Ativo = false;
					await Atualizar(tarefa);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
			

		}
	}
}
