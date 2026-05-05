using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    public partial class ListProduct
    {

        public List<Product> products { get; set; }

        [Inject]
        private ProductService _service {  get; set; }

        [Inject]
        private NavigationManager _nav {  get; set; }

        public ListProduct(ProductService service)
        {
            _service = service;
        }

        protected override void OnInitialized()
        {
            products = _service.GetAll();
        }

        public void NavigateToDetails(int id)
        {
            _nav.NavigateTo($"/details/{id}");
        }

    }
}
