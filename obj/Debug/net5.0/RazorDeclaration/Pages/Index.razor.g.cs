// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTodoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using BlazorTodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/_Imports.razor"
using BlazorTodoApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "/home/vrsingireddy/projects/Blazor/BlazorTodoApp/Pages/Index.razor"
 
    public string todoInput {get; set;}
    public List<string> todos = new List<string>();

    public void AddTodo()
    {
        //Console.WriteLine(todoInput);
        todos.Add(todoInput);
        todoInput = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
