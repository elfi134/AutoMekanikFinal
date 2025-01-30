using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

}
