using System.Linq;
using System.Text.Json.Serialization;

namespace RpgNotes {

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AttributeType {
    String, MultilineString, Number
}

public class Attribute {
    public string Name {get; set;}
    public AttributeType Type {get; set;}
    public string Value {get; set;}
    
    public Attribute Copy() {
        return new Attribute {
            Name = new string(this.Name),
            Type = this.Type,
            Value = new string(this.Value),
        };
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AttributeSectionLayout : int {
    ThreeColumn, TwoColumn, FullWidth, FourColumn 
}
public static class AttributeSectionLayoutMethods {
    public static int GridSize(this AttributeSectionLayout layout) {
        return layout switch {
            AttributeSectionLayout.TwoColumn => 6,
            AttributeSectionLayout.FullWidth => 12,
            AttributeSectionLayout.ThreeColumn => 4,
            AttributeSectionLayout.FourColumn => 3,
            _ => 12
        };
    }
}

public class AttributeSection {
    public string Name {get; set;}
    public AttributeSectionLayout Layout {get; set;}
    public Attribute[] Attributes  {get; set;}

    public AttributeSection Copy() {
        return new AttributeSection {
            Name = new string(this.Name),
            Layout = this.Layout,
            Attributes = this.Attributes.Select(a => a.Copy()).ToArray(),
        };
    }
}

public class AttributesBlock {
    public AttributeSection[] Sections  {get; set;}

    public AttributesBlock Copy() {
        return new AttributesBlock {
            Sections = this.Sections.Select(sec => sec.Copy()).ToArray(),
        };
    }
}

}