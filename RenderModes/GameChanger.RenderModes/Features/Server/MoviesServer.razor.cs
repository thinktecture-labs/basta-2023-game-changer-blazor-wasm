using GameChanger.RenderModes.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.RenderModes.Features.Server
{
    public partial class MoviesServer
    {
        [Inject] private HttpClient _httpClient { get; set; } = default!;
        private PopularMovieResponse? MovieResponse { get; set; }
        private MovieDetails? MovieDetails { get; set; }

        protected override async Task OnInitializedAsync()
        {
            MovieResponse = await _httpClient.GetFromJsonAsync<PopularMovieResponse>("movie/popular");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("Hello from Server component");
        }

        private async Task GetMovieDetails(int id)
        {
            MovieDetails = null;
            await InvokeAsync(StateHasChanged);
            await Task.Delay(16);
            MovieDetails = await _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
            await InvokeAsync(StateHasChanged);
        }
    }
}