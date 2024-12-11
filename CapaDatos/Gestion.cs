using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    using Entidades;
    using System.Runtime.CompilerServices;

    public class Gestion
    {
        private AgendaEntities context;
        public Gestion()
        {
            
            try
            {
                context = new AgendaEntities();
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<Contactos> ContactosAlfabeticamente(out string msg)
        {
            msg = "";
            try
            {
                return context.Contactos.OrderBy(x => x.Nombre).ToList();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
            
        }
    }
}
