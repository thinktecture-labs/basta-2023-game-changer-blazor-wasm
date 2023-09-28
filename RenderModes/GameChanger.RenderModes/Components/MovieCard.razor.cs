using Microsoft.AspNetCore.Components;
using GameChanger.RenderModes.Shared.Models;

namespace GameChanger.RenderModes.Components
{
    public partial class MovieCard
    {
        [Parameter]
        public PopularMovie? PopularMovie { get; set; }

        [Parameter]
        public EventCallback<int> OnBtnClick { get; set; }

        [Parameter]
        public string? ModalId { get; set; }

        [Parameter]
        public bool UseJSForBtn { get; set; }
    }
}