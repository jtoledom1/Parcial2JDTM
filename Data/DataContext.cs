using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2JDTM.Data
{
    public class DataContext:DbContext
    {
        DbSet<Automovil> automoviles { get; set; }
        DbSet<Equipo> equipos { get; set; }
        DbSet<RolUsuario> rolUsuarios { get; set; }
        DbSet<Usuario> usuarios { get; set; }
        DbSet<Ubicacion> ubicaciones { get; set; }
        public DataContext() : base("name=con")
        {



        }
    }
}
