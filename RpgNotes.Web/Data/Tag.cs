using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public class Tag {
    public string Name {get; set;}
    public RGB Colour {get; set;}

    public override bool Equals(object obj) {
        if (obj == null || GetType() != obj.GetType()) {
            return false;
        }
        
        return this.Name == ((Tag)obj).Name;
    }
    
    // override object.GetHashCode
    public override int GetHashCode() {
        return Name.GetHashCode();
    }
}

}