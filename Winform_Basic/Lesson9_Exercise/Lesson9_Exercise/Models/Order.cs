namespace Lesson9_Exercise.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string InvoiceID { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }


    }
}
