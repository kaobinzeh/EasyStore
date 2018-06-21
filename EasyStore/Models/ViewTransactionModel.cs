using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyStore.Models
{
    public class vw_Transaction
    {
        public int Id { get; set; }

        public string Prod_Name { get; set; }

        public decimal Price { get; set; }

        public string Barcode { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }

        public decimal Total { get; set; }

        public string FullName { get; set; }

        public Guid UserId { get; set; }

        public DateTime Date { get; set; }

    }
}
