using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public class CharacterData {
    public bool IsDead {get; set;}
    public string Species {get; set;}
    public int? Age {get; set;}
}
public class QuestData {
    public bool IsComplete {get; set;}
}
public class LocationData {}
public class WorldData {}
public class FactionData {}
public class ItemData {}

public class Entry {
    public string Name {get; set;}
    public string Description {get; set;}
    public string Notes {get; set;}
    public List<string> Tags {get; set;}
    public List<Image> Images {get; set;}

    // Specific data
    public CharacterData CharacterData {get; set;}
    public QuestData QuestData {get; set;}
    public LocationData LocationData {get; set;}
    public WorldData WorldData {get; set;}
    public FactionData FactionData {get; set;}
    public ItemData ItemData {get; set;}
}

}