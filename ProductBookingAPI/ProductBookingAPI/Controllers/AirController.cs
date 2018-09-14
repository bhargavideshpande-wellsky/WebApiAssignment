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
    public class AirController : ApiController
    {
         public IEnumerable<Air>GetAir()
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                IEnumerable<Air> airs = entities.Airs.ToList();
                IFare fare = new AirFare();
                foreach (Air air in airs)
                {
                    air.ProductPrice = fare.GetActualFare(Convert.ToInt32(air.ProductPrice));
                }
                return airs;
            }
        }
        public void PostAir([FromBody]Air air)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                int id = Int32.Parse(entities.Airs.Max(p => p.Id).ToString());
                id++;
                air.Id = id;
                entities.Airs.Add(air);
                entities.SaveChanges();
            }
        }
       
        public void PutAir([FromBody] BookSave product)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                var air = entities.Airs.Find(product.id);
                if (product.action == "book")
                { 
                    air.IsBooked = true;
                    entities.SaveChanges();
                }
                else if(product.action=="save")
                {
                    air.IsSaved = true;
                    entities.SaveChanges();
                }
                
            }
        }
    }
}
