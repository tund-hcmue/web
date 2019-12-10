using Repository;
using SaleRepository.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class SaleListByOtherDayAction
    {
        public DateTime dt { get; set; }
        public List<dynamic> Execute()
        {
            using (var cmd = new SaleSearchByOtherDayRepository())
            {
                cmd.dt = this.dt;
                return cmd.Execute();
            }
        }
    }
}