namespace RpgNotes.Web.Data.Systems {

public class TheExpanse : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "The Expanse Roleplaying Game",
        Publisher = "Green Ronin Publishing",
        ThemeColour = new RGB(255, 255, 255),
        Description = "",
        WebLink = "https://greenroninstore.com/collections/the-expanse-rpg",
        IconImage = Image.FromUrl("logos/expanse.svg"),
        AttributeTemplate = new AttributesBlock {
            Sections = new AttributeSection[] {
                new AttributeSection {
                    Name = "Abilities",
                    Layout = AttributeSectionLayout.TwoColumn,
                    Attributes = new Attribute[] {
                        new Attribute {
                            Name = "Accuracy",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Communication",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Constitution",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Dexterity",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Fighting",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Intelligence",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Perception",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Strength",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name = "Willpower",
                            Type = AttributeType.Number,
                            Value = "0"
                        }
                    }
                }
            }
        }
    };
}

}