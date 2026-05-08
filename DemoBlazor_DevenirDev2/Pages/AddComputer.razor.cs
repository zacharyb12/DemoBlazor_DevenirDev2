using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class AddComputer
    {

        public AddComputerDTOs NewComputer { get; set; } = new();


        [Inject]
        private ComputerService _service { get; set; }

        [Inject]
        private NavigationManager _nav {  get; set; }

        public void Add()
        {
            bool result = _service.AddComputer(NewComputer);

            if(result)
            {
                _nav.NavigateTo("/list-computer");
            }
        }
    }
}
