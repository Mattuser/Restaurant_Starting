using Restaurant_Starting.Data;
using Restaurant_Starting.Interfaces;

namespace Restaurant_Starting.Repositories
{
    public class PlateRepository
    {
    
        public List<IPlate> Get()
        {
            return DbContext.Plates;
        }
        public IPlate? GetById(int id)
        {
            var plate = DbContext.Plates.FirstOrDefault(x => x.Id == id);
            return plate;
        }

        public bool AddPlate(IPlate plate)
        {
           if(DbContext.Plates == null) return false;
           
           DbContext.Plates.Add(plate);
           return true;
        }
    }
}