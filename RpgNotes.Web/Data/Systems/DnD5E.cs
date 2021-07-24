namespace RpgNotes.Web.Data.Systems {

public class DnD5E : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "D&D 5E",
        Publisher = "Wizards of the Coast",
        ThemeColour = new RGB(255, 0, 0),
        Description = "",
        WebLink = "https://dnd.wizards.com/",
        IconImage = Image.FromUrl("logos/dnd.svg"),
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