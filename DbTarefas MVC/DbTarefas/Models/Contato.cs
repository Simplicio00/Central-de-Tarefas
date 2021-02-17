using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Models
{
	public class Contato
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ContatoId { get; set; }

		[Required]
		[StringLength(30)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		public virtual ICollection<Tarefa> Tarefa { get; set; }
	}
}
