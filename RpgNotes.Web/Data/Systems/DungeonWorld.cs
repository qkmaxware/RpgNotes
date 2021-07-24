namespace RpgNotes.Web.Data.Systems {

public class DungeonWorld : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Dungeon World",
        Publisher = "Sage LaTorra and Adam Koebel",
        ThemeColour = new RGB(106, 126, 114),
        Description = "",
        WebLink = "https://dungeon-world.com/",
        IconImage = Image.FromUrl("logos/dw.svg"),
    };
}

}