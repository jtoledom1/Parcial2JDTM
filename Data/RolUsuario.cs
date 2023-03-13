using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2JDTM.Data
{
    public class RolUsuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Fixer { get; set; }
        public bool Owner { get; set; }
        public bool Spotter { get; set; }
    }
}
