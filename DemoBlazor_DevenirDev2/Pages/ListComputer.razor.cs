using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class ListComputer
    {
        [Inject]
        private ComputerService _service {  get; set; }

        [Inject]
        private NavigationManager _nav {  get; set; }
        
        public List<Computer> Computers { get; set; } = new();

        public List<Computer> ComputersFiltered { get; set; } = new();

        public string searchValue { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            Computers = _service.GetAll();
            ComputersFiltered = Computers;
        }

        public void NavigateToDetails(int id)
        {
            _nav.NavigateTo($"/details-computer/{id}");
        }
        private void OnSearchInput(ChangeEventArgs e)
        {
            searchValue = e.Value?.ToString() ?? "";
            FilterList();
        }
        public void FilterList()
        {
            ComputersFiltered = Computers.Where(c => c.Name.ToLower().Contains(searchValue.ToLower()) || c.Marque.Contains(searchValue)).ToList();
        }
    }
}
