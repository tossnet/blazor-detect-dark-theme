using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDetectTheme.Services
{
    public class BrowserModeService
    {
        private readonly IJSRuntime _js;

        public BrowserModeService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<bool> IsDarkMode()
        {
            return await _js.InvokeAsync<bool>("IsDarkMode");
        }
    }
}
