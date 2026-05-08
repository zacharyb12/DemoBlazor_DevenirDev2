using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class DetailsComputer
    {
        [Parameter]
        public int Id { get; set; }

        public Computer ComputerToShow { get; set; }

        [Inject]
        private ComputerService _service {  get; set; }

        [Inject]
        private NavigationManager _nav {  get; set; }

        protected override void OnInitialized()
        {
            Computer? computer  = _service.GetById(Id);

            if(computer == null)
            {
                _nav.NavigateTo("/list-computer");
            }

            ComputerToShow = computer;
        }

        public void NavigateToUpdate(int id)
        {
            _nav.NavigateTo($"/update-computer/{id}");
        }
    }
}
