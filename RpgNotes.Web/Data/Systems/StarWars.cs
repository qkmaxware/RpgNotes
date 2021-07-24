namespace RpgNotes.Web.Data.Systems {

public class StarWars : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Star Wars the Roleplaying Game",
        Publisher = "Fantasy Flight Games",
        ThemeColour = new RGB(255, 197, 0),
        Description = "",
        WebLink = "https://www.fantasyflightgames.com/en/products/star-wars-the-roleplaying-game-30th-anniversary-edition/",
        IconImage = Image.FromUrl("logos/sw.svg"),
    };
}

}