namespace RpgNotes.Web.Data {

public class Image {
    public string Url {get; set;}

    public static Image FromUrl(string url) {
        return new Image{
            Url = url
        };
    }

    public static Image FromData(byte[] bytes) {
        var base64 = System.Convert.ToBase64String(bytes);
        return new Image{
            Url = $"data:image/png;base64, {base64}"
        };
    }
    public static Image FromDataUrl(string uri) {
        return new Image{
            Url = uri
        };
    }
}

}