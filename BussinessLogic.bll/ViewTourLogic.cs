using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClassLibrary1;
using DataAccess.dal;

namespace BussinessLogic.bll
{
    class ViewTourLogic
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
      
        }

    }

