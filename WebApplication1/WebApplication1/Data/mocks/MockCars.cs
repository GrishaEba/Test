using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars { get 
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla", 
                        shortDesc ="",
                        img ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fitc.ua%2Fnews%2Ftesla-model-x-samyiy-bezopasnyiy-avtomobil-v-svoem-klasse-po-versii-nhtsa-video-krash-testov%2F&psig=AOvVaw2BwrjdEcpY_a_hUJQoItXx&ust=1619726576921000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNiwi-7dofACFQAAAAAdAAAAABAD",
                        price = 45000,
                        isFavourite=true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() },
                    new Car{
                        name = "BMW",
                        shortDesc ="",
                        img ="https://www.google.com/url?sa=i&url=https%3A%2F%2Fitc.ua%2Fnews%2Ftesla-model-x-samyiy-bezopasnyiy-avtomobil-v-svoem-klasse-po-versii-nhtsa-video-krash-testov%2F&psig=AOvVaw2BwrjdEcpY_a_hUJQoItXx&ust=1619726576921000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNiwi-7dofACFQAAAAAdAAAAABAD",
                        price = 23000,
                        isFavourite=true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last() }
                }; 
                }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
