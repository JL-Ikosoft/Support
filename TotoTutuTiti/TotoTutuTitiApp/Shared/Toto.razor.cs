using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared
{
    public partial class Toto : IAsyncDisposable
    {
        [Parameter]
        public string? Tab { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        public async ValueTask DisposeAsync()
        {
            await ValueTask.CompletedTask;
        }
    }
}
