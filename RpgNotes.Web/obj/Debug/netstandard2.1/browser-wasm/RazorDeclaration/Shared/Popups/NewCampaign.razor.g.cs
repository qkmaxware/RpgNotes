#pragma checksum "f:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\NewCampaign.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4708207c483fecae1e990cb652f8d2318daf710"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RpgNotes.Web.Shared.Popups
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
    public partial class NewCampaign : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "f:\C# Projects\RpgNotes\RpgNotes.Web\Shared\Popups\NewCampaign.razor"
       
    [Parameter] public Action OnCreate {get; set;}
    private Modal modal;
    private DropdownSelect<RpgSystem> system;
    private TextInput campaignName = null;
    public Campaign GeneratedCampaign => new Campaign {
        Name = campaignName?.Value,
        System = system?.Selected,
        CreatedAt = DateTime.Now,
    };
    private bool hasSystem => system?.Selected != null;
    private string conditionCss => hasSystem && !string.IsNullOrEmpty(campaignName?.Value) ? "w3-green" : "w3-dark-grey";

    public void Open() {
        modal?.Open();
        StateHasChanged();
    }

    private void create() {
        if (system?.Selected == null || string.IsNullOrEmpty(campaignName?.Value))
            return;

        var campaign = GeneratedCampaign;
        if (Data.Campaigns == null)
            Data.Campaigns = new List<Campaign>();
        Data.Campaigns.Add(campaign);
        modal?.Close();
        OnCreate?.Invoke();
    }   

    private static List<RpgSystem> systems = new List<RpgSystem> {
        new RpgSystem {
            Name = "D&D 5E",
            Publisher = "Wizards of the Coast",
            ThemeColour = new RGB(255, 0, 0),
            Description = "",
            WebLink = "https://dnd.wizards.com/",
            IconImage = Image.FromUrl("logos/dnd.svg"),
        },
        new RpgSystem {
            Name = "Pathfinder",
            Publisher = "Paizo",
            ThemeColour = new RGB(225, 218, 145),
            Description = "",
            WebLink = "https://paizo.com/pathfinder",
            IconImage = Image.FromUrl("logos/pathfinder.svg"),
        },
        new RpgSystem {
            Name = "Starfinder",
            Publisher = "Paizo",
            ThemeColour = new RGB(36, 163, 231),
            Description = "",
            WebLink = "https://paizo.com/pathfinder",
            IconImage = Image.FromUrl("logos/starfinder.svg"),
        },
        new RpgSystem {
            Name = "Star Trek Adventures",
            Publisher = "Mōdiphiüs Entertainment",
            ThemeColour = new RGB(192, 198, 199),
            Description = "",
            WebLink = "https://www.modiphius.net/collections/star-trek-adventures",
            IconImage = Image.FromUrl("logos/sta.svg"),
        },
        new RpgSystem {
            Name = "Dungeon World",
            Publisher = "Sage LaTorra and Adam Koebel",
            ThemeColour = new RGB(106, 126, 114),
            Description = "",
            WebLink = "https://dungeon-world.com/",
            IconImage = Image.FromUrl("logos/dw.svg"),
        },
        new RpgSystem {
            Name = "Star Wars the Roleplaying Game",
            Publisher = "Fantasy Flight Games",
            ThemeColour = new RGB(255, 197, 0),
            Description = "",
            WebLink = "https://www.fantasyflightgames.com/en/products/star-wars-the-roleplaying-game-30th-anniversary-edition/",
            IconImage = Image.FromUrl("logos/sw.svg"),
        },
        new RpgSystem {
            Name = "Fate",
            Publisher = "Evil Hat Productions",
            ThemeColour = new RGB(128, 153, 207),
            Description = "",
            WebLink = "https://www.evilhat.com/home/fate-core/",
            IconImage = Image.FromUrl("logos/fate.svg"),
        },
        new RpgSystem {
            Name = "Other",
            Publisher = "Many",
            ThemeColour = new RGB(255, 255, 255),
            Description = "",
            WebLink = "",
            IconImage = Image.FromUrl("logos/generic.svg"),
        },
    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppData Data { get; set; }
    }
}
#pragma warning restore 1591
