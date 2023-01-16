using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Data
{
    public static class DbContext
    {

        public static List<IPlate> Plates { get; set; } = new List<IPlate>()
        {
            DUMMY_DATA.StartingGood,
            DUMMY_DATA.StartingBlack,
            DUMMY_DATA.StartingGold
        };

        public static List<ICustomer> Customers { get; set; } = new List<ICustomer>();
    }
}