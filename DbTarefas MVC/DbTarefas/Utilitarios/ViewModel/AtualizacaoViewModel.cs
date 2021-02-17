using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Utilitarios.ViewModel
{
	public class AtualizacaoViewModel
	{
		[Required(ErrorMessage = "A data é obrigatória")]
		[Display(Name = "Data de conclusão prevista")]
		public DateTime DataConclusaoPrevista { get; set; }

		[Required(ErrorMessage = "A data é obrigatória")]
		[Display(Name = "Data de conclusão")]
		public DateTime DataConclusao { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório")]
		[Display(Name = "Área de atuação")]
		public string Area { get; set; }

		[Required(ErrorMessage = "O campo é obrigatório")]
		[Display(Name = "Grau de importância")]
		public string Impacto { get; set; }

		[Required(ErrorMessage = "O {0} é obrigatório")]
		[Display(Name = "Progresso")]
		public string Status { get; set; }

		[Required(ErrorMessage = "A {0} é obrigatório")]
		[StringLength(30)]
		public string Origem { get; set; }

		[Required(ErrorMessage = "O {0} é obrigatório")]
		[StringLength(30)]
		[Display(Name = "Responsável")]
		public string Responsavel { get; set; }

		[Required(ErrorMessage = "A {0} é obrigatória")]
		[DataType(DataType.Text)]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "As {0} são obrigatórias")]
		[DataType(DataType.Text)]
		[Display(Name = "Observações")]
		public string Observacoes { get; set; }



		[Required(ErrorMessage = "O Contato é obrigatório")]
		[Display(Name = "Contato")]
		public int ContatoId { get; set; }
	}
}
