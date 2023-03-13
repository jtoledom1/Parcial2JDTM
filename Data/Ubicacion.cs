using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2JDTM.Data
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
            
        public string Country { get; set; }
        public int PostalCode { get; set; }

    }
}
