namespace EasyStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Barcode")]
    public partial class Barcode
    {
        public int Id { get; set; }

        [Column("Barcode")]
        [Required]
        [StringLength(50)]
        public string Barcode1 { get; set; }

        public bool IsUsed { get; set; }
    }
}
