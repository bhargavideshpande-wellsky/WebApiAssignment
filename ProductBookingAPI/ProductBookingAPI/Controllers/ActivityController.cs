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
    public class ActivityController : ApiController
    {
        public IEnumerable<Activity> GetActivity()
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                return entities.Activities.ToList();
            }
        }
        public void PostActivity([FromBody]Activity activity)
        {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                int id = Int32.Parse(entities.Activities.Max(p => p.Id).ToString());
                id++;
                activity.Id = id;
                entities.Activities.Add(activity);
                entities.SaveChanges();
            }
        }
         public void PutActivity([FromBody] BookSave product)
         {
            using (BookProductAPIEntities entities = new BookProductAPIEntities())
            {
                var activity = entities.Activities.Find(product.id);
                if (product.action == "book")
                {
                    activity.IsBooked = true;
                    entities.SaveChanges();
                }
                else if (product.action == "save")
                {
                    activity.IsSaved = true;
                    entities.SaveChanges();
                }

            }

         }
    }
}
