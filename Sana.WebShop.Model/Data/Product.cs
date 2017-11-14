using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sana.WebShop.Model.Data
{
    public partial class Product
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
            Category = new HashSet<Category>();
        }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductNumber { get; set; }

        public decimal Price { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category> Category { get; set; }
    }
}
