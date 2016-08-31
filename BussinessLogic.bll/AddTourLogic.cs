using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.dal;
using System.Data.Entity;
using ClassLibrary1;
using System.Data.SqlClient;

namespace BussinessLogic.bll
{
   public class AddTourLogic
    {
        private Datacontext2 dbcontext3 = new Datacontext2();
        public List<AddToursTable> GetAllInformation()
        {
            var result = (
                      from database in dbcontext3.AddToursTables
                      select database
                  );
            return result.ToList();

        }
        //addtours
        public bool AddTour(AddToursTable entity)
        {
            if (entity != null)
            {
                dbcontext3.AddToursTables.Add(entity);
                dbcontext3.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
            public List<AddToursTable> AddTour(string tour)
        {
            var result = (
                from r in dbcontext3.AddToursTables
                where r.AddTour == tour
                select r
                         );
            return result.ToList();
        }
            public void deleteData()
            {
                ////Here TestEntities is the class which is given from "Save entity connection setting in web.config"
                //Datacontext2 context = new Datacontext2();

                //var query = (from data in context.AddToursTables
                //             where data.Id == 1
                //             orderby data.AddTour
                //             select data).First();

                //context.Attach(query);
                ////DeleteObject is used to the delete the entity onject.
                //context.DeleteObject();
                //context.SaveChanges();
                Datacontext2 db = new Datacontext2(); // Arrange the context

                //AddToursTable dept = db.AddToursTables.Single(p => p.Id == 1); // Find the item to remove
                var dept = (from data in db.AddToursTables
                            where data.Id == 3
                            orderby data.AddTour
                            select data).FirstOrDefault();
                db.AddToursTables.Remove(dept); // Remove from the context

                db.SaveChanges(); // Delete from the database
            }
       
        
        
        

    }
}
