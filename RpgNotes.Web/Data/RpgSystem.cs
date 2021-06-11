namespace RpgNotes.Web.Data {

public class RpgSystem {
    public string Name {get; set;}
    public string Publisher {get; set;}
    public string Description {get; set;}
    public string WebLink {get; set;}
    public RGB ThemeColour {get; set;}
    public Image IconImage {get; set;}


    public override string ToString() => Name;
}

}