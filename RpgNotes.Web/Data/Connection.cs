using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public enum ConnectionMember {
    To, From
}

public class Connection {
    public string From {get; set;}
    public string To {get; set;}

    public string ForwardRelation {get; set;}
    public string ReverseRelation {get; set;}

    public bool IsLocationBased {get; set;}
    public ConnectionMember MapEntity {get; set;}
    public PositionMarker Position {get; set;}

    public string RelationshipStringFor(string guid) {
        if (guid == From) {
            return ForwardRelation;
        } else if (guid == To) {
            return ReverseRelation;
        } else {
            return string.Empty;
        }
    }

    public string GetOtherParticipant(string guid) {
        if (guid == From) {
            return To;
        } else if (guid == To) {
            return From;
        } else {
            return string.Empty;
        }
    }

    public bool Participates(string guid) {
        return From == guid || To == guid;
    }

    public static Connection InARelationshipWith(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "In a relationship with",
            ReverseRelation = "In a relationship with",
        };
    }
    public static Connection ParentOf(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Parent of",
            ReverseRelation = "Child of",
        };
    }

    public static Connection FriendsWith(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Friends with",
            ReverseRelation = "Friends with",
        };
    }
    public static Connection RivalOf(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Rivals with",
            ReverseRelation = "Rivals with",
        };
    }

    public static Connection OwnerOf(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Owner of",
            ReverseRelation = "Owned by",
        };
    }
    public static Connection LeaderOf(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Leader of",
            ReverseRelation = "Is lead by",
        };
    }

    public static Connection LocatedIn(string x, string y) {
        return new Connection {
            IsLocationBased = true,
            From = x, To = y,
            ForwardRelation = "Located in",
            ReverseRelation = "Contains",
        };
    }

    public static Connection Contains(string x, string y) {
        return new Connection {
            From = x, To = y,
            ForwardRelation = "Contains",
            ReverseRelation = "Contained in",
        };
    }
}

}