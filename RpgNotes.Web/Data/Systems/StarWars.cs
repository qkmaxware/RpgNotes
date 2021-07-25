namespace RpgNotes.Web.Data.Systems {

public class StarWars : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Star Wars the Roleplaying Game",
        Publisher = "Fantasy Flight Games",
        ThemeColour = new RGB(255, 197, 0),
        Description = "",
        WebLink = "https://www.fantasyflightgames.com/en/products/star-wars-the-roleplaying-game-30th-anniversary-edition/",
        IconImage = Image.FromUrl("logos/sw.svg"),
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