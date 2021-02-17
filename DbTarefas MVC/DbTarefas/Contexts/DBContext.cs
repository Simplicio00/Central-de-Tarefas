using DbTarefas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Context
{
	public class DBContext : DbContext
	{
		public DBContext(DbContextOptions<DBContext> ct): base (ct)
		{

		}


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				// Configuração do banco de dados

				optionsBuilder.UseSqlServer("Data Source=LUCASSOLIVEIRA\\SQLEXPRESS; Initial Catalog=DbTarefas; Integrated Security=True");
			}
		}

		public DbSet<Tarefa> Tarefa { get; set; }
		public DbSet<Contato> Contato { get; set; }



	}
}
