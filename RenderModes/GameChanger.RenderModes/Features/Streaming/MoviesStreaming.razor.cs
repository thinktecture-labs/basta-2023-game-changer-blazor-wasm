using GameChanger.RenderModes.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.RenderModes.Features.Streaming
{
    public partial class MoviesStreaming
    {
        [Inject] private HttpClient _httpClient { get; set; } = default!;
        private PopularMovieResponse? MovieResponse { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(3000);
            MovieResponse = await _httpClient.GetFromJsonAsync<PopularMovieResponse>("movie/popular");
        }
    }
}