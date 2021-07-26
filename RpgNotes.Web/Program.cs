using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using RpgNotes.Web.Data;
using Microsoft.AspNetCore.Components;

namespace RpgNotes.Web
{
    public class Program {
        private static AppData Data;
        private static BrowserLocalDataStore Loader;
        private static IJSRuntime JS;

        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<AppData>();
            builder.Services.AddSingleton<BrowserLocalDataStore>((provider) => new BrowserLocalDataStore(provider.GetService<IJSRuntime>()));
            builder.Services.AddSingleton<History>((provider) => new History(provider.GetService<NavigationManager>()));

            var build = builder.Build();

            Data = build.Services.GetService<AppData>();
            Loader = build.Services.GetService<BrowserLocalDataStore>();
            JS = build.Services.GetService<IJSRuntime>();

            await ReloadPersistedSession();
            await build.RunAsync();
        }

        [JSInvokable]
        public static async Task DownloadAppData(AppData data = null) {
            data = data ?? Program.Data;
            if (data == null || JS == null)
                return;

            var filename = "notes";
            await DownloadJsonData(filename, data);
        }
        public static async Task DownloadJsonData<T>(string filename, T data) {
            var json = System.Text.Json.JsonSerializer.Serialize(data);
            byte[] file = System.Text.Encoding.UTF8.GetBytes(json);
            await JS.InvokeVoidAsync("BlazorDownloadFile", $"{filename}.json", "text/json", file);
        }
        [JSInvokable]
        public static async Task PersistSession() {
            if (Data == null || JS == null)
                return;
            try {
                var json = System.Text.Json.JsonSerializer.Serialize(Data);
                await JS.InvokeVoidAsync("BlazorWriteLocalStorage", "rpgnotes.session", json);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        public static async Task ReloadPersistedSession() {
            if (Data == null || JS == null)
                return;

            try {
                var json = await JS.InvokeAsync<string>("BlazorReadLocalStorage", "rpgnotes.session");
                if (string.IsNullOrEmpty(json))
                    return;
                var app_data = System.Text.Json.JsonSerializer.Deserialize<AppData>(json);
                Data.Overwrite(app_data);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
