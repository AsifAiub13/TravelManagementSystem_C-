using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.dal;
using System.Data.Entity;

namespace BussinessLogic.bll
{
    public class LoginInfo
    {
        Datacontext2 dbcontext2 = new Datacontext2();
        public List<custregTable> GetCustomerAllInformation()
        {
            var result = (
                      from database in dbcontext2.custregTables
                      select database
                  );

            return result.ToList();
        }
        public List<AdminTable> GetAdminAllInformation()
        {
            var result = (
                      from database in dbcontext2.AdminTables
                      select database
                  );

            return result.ToList();
        }
        public bool CheckCustomeruser(string userName, string passWord)
        {
            //custregTable context = new custregTable();
            var query = from p in dbcontext2.custregTables
                        where p.username == userName
                        && p.password == passWord
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
        public bool CheckAdminUser(string adminuserName, string adminpassword)
        {
            //custregTable context = new custregTable();
            var query = from p in dbcontext2.AdminTables
                        where p.username == adminuserName
                        && p.password == adminpassword
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

