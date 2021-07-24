using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RpgNotes.Web.Data {

public class RpgSystem {
    public string Name {get; set;}
    public string Publisher {get; set;}
    public string Description {get; set;}
    public string WebLink {get; set;}
    public RGB ThemeColour {get; set;}
    public Image IconImage {get; set;}
    public AttributesBlock AttributeTemplate {get; set;}
    public override string ToString() => Name;


    public static List<RpgSystem> FindRpgSystems() {
        var type = typeof(ISystemProvider);
        var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => p != null && type.IsAssignableFrom(p) && !p.IsInterface);
        var constructors = types
            .Select(t => t.GetProperty(nameof(ISystemProvider.System), BindingFlags.Static | BindingFlags.Public))
            .Where(p => p != null);
        var systems = constructors
            .Select(con => (RpgSystem)con.GetValue(null, null))
            .Where(sys => sys != null);
        return systems.ToList();
    }
}

}