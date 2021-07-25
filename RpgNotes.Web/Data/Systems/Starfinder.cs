namespace RpgNotes.Web.Data.Systems {

public class Starfinder : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Starfinder",
        Publisher = "Paizo",
        ThemeColour = new RGB(36, 163, 231),
        Description = "",
        WebLink = "https://paizo.com/pathfinder",
        IconImage = Image.FromUrl("logos/starfinder.svg"),
        AttributeTemplate = new AttributesBlock {
            Sections = new AttributeSection[]{
                new AttributeSection {
                    Name = "Abilities",
                    Layout = AttributeSectionLayout.ThreeColumn,
                    Attributes = new Attribute[]{
                        new Attribute {
                            Name = "Str",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Dex",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Con",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Int",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Wis",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Cha",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                    }
                }
            }
        }
    };
}

}