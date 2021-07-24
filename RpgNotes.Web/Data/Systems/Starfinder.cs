namespace RpgNotes.Web.Data.Systems {

public class Starfinder : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Starfinder",
            Publisher = "Paizo",
            ThemeColour = new RGB(36, 163, 231),
            Description = "",
            WebLink = "https://paizo.com/pathfinder",
            IconImage = Image.FromUrl("logos/starfinder.svg"),
    };
}

}