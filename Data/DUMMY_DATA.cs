using Restaurant_Starting.Interfaces;
using Restaurant_Starting.Models;

namespace Restaurant_Starting.Data
{
    public static class DUMMY_DATA
    {

        //PLATES
        
        public static IPlate StartingGood = new Plate()
        {
            Id = 1,
            Name = "Starting Good",
            Price = 50.0m,
            QuantityInStock = 3
        };

        public static IPlate StartingBlack = new Plate()
        {
            Id = 2,
            Name = "Starting Black",
            Price = 75.50m,
            QuantityInStock = 5
        };

        public static IPlate StartingGold = new Plate()
        {
            Id = 3,
            Name = "Starting Gold",
            Price = 150.0m,
            QuantityInStock = 1
        };


        //CUSTOMERS

        public static ICustomer Costumer1 = new Customer()
        {
            Id = 1,
            Name = "C1",
            Money = 55.0m
        };

        public static ICustomer Costumer2 = new Customer()
        {
            Id = 2,
            Name = "C2",
            Money = 175.50m
        };
    }
}