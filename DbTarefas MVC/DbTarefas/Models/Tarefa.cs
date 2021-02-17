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

		[Display(Name = "Data de conclusão prevista")]
		public DateTime DataConclusaoPrevista { get; set; }

		[Display(Name = "Data de conclusão")]
		public DateTime DataConclusao { get; set; }

		[Display(Name = "Área de atuação")]
		public string Area { get; set; }
		
		[Display(Name = "Grau de importância")]
		public string Impacto { get; set; }

		[Display(Name = "Progresso")]
		public string Status { get; set; }

		[StringLength(30)]
		public string Origem { get; set; }

		[StringLength(30)]
		[Display(Name = "Responsável")]
		public string Responsavel { get; set; }

		[DataType(DataType.Text)]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }

		[DataType(DataType.Text)]
		[Display(Name = "Observações")]
		public string Observacoes { get; set; }




		public bool Ativo { get; set; }



		[Display(Name = "Contato")]
		public int ContatoId { get; set; }


		[ForeignKey("ContatoId")]
		public virtual Contato ContatoIdNavigation { get; set; }


	}
}
