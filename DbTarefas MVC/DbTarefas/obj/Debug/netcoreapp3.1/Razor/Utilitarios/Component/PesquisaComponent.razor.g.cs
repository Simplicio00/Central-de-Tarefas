#pragma checksum "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\PesquisaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd7e9ce581421aa3cb236f575a2b1b29d6cc5f5f"
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
    public partial class PesquisaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "md-form active-cyan active-cyan-2 mb-3");
            __builder.AddAttribute(2, "style", "width: 100%; display:flex;justify-content:center;");
            __builder.AddMarkupContent(3, "\r\n\t<img style=\"width:50px;\" src=\"http://localhost:5000/img/ipesc.png\">\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "id", "pesquisa");
            __builder.AddAttribute(7, "name", "pesquisa");
            __builder.AddAttribute(8, "value", 
#nullable restore
#line 3 "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\PesquisaComponent.razor"
                                                                      pesquisa

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "style", "width:80%; height:40px;");
            __builder.AddAttribute(11, "placeholder", "Pesquisar por uma tarefa");
            __builder.AddAttribute(12, "aria-label", "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<button type=\"submit\" style=\"width:60px; height:40px; border:none; color:white; background:darkblue;\"> > </button>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Acer\Desktop\Código\Central-de-Tarefas\DbTarefas MVC\DbTarefas\Utilitarios\Component\PesquisaComponent.razor"
      

    [Parameter]
    public string pesquisa { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591