using GameChanger.WasmStandalone.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace GameChanger.WasmStandalone.Components
{
    public partial class MovieCard
    {
        [Parameter]
        public PopularMovie? PopularMovie { get; set; }

        [Parameter]
        public EventCallback<int> OnBtnClick { get; set; }

        [Parameter]
        public string? ModalId { get; set; }

        private async Task OnShowDetailClicked(int id)
        {
            await OnBtnClick.InvokeAsync(id);
        }
    }
}