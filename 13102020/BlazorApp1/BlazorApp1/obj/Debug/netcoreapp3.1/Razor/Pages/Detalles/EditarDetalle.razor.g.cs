#pragma checksum "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8b35cd2aaeedc844178d53b662e822fb090bf2d"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 3 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
using ClassLibrary1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/detalles/editardetalle/{id:int}")]
    public partial class EditarDetalle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Editar Detalle</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                  Detalle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                                           Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<label class=\"text-center\">Ingrese la fecha: </label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                            Detalle.fecha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Detalle.fecha = __value, Detalle.fecha))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Detalle.fecha));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.AddMarkupContent(16, "<label class=\"text-center\">Ingrese el tiempo en días: </label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                            Detalle.tiempo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Detalle.tiempo = __value, Detalle.tiempo))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Detalle.tiempo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    Recurso:\r\n    ");
                __Blazor.BlazorApp1.Pages.Detalles.EditarDetalle.TypeInference.CreateInputSelect_0(__builder2, 22, 23, 
#nullable restore
#line 20 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                              RecursoID

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecursoID = __value, RecursoID)), 25, () => RecursoID, 26, (__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n        ");
                    __builder3.AddMarkupContent(28, "<option value=\"0\">Elegir un Recurso</option>\r\n");
#nullable restore
#line 22 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
         foreach (var R in Recursos)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(29, "            ");
                    __builder3.OpenElement(30, "option");
                    __builder3.AddAttribute(31, "value", 
#nullable restore
#line 24 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                            R.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(32, 
#nullable restore
#line 24 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                                   R.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n");
#nullable restore
#line 25 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(34, "    ");
                }
                );
                __builder2.AddMarkupContent(35, "\r\n    Tarea:\r\n    ");
                __Blazor.BlazorApp1.Pages.Detalles.EditarDetalle.TypeInference.CreateInputSelect_1(__builder2, 36, 37, 
#nullable restore
#line 28 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                              TareaID

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TareaID = __value, TareaID)), 39, () => TareaID, 40, (__builder3) => {
                    __builder3.AddMarkupContent(41, "\r\n        ");
                    __builder3.AddMarkupContent(42, "<option value=\"0\">Elegir una Tarea</option>\r\n");
#nullable restore
#line 30 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
         foreach (var T in Tareas)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(43, "            ");
                    __builder3.OpenElement(44, "option");
                    __builder3.AddAttribute(45, "value", 
#nullable restore
#line 32 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                            T.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(46, 
#nullable restore
#line 32 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
                                   T.Titulo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n");
#nullable restore
#line 33 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "    ");
                }
                );
                __builder2.AddMarkupContent(49, "\r\n\r\n    ");
                __builder2.AddMarkupContent(50, "<button class=\"btn-outline-primary\" type=\"submit\">Guardar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\aball\source\repos\PlataformasDesarrollo\13102020\BlazorApp1\BlazorApp1\Pages\Detalles\EditarDetalle.razor"
       
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
namespace __Blazor.BlazorApp1.Pages.Detalles.EditarDetalle
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
