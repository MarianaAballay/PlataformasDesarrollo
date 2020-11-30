#pragma checksum "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e8f44937507180dc06a6dace9263099f020e05"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Usuarios
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
#line 3 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuarios/EditarUsuario/{id:int}")]
    public partial class EditarUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
       
    [Parameter]
    public int id { get; set; }

    public Usuario Usuario { get; set; } = new Usuario();

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
        {
            Usuario = await UsuarioServicio.Get(id);
        }
        else
        {
            Usuario = new Usuario();
        }
    }


    private async void Guardar()
    {
        await UsuarioServicio.SaveUsuario(Usuario);
        navigation.NavigateTo("Usuarios/ListadoUsuarios");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServicio UsuarioServicio { get; set; }
    }
}
#pragma warning restore 1591
