using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Data;

namespace Business.Service
{
    public class BusinessSettings
    {
        public static void SetBusiness()
        {
            DatabaseSettings.SetDatabase();
        }
    }
}
