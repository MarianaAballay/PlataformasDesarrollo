#pragma checksum "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9657801deac20450712472265e3ca8a5a20ae2be"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Tareas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tareas/ListadoTareas")]
    public partial class ListadoTarea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado De Tareas</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-info");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                                       ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 13 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
 if (tareas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<p>Cargando...</p>\r\n");
#nullable restore
#line 16 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.AddMarkupContent(12, @"<thead class=""thead-dark"">
            <tr>
                <th>Id</th>
                <th>Titulo</th>
                <th>Vencimiento</th>
                <th>Estimacion</th>
                <th>Responsable</th>
                <th>Acciones</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(13, "tbody");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 31 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
             foreach (var T in tareas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 34 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                     T.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 35 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                     T.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 36 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                     T.Vencimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                     T.Estimacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 38 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                     T.Responsable.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                                                              ()=>Editar(T.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Editar");
            __builder.CloseElement();
            __builder.AddContent(38, " ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
                                                                                                                                         ()=>Borrar(T.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 41 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 44 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoTarea.razor"
       


    private List<Tarea> tareas;

    protected override async Task OnInitializedAsync()
    {
        tareas = await TareaServicio.GetAllTarea();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/Tareas/EditarTarea/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "¿Desea eliminar tarea?");
        if (confirmed)
        {
            await TareaServicio.Remove(id);
            tareas = await TareaServicio.GetAllTarea();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaServicio TareaServicio { get; set; }
    }
}
#pragma warning restore 1591