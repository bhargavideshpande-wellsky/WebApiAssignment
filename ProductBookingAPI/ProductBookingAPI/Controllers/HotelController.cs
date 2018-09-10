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
    public class HotelController : ApiController
    {
        public IEnumerable<Hotel> GetHotel()
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                IEnumerable<Hotel> hotels = entities.Hotels.ToList();
                IFare fare = new HotelFare();
                foreach (Hotel hotel in hotels)
                {
                    hotel.ProductPrice = fare.GetActualFare(Convert.ToInt32(hotel.ProductPrice));
                }
                return hotels; ;
            }
        }
        public void PostHotel([FromBody]Hotel hotel)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                int id = Int32.Parse(entities.Hotels.Max(p => p.Id).ToString());
                id++;
                hotel.Id = id;
                entities.Hotels.Add(hotel);
                entities.SaveChanges();
            }
        }
        public void PutHotel([FromBody] BookSave product)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                var hotel = entities.Hotels.Find(product.id);
                if (product.action == "book")
                {
                    hotel.IsBooked = true;
                    entities.SaveChanges();
                }
                else if (product.action == "save")
                {
                    hotel.IsSaved = true;
                    entities.SaveChanges();
                }

            }
        }
    }
}
