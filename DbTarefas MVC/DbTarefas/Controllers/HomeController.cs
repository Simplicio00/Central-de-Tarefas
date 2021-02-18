using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DbTarefas.Models;
using DbTarefas.Utilitarios.ViewModel;
using DbTarefas.Repositorios.Interfaces;

namespace DbTarefas.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ITarefa _tarefa;

		public HomeController(ILogger<HomeController> logger, ITarefa _tarefa)
		{
			_logger = logger;
			this._tarefa = _tarefa;
		}

		public async Task<IActionResult> Index(string pesquisa)
		{
			if(pesquisa != null){
				return View(await _tarefa.Pesquisar(pesquisa));
			}

			return View(await _tarefa.ListarTarefas());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
