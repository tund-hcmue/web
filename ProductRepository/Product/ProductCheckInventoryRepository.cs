using ConnectDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductCheckInventoryRepository : Connection
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new Query())
            {
                cmd.QueryString = "SELECT [Product].[ProductName], [Product].[Qty] FROM PRODUCT";
                return cmd.ExecuteQuery();
            }
        }
    }
}
