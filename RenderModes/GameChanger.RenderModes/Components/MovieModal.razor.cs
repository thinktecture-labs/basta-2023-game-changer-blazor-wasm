using Microsoft.AspNetCore.Components;
using GameChanger.RenderModes.Shared.Models;

namespace GameChanger.RenderModes.Components
{
    public partial class MovieModal
    {
        [Parameter]
        public MovieDetails? MovieDetails { get; set; }
    }
}