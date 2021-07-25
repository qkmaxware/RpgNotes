namespace RpgNotes.Web.Data.Systems {

public class CallOfCthulhu : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Call of Cthulhu",
        Publisher = "Chaosium Inc.",
        ThemeColour = new RGB(0, 0, 0),
        Description = "",
        WebLink = "https://www.chaosium.com/call-of-cthulhu-rpg/",
        IconImage = Image.FromUrl("logos/cthulhu.svg"),
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
                            Name = "Pow",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Con",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "App",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Edu",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Siz",
                            Type = AttributeType.Number,
                            Value = "0",
                        },
                        new Attribute {
                            Name = "Int",
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