using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Client
    {
        [Column("ClientNum")]
        public int? Id { get; set; }

        public string FIO { get; set; }

        public int Stage { get; set; }

        public int Auto_Passport_index { get; set; }
        public LinkedList<Order> Order { get; set; } = new();

    }
}