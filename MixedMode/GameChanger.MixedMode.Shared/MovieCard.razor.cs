using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using GameChanger.MixedMode.Shared.Models;

namespace GameChanger.MixedMode.Shared
{
    public partial class MovieCard
    {
        [Parameter]
        public PopularMovie? PopularMovie { get; set; }

        [Parameter]
        public EventCallback<int> OnBtnClick { get; set; }

        [Parameter]
        public string? ModalId { get; set; }
    }
}