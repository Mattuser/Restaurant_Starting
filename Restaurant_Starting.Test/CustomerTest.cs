using Restaurant_Starting.Data;
using Restaurant_Starting.Services;

namespace Restaurant_Starting.Test;

public class CustomerTest
{
    private readonly CustomerService? _customerService;
    private readonly PlateService? _plateService;

    public CustomerTest()
    {
        _customerService = new CustomerService();
        _plateService = new PlateService();
    }

    [Fact]
    public void BuyPlate_Test_ReturnIfValueIsEqual2()
    {
        var buy1 = _customerService!.BuyPlate(DUMMY_DATA.Costumer1, 1);
        var plate = _plateService!.GetPlate(1);
        
        Assert.Equal(2, plate.QuantityInStock);

    }
}