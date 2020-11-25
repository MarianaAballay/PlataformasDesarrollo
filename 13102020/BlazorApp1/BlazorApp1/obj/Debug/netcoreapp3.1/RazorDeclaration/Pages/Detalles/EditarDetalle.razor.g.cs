#pragma checksum "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2eb07afd8478f48b91bc35db0c3c5c0780819af"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Detalles
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
#line 2 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detalles/editardetalle/{id:int}")]
    public partial class EditarDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Detalle Detalle { get; set; } = new Detalle();

    public string RecursoID { get; set; }

    public string TareaID { get; set; }

    private List<Recurso> Recursos = new List<Recurso>();
    private List<Tarea> Tareas = new List<Tarea>();


    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Detalle = await DetalleServicio.Get(Id);
            RecursoID = Detalle.recurso.ToString();
            TareaID = Detalle.tarea.ToString();
        }
        else
        {
            Detalle = new Detalle();

        }
        Recursos = await RecursoServicio.GetAllRecurso();
        Tareas = await TareaServicio.GetAllTarea();
    }


    private async void Guardar()
    {
        Detalle.recursoId = int.Parse(RecursoID);
        Detalle.tareaId = int.Parse(TareaID);
        await DetalleServicio.SaveDetalle(Detalle);
        navigation.NavigateTo("Detalles/Detalles");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareaServicio TareaServicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursoServicio RecursoServicio { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleServicio DetalleServicio { get; set; }
    }
}
#pragma warning restore 1591
