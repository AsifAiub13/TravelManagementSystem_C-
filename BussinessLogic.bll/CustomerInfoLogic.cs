using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.dal;
using ClassLibrary1;
using System.Data.Entity;
using System.Data;



namespace BussinessLogic.bll
{
    public class CustomerInfoLogic
    {
        private Datacontext2 dbcontext2 = new Datacontext2();
        public List<custregTable> GetAllInformation()
        {
            var result = (
                      from database in dbcontext2.custregTables
                      select database
                  );
            return result.ToList();
            
        }
        public bool AddCustomer(custregTable entity)
        {
            if (entity != null)
            {
                dbcontext2.custregTables.Add(entity);
                dbcontext2.SaveChanges();
                return true;
            }
            else 
            {
                return false;
            }
 
        }

        public List<custregTable> GetInfo(string firstname)
        {
            var result = (
                from r in dbcontext2.custregTables
                where r.username== firstname
                select r
                         );
            return result.ToList();
        }
        public bool Check1(string passWord)
        {
            //custregTable context = new custregTable();
            var query = from p in dbcontext2.custregTables
                        where p.password == passWord
                        select p;

            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
}
