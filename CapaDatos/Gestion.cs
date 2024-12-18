using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    using Entidades;
    using Servidores;
    using System.Runtime.CompilerServices;

    public class Gestion
    {
        private AgendaEntities context;
        public Gestion()
        {
            
            try
            {
                string servidor = Servidor.ServidorActual();
                string cadenaConexion = $@"metadata = res://*/ModeloEstado.csdl|res://*/ModeloEstado.ssdl|res://*/ModeloEstado.msl; provider = System.Data.SqlClient;provider connection string= 'data source={servidor};initial catalog=Agenda;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";
                context = new AgendaEntities(cadenaConexion);
            }
            catch (Exception ex)
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

        public Contactos BuscarContacto(int id, out string msg)
        {
            msg = "";
            try
            {
                return context.Contactos.Find(id);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
        }

        public void DarDeAltaGrupo()
        {

        }

    }
}
