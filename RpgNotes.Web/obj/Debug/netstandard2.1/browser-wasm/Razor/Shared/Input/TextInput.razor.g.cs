#pragma checksum "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Input\TextInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65bcfc80c38d494bbd33828df0ef8603670a3dba"
// <auto-generated/>
#pragma warning disable 1591
namespace RpgNotes.Web.Shared.Input
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
    public partial class TextInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "w3-margin-bottom");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddContent(4, 
#nullable restore
#line 2 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Input\TextInput.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "w3-input darker");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Input\TextInput.razor"
                                                     Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Value = __value, Value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Input\TextInput.razor"
       
    [Parameter] public string Label {get; set;}
    public string Value {get; set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
