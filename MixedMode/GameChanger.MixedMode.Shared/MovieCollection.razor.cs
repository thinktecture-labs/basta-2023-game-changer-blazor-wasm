using Microsoft.AspNetCore.Components;
using GameChanger.MixedMode.Shared.Models;
using System.Net.Http.Json;

namespace GameChanger.MixedMode.Shared;

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