using Microsoft.AspNetCore.Components;

namespace RpgNotes.Web {

public class History {
    public string Uri => nav.Uri;
    public string BaseUri => nav.BaseUri;

    private NavigationManager nav;
    private string lastPage;
    public History(NavigationManager nav) {
        this.nav = nav;
    }

    public void Home() {
        this.nav.NavigateTo(string.Empty);
    }

    public void NavigateTo(string path, bool noHistory=false, bool forceLoad=false) {
        if (!noHistory) {
            lastPage = nav.Uri;
        }
        nav.NavigateTo(path, forceLoad);
    }

    public void Back() {
        if (!string.IsNullOrEmpty(lastPage)) {
            nav.NavigateTo(lastPage);
        }
    }
    public void BackOrDefault(string path) {
        if (!string.IsNullOrEmpty(lastPage)) {
            nav.NavigateTo(lastPage);
            lastPage = null;
        } else {
            nav.NavigateTo(path);
        }
    }
}

}