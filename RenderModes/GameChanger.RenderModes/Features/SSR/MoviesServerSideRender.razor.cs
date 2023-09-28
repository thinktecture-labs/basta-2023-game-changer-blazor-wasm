using GameChanger.RenderModes.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.RenderModes.Features.SSR
{
    public partial class MoviesServerSideRender
    {
        [Inject] private HttpClient _httpClient { get; set; } = default!;
        private PopularMovieResponse? MovieResponse { get; set; }

        protected override async Task OnInitializedAsync()
        {
            MovieResponse = await _httpClient.GetFromJsonAsync<PopularMovieResponse>("movie/popular");
        }
    }
}