using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Models
{
    public class Plate : IPlate
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public Plate()
        {
            
        }


    }
}