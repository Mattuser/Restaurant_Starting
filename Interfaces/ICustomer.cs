namespace Restaurant_Starting.Interfaces
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Money { get; set; }
        
    }
}