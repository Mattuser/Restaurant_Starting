using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Models
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Money { get; set; }
  
    }
}