namespace EasyStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public int UsersId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string UserId { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}
