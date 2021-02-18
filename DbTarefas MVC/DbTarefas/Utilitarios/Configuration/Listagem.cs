using DbTarefas.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Utilitarios
{
	public class Listagem
	{
		public static List<SelectListItem> Status {
			get
			{
				return new List<SelectListItem>()
				{
					new SelectListItem("Em andamento", "Em andamento"),
					new SelectListItem("Em espera","Em espera"),
					new SelectListItem("Concluído","Concluído")
				};
			}
			private set { }
		}

		public static List<SelectListItem> Impacto {
			get
			{
				return new List<SelectListItem>()
				{
					new SelectListItem ("Muito baixo","Muito baixo"), 
					new SelectListItem("Baixo", "Baixo"),
					new SelectListItem ("Médio","Médio"),
					new SelectListItem("Alto","Alto"),
					new SelectListItem("Muito alto","Muito alto")
				};
			}
			private set { }
		}		


	}
}
