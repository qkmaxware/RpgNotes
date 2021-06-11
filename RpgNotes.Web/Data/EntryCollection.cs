using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace RpgNotes.Web.Data {

public class EntryCollection {
    public Dictionary<string, Entry> Items {get; set;}
    public List<Connection> Connections {get; set;}

    public Entry this[string guid] {
        get => Items[guid];
        set => Items[guid] = value;
    }
    public Entry EntryOrDefault(string guid) {
        Entry entry;
        if (Items == null)
            return default(Entry);
        if (Items.TryGetValue(guid, out entry)) {
            return entry;
        } else {
            return default(Entry);
        }
    }

    public void Add(Entry entry) {
        if (Items == null) {
            Items = new Dictionary<string, Entry>();
        }

        var guid = Guid.NewGuid().ToString();
        Items.Add(guid, entry);
    }

    public void Connect(Connection connection) {
        if (Connections == null){
            Connections = new List<Connection>();
        }

        Connections.Add(connection);
    }

    public void Remove (Entry entry) {
        if (Items != null) {
            var key = GuidOf(entry);
            Remove(key);
        }
    }
    public void Remove (string guid) {
        if (Items != null) {
            this.Items.Remove(guid);
            if (this.Connections != null) {
                this.Connections.RemoveAll((conn) => conn.Participates(guid));
            }
        }
    }

    public void Disconnect(Connection connection) {
        if (Connections != null) {
            Connections.Remove(connection);
        }
    }

    public string GuidOf(Entry entry) {
        return Items.First(x => x.Value == entry).Key;
    }

    public IEnumerable<Entry> Enumerate() {
        if (Items == null) {
            return Enumerable.Empty<Entry>();
        } else {
            return Items.Values;
        }
    }

    public IEnumerable<Connection> EnumerateConnections(Entry entry) {
        if (Connections == null) {
            return Enumerable.Empty<Connection>();
        } else {
            var guid = GuidOf(entry);
            return Connections.Where(conn => conn.Participates(guid));
        }
    }
}

}