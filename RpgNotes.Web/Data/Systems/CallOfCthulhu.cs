namespace RpgNotes.Web.Data.Systems {

public class CallOfCthulhu : ISystemProvider {
    public static RpgSystem System => new RpgSystem {
        Name = "Call of Cthulhu",
        Publisher = "Chaosium Inc.",
        ThemeColour = new RGB(0, 0, 0),
        Description = "",
        WebLink = "https://www.chaosium.com/call-of-cthulhu-rpg/",
        IconImage = Image.FromUrl("logos/cthulhu.svg"),
    };
}

}