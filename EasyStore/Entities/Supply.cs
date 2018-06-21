namespace EasyStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supply
    {
        public int Id { get; set; }

        [Required]
        public string Product { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

        public virtual Category Category { get; set; }
    }
}
