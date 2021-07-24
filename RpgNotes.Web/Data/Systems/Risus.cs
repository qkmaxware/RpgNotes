namespace RpgNotes.Web.Data.Systems {

public class Risus : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Risus",
        Publisher = "S. John Ross and Dave LeCompte",
        ThemeColour = new RGB(131, 37, 125),
        Description = "",
        WebLink = "https://www.drivethrurpg.com/product/170294/Risus-The-Anything-RPG",
        IconImage = Image.FromUrl("logos/risus.svg"),
    };
}

}