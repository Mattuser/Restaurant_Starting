using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Services
{
    public class CustomerService
    {
        private readonly PlateService? _plateService;

        public CustomerService()
        {
            _plateService = new PlateService();
        }
        public string BuyPlate(ICustomer customer, int plateId)
        {
            var plate = _plateService!.GetPlate(plateId);

            if(plate == null || plate.QuantityInStock == 0)
                return $"Prato em falta";

            if(customer.Money < plate.Price)
            {
                return $"Você não tem dinheiro o suficiente, o prato custa ${plate.Price}";
            }

            var newMoneyQuantityOfCustomer = customer.Money -= plate.Price;
            var quantityOfPlatesRemainingInStock = _plateService!.DecrementPlateInStock(plateId);
            
            return $"Quantidade restante em estoque ${quantityOfPlatesRemainingInStock}";
        }
    }
}