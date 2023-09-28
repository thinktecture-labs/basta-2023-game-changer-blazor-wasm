using GameChanger.RenderModes.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.RenderModes.Client.Features.Movies
{
    public partial class ClientMovieModal
    {
        [Parameter]
        public MovieDetails? MovieDetails { get; set; }
    }
}