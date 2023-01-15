using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Data
{
    public static class DbContext
    {
        public static List<IPlate> Plates { get; set; } = new List<IPlate>();
    }
}