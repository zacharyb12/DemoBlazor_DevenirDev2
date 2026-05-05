using DemoBlazor_DevenirDev2.Models;
using DemoBlazor_DevenirDev2.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazor_DevenirDev2.Pages
{
    // Il est possible de définir la route dans la classe partial
    //[Route("/details/{id:int}")]
    public partial class Details
    {
        // Parameter permet de definir qu'une informations sera passé en paramètres
        [Parameter]
        public int Id { get; set; }

        // Represente l'instance qui sera manipulé dans la vue
        public Product? Product { get; set; } = null;

        // Donne accès à la logique
        [Inject]
        private ProductService _service {  get; set; }

        // Constructeur qui s'éxécute à la création du composant
        public Details(ProductService service)
        {
            _service = service;
        }

        // Permet d'exécuter une ou uplusieurs actions au chargement du composant 
        protected override void OnInitialized()
        {
            // recuperation du produit
            Product = _service.GetById(Id);
        }
    }
}
