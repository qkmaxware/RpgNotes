using System;
using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public class Campaign {
    public string Name {get; set;}
    public RpgSystem System {get; set;}
    public bool IsArchived {get; set;}
    public DateTime CreatedAt {get; set;}

    // Metadata
    public List<Tag> Tags {get; set;}

    // Saved Notes
    public EntryCollection Entries {get; set;}
}

}