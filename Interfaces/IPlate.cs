namespace Restaurant_Starting.Interfaces
{
    public interface IPlate
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

    }
}