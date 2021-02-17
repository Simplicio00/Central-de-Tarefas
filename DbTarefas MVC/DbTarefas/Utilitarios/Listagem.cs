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



		public List<string> ListagemPorArea(List<Tarefa> list)
		{
			List<string> newlist = new List<string>();

			if (list == null)
			{
				string[] areas = { "Desenvolvimento web", "Desenvolvimento mobile", "Desenvolvimento de aplicações" };
				newlist.AddRange(areas);
			}
			else
			{
				foreach (var item in list)
				{
					newlist.Add(item.Area);
				}
			}

			return newlist;
		}



		//public async Task<List<SelectListItem>> ListagemEmail(Task<List<Contato>> list)
		//{
		//	List<SelectListItem> nvlista = new List<SelectListItem>();

		//	if(list.Result.Count == 0)
		//	{
		//		nvlista.Add(new SelectListItem("usuario@email.com", "2"));
		//	}
			
		//	foreach (var item in list.Result)
		//	{
		//		nvlista.Add(new SelectListItem(item.Email, item.ContatoId.ToString()));
		//	}


		//	return nvlista;
		//}

		
				


	}
}
