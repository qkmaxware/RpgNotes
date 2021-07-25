namespace RpgNotes.Web.Data.Systems {

public class DungeonWorld : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Dungeon World",
        Publisher = "Sage LaTorra and Adam Koebel",
        ThemeColour = new RGB(106, 126, 114),
        Description = "",
        WebLink = "https://dungeon-world.com/",
        IconImage = Image.FromUrl("logos/dw.svg"),
        AttributeTemplate = new AttributesBlock {
            Sections = new AttributeSection[]{
                new AttributeSection {
                    Name = "Attributes",
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