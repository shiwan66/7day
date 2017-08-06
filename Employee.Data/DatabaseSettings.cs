using System.Data.Entity;
using Employees.Data.DataAccessLayer;

namespace Employees.Data
{
    public class DatabaseSettings
    {
        public static void SetDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SalesERPDAL>());
        }
    }
}
