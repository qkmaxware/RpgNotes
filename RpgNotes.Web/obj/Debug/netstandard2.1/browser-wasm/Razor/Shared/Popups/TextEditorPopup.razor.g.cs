#pragma checksum "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a90496690dd3467e61805f94f14850a6c80f550"
// <auto-generated/>
#pragma warning disable 1591
namespace RpgNotes.Web.Shared.Popups
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
    public partial class TextEditorPopup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<RpgNotes.Web.Shared.Modal>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 1 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor"
                         Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<RpgNotes.Web.Shared.Input.MultilineTextInput>(4);
                __builder2.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 2 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor"
                             input = (RpgNotes.Web.Shared.Input.MultilineTextInput)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "w3-padding w3-center");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "button");
                __builder2.AddAttribute(11, "class", "w3-green w3-button");
                __builder2.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor"
                                                    save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(13, "Update");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 1 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor"
            modal = (RpgNotes.Web.Shared.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "F:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\TextEditorPopup.razor"
       
    [Parameter] public string Title {get; set;}
    private Modal modal;
    private MultilineTextInput input;

    [Parameter] public Func<string> Getter {get; set;}
    [Parameter] public Action<string> Setter {get; set;}

    public void Open() {
        if (Getter != null && input != null) {
            input.Value = Getter();
        }
        modal?.Open();
    }

    private void save() {
        Setter?.Invoke(input?.Value ?? string.Empty);
        modal?.Close();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
