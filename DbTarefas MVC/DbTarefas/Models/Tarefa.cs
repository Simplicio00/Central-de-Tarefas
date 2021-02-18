using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Models
{
	public class Tarefa
	{
		public Tarefa()
		{
			Ativo = true;
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdTarefa { get; set; }


		[Required]
		public DateTime DataConclusaoPrevista { get; set; }

		[Required]
		public DateTime DataConclusao { get; set; }

		[Required]
		public string Area { get; set; }
		
		[Required]
		public string Impacto { get; set; }

		[Required]
		public string Status { get; set; }


		[Required]
		[StringLength(30)]
		public string Origem { get; set; }

		[Required]
		[StringLength(30)]
		public string Responsavel { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string Descricao { get; set; }


		[Required]
		[DataType(DataType.Text)]
		public string Observacoes { get; set; }


		public bool Ativo { get; set; }


		[Required]
		public int ContatoId { get; set; }


		[ForeignKey("ContatoId")]
		public virtual Contato ContatoIdNavigation { get; set; }


	}
}
