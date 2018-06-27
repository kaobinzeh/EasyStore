namespace EasyStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        public int Id { get; set; }

        public int Product_Id { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        public string UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Product Product { get; set; }
    }
}
