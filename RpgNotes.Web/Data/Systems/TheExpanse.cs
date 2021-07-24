namespace RpgNotes.Web.Data.Systems {

public class TheExpanse : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "The Expanse Roleplaying Game",
        Publisher = "Green Ronin Publishing",
        ThemeColour = new RGB(255, 255, 255),
        Description = "",
        WebLink = "https://greenroninstore.com/collections/the-expanse-rpg",
        IconImage = Image.FromUrl("logos/expanse.svg"),
    };
}

}