using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public class AppData {
    public List<Campaign> Campaigns {get; set;}

    public void Overwrite(AppData Data) {
        this.Campaigns = Data.Campaigns;
    }
}

}