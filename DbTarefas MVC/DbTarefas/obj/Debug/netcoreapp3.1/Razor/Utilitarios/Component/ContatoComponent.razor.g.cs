#pragma checksum "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\ContatoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252da62c89da6602eaf8c466b693bcbea005f7b3"
// <auto-generated/>
#pragma warning disable 1591
namespace DbTarefas.Utilitarios.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ContatoComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "custom-file");
            __builder.AddAttribute(2, "style", "background-color:darkgray;display:flex;justify-content:center; align-content:center; padding:10px;align-items:center; flex-direction:column; margin:30px; width:100%; height:200px;");
            __builder.AddMarkupContent(3, "\r\n\t\t");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 5 "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\ContatoComponent.razor"
                                                        parametro

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "placeholder", "Cadastre um novo contato");
            __builder.AddAttribute(9, "id", "parametro");
            __builder.AddAttribute(10, "name", "parametro");
            __builder.AddAttribute(11, "style", "width:400px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\t\t");
            __builder.AddMarkupContent(13, "<button id=\"contatoBotao\" type=\"submit\" class=\"ctf-btn\">Registrar</button>\r\n\t");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\ContatoComponent.razor"
       
	[Parameter]
	public string parametro { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
