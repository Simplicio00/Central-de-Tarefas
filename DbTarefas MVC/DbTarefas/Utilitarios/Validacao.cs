using DbTarefas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbTarefas.Utilitarios
{
	public class Validacao
	{
		public string RegexProp { get { return "@."; } protected set {} }

		public bool ValidacaoEmail(IEnumerable<Contato> lista, string email) 
			=> lista.Where(a => a.Email == email).Any() ? false : true;

		public bool ValidacaoArea(IEnumerable<Tarefa> lista, string area)
			=> lista.Where(a => a.Area == area).Any() ? false : true;

		public bool IsEmailTrue(string email) =>
            System.Text.RegularExpressions.Regex.IsMatch(email, RegexProp) ? true : false;

		


	}
}
