using global::Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using GameChanger.RenderModes.Shared.Models;

namespace GameChanger.RenderModes.Client.Features.Movies
{
    public partial class MovieCollection
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
            Console.WriteLine("Hello from WASM component");
        }

        private async Task GetMovieDetails(int id)
        {
            MovieDetails = null;
            StateHasChanged();
            await Task.Delay(500);
            MovieDetails = await _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
            StateHasChanged();
        }
    }
}