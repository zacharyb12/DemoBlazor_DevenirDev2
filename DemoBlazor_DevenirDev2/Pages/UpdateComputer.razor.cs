using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class UpdateComputer
    {
        [Parameter]
        public int Id { get; set; }

        public UpdateComputerDTOs UpdatedComputer { get; set; } = new();

        [Inject]
        private ComputerService _service {  get; set; }

        [Inject]
        private NavigationManager _nav {  get; set; }

        protected override void OnInitialized()
        {
            Computer? c = _service.GetById(Id);

            if(c == null)
            {
                _nav.NavigateTo("/list-computer");
            }

            UpdatedComputer.Name = c.Name;
            UpdatedComputer.Memory = c.Memory;
            UpdatedComputer.Ram = c.Ram;
            UpdatedComputer.Price = c.Price;
            UpdatedComputer.ImageUrl = c.ImageUrl;
        }

        public void Update()
        {
            bool result = _service.UpdateComputer(UpdatedComputer,Id);

            if(result)
            {
                _nav.NavigateTo("/list-computer");
            }
        }

        public void DeleteComputer()
        {
           bool result = _service.RemoveComputer(Id);

            if(result)
            {
                _nav.NavigateTo("/list-computer");
            }
        }
    }
}
