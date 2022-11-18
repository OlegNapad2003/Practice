using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Order
    {
        [Column("OrderID")]
        public int Id { get; set; }

        public string Type { get; set; }

        public string Restrictions { get; set; }

        
        public int?  ClientID { get; set; }

        public decimal PriceOrder { get; set; }

        public int CompanyID { get; set; }

        public Client? Client { get; set; }

    }

}

