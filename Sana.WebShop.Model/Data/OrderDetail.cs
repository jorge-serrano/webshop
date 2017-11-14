using System;

namespace Sana.WebShop.Model.Data
{
    public partial class OrderDetail
    {
        public int OrderID { get; set; }

        public int SalesOrderDetailID { get; set; }

        public short Qty { get; set; }

        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
