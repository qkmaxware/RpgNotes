using System;
using Microsoft.JSInterop;

namespace RpgNotes.Web {

public class BrowserLocalDataStore {

    private IJSRuntime js;

    public BrowserLocalDataStore(IJSRuntime runtime) {
        this.js = runtime;
    }
    
    public void Save<T> (string key, T data) {
        var json = System.Text.Json.JsonSerializer.Serialize<T>(data);
        js.InvokeVoidAsync("BlazorWriteLocalStorage", key, json);
    }
    
    public  T Load<T> (string key) {
        var task = js.InvokeAsync<string>("BlazorReadLocalStorage", key).AsTask();
        task.Wait();
        var json = task.Result;
        return System.Text.Json.JsonSerializer.Deserialize<T>(json);
    }
}

}