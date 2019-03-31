using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorComponents.Extensions
{
    public static class ElementRefExtensions
    {
        public static Task Focus(this ElementRef elementRef, IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<object>(
                "Extensions.focusElement", elementRef);
        }
    }
}
