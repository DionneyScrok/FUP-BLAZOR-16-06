#pragma checksum "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c63cec2a512af99351ee59bd61673c360b6bbd"
// <auto-generated/>
#pragma warning disable 1591
namespace Teste_Piloto.Client.Pages.Chefias
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class PageDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 1 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                      Chefia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 1 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                                OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "\n            ");
                __builder2.OpenElement(8, "h3");
                __builder2.AddContent(9, " ");
                __builder2.AddMarkupContent(10, "<strong>Nome: </strong> ");
                __builder2.AddContent(11, 
#nullable restore
#line 3 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                          Chefia.NomeChefia

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\n            ");
                __builder2.OpenElement(18, "h3");
                __builder2.AddContent(19, " ");
                __builder2.AddMarkupContent(20, "<strong> Setor: </strong> ");
                __builder2.AddContent(21, 
#nullable restore
#line 6 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                            Chefia.Setor

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(22, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.OpenElement(28, "h3");
                __builder2.AddContent(29, " ");
                __builder2.AddMarkupContent(30, "<strong> Email: </strong> ");
                __builder2.AddContent(31, 
#nullable restore
#line 9 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                            Chefia.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(32, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "form-group");
                __builder2.AddMarkupContent(37, "\n            ");
                __builder2.OpenElement(38, "h3");
                __builder2.AddContent(39, " ");
                __builder2.AddMarkupContent(40, "<strong> Telefone: </strong> ");
                __builder2.AddContent(41, 
#nullable restore
#line 12 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                               Chefia.Telefone

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(42, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        \n        ");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "type", "submit");
                __builder2.AddAttribute(47, "class", "btn btn-primary");
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                                                OnValidSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(49, 
#nullable restore
#line 15 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
                                                                                ButtonText

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\dionn\source\repos\Trabalho Arrumar Financeiro 14,06\Blazor-masterHoje\Teste_Piloto\Client\Pages\Chefias\PageDetails.razor"
 
    [Parameter] public Chefia Chefia { get; set; }
    [Parameter] public string ButtonText { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
