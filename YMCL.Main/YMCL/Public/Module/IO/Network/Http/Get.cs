using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Controls.Notifications;
using Avalonia.Threading;
using YMCL.Public.Langs;

namespace YMCL.Public.Module.IO.Network.Http;

public class Get
{
    private static readonly HttpClient _client = new();

    public static async Task<string?> GetStringAsync(string url, bool showNotice = true)
    {
        try
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return json;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            if (showNotice)
            {
                Dispatcher.UIThread.Invoke(() =>
                {
                    Notice(MainLang.NetWorkError, NotificationType.Error);
                });
            }
            return null!;
        }
    }
}