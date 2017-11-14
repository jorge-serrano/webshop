using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sana.WebShop.Model.Data
{
    public partial class Order
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public byte OrderStatus { get; set; }

        public int CustomerID { get; set; }

        public string Comments { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Customer Customer { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
