using System;
using Repository;
using ConnectDataBase;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class ProductCheckInventoryAction
    {
        public List<dynamic> Execute()
        {
            using (var cmd = new ProductCheckInventoryRepository())
            { 
                return cmd.Execute();
            }
        }
    }
}