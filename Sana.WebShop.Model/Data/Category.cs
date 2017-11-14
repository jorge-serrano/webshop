using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sana.WebShop.Model.Data
{
    public partial class Category
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Product = new HashSet<Product>();
        }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
