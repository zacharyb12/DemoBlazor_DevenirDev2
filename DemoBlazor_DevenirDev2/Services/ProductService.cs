using DemoBlazor_DevenirDev2.Models;

namespace DemoBlazor_DevenirDev2.Services
{
    public class ProductService
    {
        public static List<Product> datas = new()
        {
            new Product()
            {
                Id = 1,
                Name = "Shoes",
                Price = 89.99,
                ImageUrl = "https://media.gq.com/photos/60d21a25ab6b8cc6e9d2c80a/1:1/w_3600,h_3600,c_limit/SNEAKER_GUIDE_OPENER.jpg"
            },
            new Product()
            {
                Id = 2,
                Name = "Jacket",
                Price = 89.99,
                ImageUrl = "https://www.sodiffusion.fr/24213-tm_thickbox_default/doudoune-matelass%C3%A9e-chauffante-homme-glovii.jpg"
            },
            new Product()
            {
                Id = 3,
                Name = "shirt",
                Price = 89.99,
                ImageUrl = "https://www.flyeralarm.com/white/assets/groesse3/73/84/AS-2707384.jpg"
            }
        };

        public bool Create(Product newProduct)
        {
            int count = datas.Count();

            datas.Add(newProduct);

            int countAfter = datas.Count();

            return  countAfter > count;
        }

        public List<Product> GetAll()
        {
            return datas;
        }

        public Product? GetById(int id)
        {
            int index = datas.FindIndex(p => p.Id == id);

            if(index == -1)
            {
                return null;
            }

            Product productToSend = datas[index];

            return productToSend;
        }
    }
}
