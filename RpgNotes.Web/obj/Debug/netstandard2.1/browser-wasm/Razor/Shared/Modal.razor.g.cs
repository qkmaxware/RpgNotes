#pragma checksum "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7726e5a0d8db16847fa1d5d507a9517a59d1564"
// <auto-generated/>
#pragma warning disable 1591
namespace RpgNotes.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Shared.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Data;

#line default
#line hidden
#nullable disable
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w3-modal" + " " + (
#nullable restore
#line 1 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor"
                      css

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "w3-modal-content");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "dark");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "darkest w3-xlarge w3-padding");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddContent(12, 
#nullable restore
#line 5 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor"
                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "w3-button w3-display-topright");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor"
                                                                     Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "w3-padding");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddContent(23, 
#nullable restore
#line 9 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Modal.razor"
       
    [Parameter] public string Title {get; set;}
    [Parameter] public Action OnOpen {get; set;}
    [Parameter] public Action OnClose {get; set;}
    [Parameter] public RenderFragment ChildContent {get; set;}

    public bool Show {get; private set;} = false;
    private string css => Show ? "w3-show" : "w3-hide";

    public void Open() {
        Show = true;
        StateHasChanged();
        OnOpen?.Invoke();
    }

    public void Close() {
        Show = false;
        StateHasChanged();
        OnClose?.Invoke();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
