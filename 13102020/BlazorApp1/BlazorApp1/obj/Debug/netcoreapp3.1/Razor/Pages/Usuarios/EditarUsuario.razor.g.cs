#pragma checksum "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1349abd2adada98a6ccceb75fc2cf2e09ca2b44e"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 4 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
using ClassLibrary1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuarios/EditarUsuario/{id:int}")]
    public partial class EditarUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Editar Usuario</h1>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
                      Usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
                                               Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label class=\"text-center\">Ingrese el nombre: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
                                Usuario.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.nombre = __value, Usuario.nombre))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.AddMarkupContent(16, "<label class=\"text-center\">Ingrese la clave: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
                                Usuario.clave

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.clave = __value, Usuario.clave))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.clave));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n\r\n        ");
                __builder2.AddMarkupContent(22, "<button class=\"btn-outline-primary\" type=\"submit\">Guardar</button>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Usuarios\EditarUsuario.razor"
           
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
