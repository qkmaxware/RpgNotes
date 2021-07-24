namespace RpgNotes.Web.Data.Systems {

public class Fate : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Fate",
        Publisher = "Evil Hat Productions",
        ThemeColour = new RGB(128, 153, 207),
        Description = "",
        WebLink = "https://www.evilhat.com/home/fate-core/",
        IconImage = Image.FromUrl("logos/fate.svg"),
    };
}

}