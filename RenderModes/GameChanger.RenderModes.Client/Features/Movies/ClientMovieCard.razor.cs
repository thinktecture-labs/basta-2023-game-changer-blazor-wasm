using Microsoft.AspNetCore.Components;
using GameChanger.RenderModes.Shared.Models;

namespace GameChanger.RenderModes.Client.Features.Movies
{
    public partial class ClientMovieCard
    {
        [Parameter]
        public PopularMovie? PopularMovie { get; set; }

        [Parameter]
        public EventCallback<int> OnBtnClick { get; set; }

        [Parameter]
        public string? ModalId { get; set; }
    }
}