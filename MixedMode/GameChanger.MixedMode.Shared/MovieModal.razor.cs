﻿using GameChanger.MixedMode.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.MixedMode.Shared
{
    public partial class MovieModal
    {
        [Parameter]
        public MovieDetails? MovieDetails { get; set; }
    }
}
