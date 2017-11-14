using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sana.WebShop.Model.Data
{
    public partial class Customer
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public DateTime ModifiedDate { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
