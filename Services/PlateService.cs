using Restaurant_Starting.Interfaces;
using Restaurant_Starting.Repositories;

namespace Restaurant_Starting.Services
{
    public class PlateService
    {
        public List<IPlate> Get()
        {
            var repository = new PlateRepository();
            return repository.Get();
        }
        public IPlate GetPlate(int id)
        {
            var repository = new PlateRepository();
            var plate = repository.GetById(id);
            return plate;
        }

        public bool AddPlate(IPlate model)
        {
            var repository = new PlateRepository();
            var plate = GetPlate(model.Id);

            if(plate == null)
                return repository.AddPlate(model);

            IncrementPlateInStock(plate.Id);

            return repository.AddPlate(plate); 

        }

        public int IncrementPlateInStock(int id)
        {
            var repository = new PlateRepository();
            var plate = repository.GetById(id);

            plate.QuantityInStock += 1;
            return plate.QuantityInStock;
        }

        public int DecrementPlateInStock(int id)
        {
            var repository = new PlateRepository();
            var plate = repository.GetById(id);

            plate.QuantityInStock -=1;
            return plate.QuantityInStock;

        }
    }
}