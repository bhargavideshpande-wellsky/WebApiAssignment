using ProductBookingAPI.Fare;
using ProductBookingAPI.Models;
using ProductDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductBookingAPI.Controllers
{
    public class CarController : ApiController
    {
        public IEnumerable<Car> GetCar()
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                IEnumerable<Car> cars = entities.Cars.ToList();
                IFare fare = new CarFare();
                foreach(Car car in cars)
                {
                    car.ProductPrice = fare.GetActualFare(Convert.ToInt32(car.ProductPrice));
                }
                return cars;
            }
        }
        public void PostCar([FromBody]Car car)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                int id = Int32.Parse(entities.Cars.Max(p => p.Id).ToString());
                id++;
                car.Id = id;
                entities.Cars.Add(car);
                entities.SaveChanges();
            }
        }
        public void PutCar([FromBody] BookSave product)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                var car = entities.Cars.Find(product.id);
                if (product.action == "book")
                {
                    car.IsBooked = true;
                    entities.SaveChanges();
                }
                else if (product.action == "save")
                {
                    car.IsSaved = true;
                    entities.SaveChanges();
                }

            }
        }
    }
}
