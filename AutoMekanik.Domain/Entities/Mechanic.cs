using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.Entities
{
    public class Mechanic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; } // Optional: You could add more fields like this.
    }
}
