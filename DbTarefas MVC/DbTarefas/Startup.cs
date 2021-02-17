using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbTarefas.Context;
using DbTarefas.Repositorios;
using DbTarefas.Repositorios.Interfaces;
using DbTarefas.Utilitarios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

namespace DbTarefas
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddServerSideBlazor();
			services.AddControllersWithViews(op =>
			{
				op.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(resp => "O campo n�o pode ser nulo!");
				op.ModelBindingMessageProvider.SetValueIsInvalidAccessor(rep => "O campo est� inv�lido");
				op.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "O campo {0} n�o foi preenchido!");
			});

			services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();


			services.AddDbContext<DBContext>();

			services.AddScoped<ITarefa, TarefaRepository>();
			services.AddScoped<IContato, TarefaRepository>();
			services.AddScoped<Validacao>();
			services.AddScoped<Listagem>();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=home}/{action=index}/{id?}");
			});
		}
	}
}
