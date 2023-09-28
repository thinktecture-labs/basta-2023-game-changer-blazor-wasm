using GameChanger.WasmStandalone.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.WasmStandalone.Components
{
    public partial class MovieModal
    {
        [Parameter]
        public MovieDetails? MovieDetails { get; set; }
    }
}