using DemoBlazor_DevenirDev2.Models;

namespace DemoBlazor_DevenirDev2.Services
{
    public class ComputerService
    {
        public static List<Computer> Computers = new()
        {
            new Computer()
            {
                Id = 1,
                Name = "ZXCH45",
                Marque = "Asus",
                Memory = 4,
                Ram = 32,
                Price = 1450.89,
                ImageUrl = "images/computer1.jpg"
            },
            new Computer()
            {
                Id = 2,
                Name = "ZXCH46",
                Marque = "Dell",
                Memory = 3,
                Ram = 32,
                Price = 2550.89,
                ImageUrl = "images/computer2.jpg"
            },
             new Computer()
            {
                Id = 1,
                Name = "ZXCH47",
                Marque = "Acer",
                Memory = 6,
                Ram = 32,
                Price = 980.89,
                ImageUrl = "images/computer3.jpg"
            },
        };

        public List<Computer> GetAll()
        {
            return Computers;
        }

        public Computer? GetById(int id)
        {
            return Computers.FirstOrDefault(c => c.Id == id);

        }

        public bool AddComputer(AddComputerDTOs newComputer)
        {
            int id = Computers.Last().Id + 1;

            Computer comp = new()
            {
                Id = id,
                Name = newComputer.Name,
                Marque = newComputer.Marque,
                Ram = newComputer.Ram,
                Memory = newComputer.Memory,
                ImageUrl = newComputer.ImageUrl,
                Price = newComputer.Price
            };

            int countBefore = Computers.Count;

            Computer? exist = Computers.FirstOrDefault(c => c.Name == comp.Name);

            if (exist != null)
            {
                return false;
            }

            Computers.Add(comp);

            int countAfter = Computers.Count;

            return countAfter > countBefore;
        }

        public bool RemoveComputer(int id)
        {
            int countBefore = Computers.Count;

            int index = Computers.FindIndex(c => c.Id == id);

            Computers.RemoveAt(index);

            int countAfter = Computers.Count;

            return countAfter < countBefore;
        }

        public bool UpdateComputer(UpdateComputerDTOs updatedComputer,int id)
        {
            int index = Computers.FindIndex(c => c.Id == id);

            Computers[index].Ram = updatedComputer.Ram;
            Computers[index].Name = updatedComputer.Name;
            Computers[index].Memory = updatedComputer.Memory;
            Computers[index].Price = updatedComputer.Price;
            Computers[index].ImageUrl = updatedComputer.ImageUrl;

            return true;
        }

        public List<Computer> GetByFilter(double minPrice , double MaxPrice)
        {
            return Computers.Where(c => c.Price > minPrice && c.Price < MaxPrice).ToList();
        }
    }
}
