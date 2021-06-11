#pragma checksum "f:\C# Projects\RpgNotes\RpgNotes.Web\Pages\ListItems.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78c50322843bd22a52554867e83186cc87e43ef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RpgNotes.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Shared.Input;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "f:\C# Projects\RpgNotes\RpgNotes.Web\_Imports.razor"
using RpgNotes.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "f:\C# Projects\RpgNotes\RpgNotes.Web\Pages\ListItems.razor"
using RpgNotes.Web.Shared.Popups;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/campaign/{id:int}/items")]
    public partial class ListItems : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "f:\C# Projects\RpgNotes\RpgNotes.Web\Pages\ListItems.razor"
       
    private string filter;
    [Parameter] public int id { get; set; }
    public Campaign Campaign => Data.Campaigns == null ? null : Data.Campaigns.ElementAtOrDefault(id);

    private bool matchesFilter(Entry entry) {
        return string.IsNullOrEmpty(filter) || entry.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    protected override void OnInitialized() {
        base.OnInitialized();
        var c = Campaign;
        if (c != null && c.Entries == null) {
            c.Entries = new EntryCollection();
        }
    }

    private void openEntity(Entry entry) {
        var eid = Campaign.Entries.GuidOf(entry);
        Nav.NavigateTo($"campaign/{id}/entries/{eid}");
    }

    private NewEntry newEntity;
    private void openCreator() {
        newEntity?.Open();
    }

    private void addEntry(Entry entry) {
        entry.ItemData = new ItemData();
        Campaign.Entries.Add(entry);
        openEntity(entry);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private History Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData Data { get; set; }
    }
}
#pragma warning restore 1591
