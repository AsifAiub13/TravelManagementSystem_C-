using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.dal;
using ClassLibrary1;
using System.Data.Entity;

namespace BussinessLogic.bll
{
    class AdminLogicInfo
    {
       private Datacontext2 dbcontext = new Datacontext2();

        public List<AdminTable> AdminGetAllInformation()
        {
            var result = (
                      from database in dbcontext.AdminTables
                      select database
                  );
            return result.ToList();
        }
        public bool AddCustomer(AdminTable entity)
        {
            if (entity != null)
            {
                //dbcontext.AdminTables.Add(entity);
                dbcontext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
