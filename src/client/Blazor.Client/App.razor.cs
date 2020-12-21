using blazor.Client.Pages.Utils;
using Microsoft.AspNetCore.Components;

namespace blazor.Client
{
    public partial class App
    {
        [Inject]
        public INavigationService NavigationService { get; set; } // Permit to initialize navigation service
    }
}
