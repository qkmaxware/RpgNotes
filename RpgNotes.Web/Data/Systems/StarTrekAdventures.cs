namespace RpgNotes.Web.Data.Systems {

public class StarTrekAdventures : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Star Trek Adventures",
        Publisher = "Mōdiphiüs Entertainment",
        ThemeColour = new RGB(192, 198, 199),
        Description = "",
        WebLink = "https://www.modiphius.net/collections/star-trek-adventures",
        IconImage = Image.FromUrl("logos/sta.svg"),
        AttributeTemplate = new AttributesBlock {
            Sections = new AttributeSection[] {
                new AttributeSection {
                    Name = "Attributes",
                    Layout = AttributeSectionLayout.ThreeColumn,
                    Attributes = new Attribute[]{
                        new Attribute {
                            Name="Control",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Fitness",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Presence",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Daring",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Insight",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Reason",
                            Type = AttributeType.Number,
                            Value = "0"
                        }
                    }
                },
                new AttributeSection {
                    Name = "Disciplines",
                    Layout = AttributeSectionLayout.ThreeColumn,
                    Attributes = new Attribute[]{
                        new Attribute {
                            Name="Command",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Security",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Science",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Conn",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Engineering",
                            Type = AttributeType.Number,
                            Value = "0"
                        },
                        new Attribute {
                            Name="Medicine",
                            Type = AttributeType.Number,
                            Value = "0"
                        }
                    }
                },
                /*new AttributeSection {
                    Name = "Focuses",
                    Layout = AttributeSectionLayout.FullWidth,
                    Attributes = new Attribute[]{
                        new Attribute {
                            Name="",
                            Type = AttributeType.MultilineString,
                            Value = ""
                        },
                    }
                },
                new AttributeSection {
                    Name = "Talents",
                    Layout = AttributeSectionLayout.FullWidth,
                    Attributes = new Attribute[]{
                        new Attribute {
                            Name="",
                            Type = AttributeType.MultilineString,
                            Value = ""
                        },
                    }
                },*/
            }
        }
    };
}

}