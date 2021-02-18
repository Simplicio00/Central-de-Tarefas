using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbTarefas.Models;
using DbTarefas.Repositorios.Interfaces;
using DbTarefas.Utilitarios;
using DbTarefas.Utilitarios.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DbTarefas.Controllers
{
	public class TarefaController : Controller
	{
		Listagem listagem;
		Validacao _validacao;
		ITarefa _tarefa;
		IContato _contato;
		public TarefaController(Listagem listagem, IContato _contato, ITarefa _tarefa, Validacao _validacao)
		{
			this.listagem = listagem;
			this._contato = _contato;
			this._tarefa = _tarefa;
			this._validacao = _validacao;
		}


		public IActionResult Tarefa()
		{
			ViewBag.Contatos = _contato.Listar().Result.Select(a => new SelectListItem(a.Email, a.ContatoId.ToString()));
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Tarefa(CadastroViewModel tarefa)
		{
			if (ModelState.IsValid)
			{

				await _tarefa.Cadastrar(
					new Tarefa()
					{
						Area = tarefa.Area,
						DataConclusao = tarefa.DataConclusao,
						DataConclusaoPrevista = tarefa.DataConclusaoPrevista,
						Descricao = tarefa.Descricao,
						Status = tarefa.Status,
						Responsavel = tarefa.Responsavel,
						Origem = tarefa.Origem,
						Observacoes = tarefa.Observacoes,
						Impacto = tarefa.Impacto,
						ContatoId = tarefa.ContatoId
					});

				TempData["MSGSS1"] = "Cadastro concluído com sucesso!";

				return RedirectToAction("index","home");
			}
			else
			{
				ViewBag.Contatos = _contato.Listar().Result.Select(a => new SelectListItem(a.Email, a.ContatoId.ToString()));
				return View(tarefa);
			}

		}


		[HttpGet]
		public async Task<IActionResult> TarefaEmDetalhe(int id)
		{
			ViewBag.Contatos = _contato.Listar().Result.Select(a => new SelectListItem(a.Email, a.ContatoId.ToString()));

			var existente = await _tarefa.TarefaPorId(id);

			var viewModel = new AtualizacaoViewModel(){
				Area = existente.Area,
				DataConclusao = existente.DataConclusao,
				DataConclusaoPrevista = existente.DataConclusaoPrevista,
				Descricao = existente.Descricao,
				Impacto = existente.Impacto,
				Origem = existente.Origem,
				Status = existente.Status,
				Responsavel = existente.Responsavel,
				Observacoes = existente.Observacoes,
				ContatoId = existente.ContatoId,
				IdTarefa = existente.IdTarefa
			};
			
			return View(viewModel); 
		}


		[HttpPost]
		public async Task<IActionResult> TarefaEmDetalhe(AtualizacaoViewModel tarefa)
		{
			ViewBag.Contatos = _contato.Listar().Result.Select(a => new SelectListItem(a.Email, a.ContatoId.ToString()));

			if (ModelState.IsValid)
			{
				await _tarefa.Atualizar( new Tarefa() { 
					Area = tarefa.Area,
					DataConclusao = tarefa.DataConclusao,
					DataConclusaoPrevista = tarefa.DataConclusaoPrevista,
					Descricao = tarefa.Descricao,
					Impacto = tarefa.Impacto,
					Origem = tarefa.Origem,
					Status = tarefa.Status,
					Responsavel = tarefa.Responsavel,
					Observacoes = tarefa.Observacoes,
					ContatoId = tarefa.ContatoId,
					IdTarefa = tarefa.IdTarefa
				});
				TempData["MSGSS1"] = "Tarefa atualizada com sucesso!";

				return RedirectToAction("index","home");
			}
	
	
			return View(tarefa);
		}

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DesativarTarefa(int id)
		{
			await _tarefa.Desativar(id);
			TempData["MSGSS1"] = "A tarefa foi desativada com sucesso!";

			return RedirectToAction("index", "home");
		}




		public async Task<IActionResult> NovoContato(string parametro)
		{

			if (ModelState.IsValid && parametro.Length > 5)
			{
				bool resultado =  _validacao.ValidacaoEmail(_contato.Listar().Result, parametro);

				if (resultado.Equals(false))
				{
					TempData["MSGERRO"] = "Este E-Mail já existe";
					await Task.Delay(1000);
					return RedirectToAction("Tarefa");
				}
				else
				{
					await _contato.CadastrarContato(new Contato { Email = parametro});

					TempData["MSGSS"] = "O Email foi cadastrado com sucesso!";
					
					return RedirectToAction(nameof(Tarefa));
					
				}
			}


			TempData["MSGERRO"] = "EMail inválido";

			return RedirectToAction(nameof(Tarefa));

		}


	}
}
