namespace Lesson9_Exercise.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public static Invoice instance;
        public Invoice()
        {
            Orders = new HashSet<Order>();
            instance = this;
        }

        [StringLength(30)]
        public string InvoiceID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public static Invoice GetInvoice(string InvoiceID)
        {
            return instance.InvoiceID == InvoiceID ? instance : null;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
