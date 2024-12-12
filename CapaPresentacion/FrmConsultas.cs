using Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CapaDatos;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FrmConsultas : Form
    {

        Gestion gestion = new Gestion();
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = "";
            lblMensaje.Text = "";


            List<Contactos> listaContactos = gestion.ContactosAlfabeticamente(out string errores);

            if (!int.TryParse(txtIdContacto.Text,out int id))
            {
                MessageBox.Show("Tienes que introducir una id numerica");
                return;
            }

            var contacto = (from contacto1 in listaContactos
                           where contacto1.IdContacto == id
                           select contacto1).SingleOrDefault();

            if (contacto == null)
            {
                lblMensaje.Text = $"NO EXISTE NINGUN CONTACTO CON IDENTIFICADOR {id}";
                return;
            }
            else
            {
                lblMensaje.Text = $"TELEFONOS DEL CONTACTO CON IDENTIFICADOR {id}: '{contacto.Nombre}' del Grupo '{contacto.IdGrupo}'";

            }



            var telefonosContacto = from telf in contacto.Telefonos
                                    select new { 
                                    telf.Numero,
                                    telf.Descripcion
                                    };

            dgvContactos.DataSource = telefonosContacto.ToList();

        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = "";
            lblMensaje.Text = "";

            List<Contactos> listaContactos = gestion.ContactosAlfabeticamente(out string errores);
            if (errores != "")
            {
                MessageBox.Show(errores);

                return;
            }


            var listaTodosLosContactos = from contacto in listaContactos
                                         select new {
                                             contacto.IdContacto,
                                             contacto.Nombre,
                                             contacto.Email,
                                             contacto.IdGrupo,
                                             CantTelefonos = contacto.Telefonos != null ? contacto.Telefonos.Count:0,
                                             PrimerTelefono = contacto.Telefonos != null ? (from telf in contacto.Telefonos select telf.Numero).First() : "No hay telefonos"
                                         };

            dgvContactos.DataSource = listaTodosLosContactos.ToList();


         

        }

        private void btnContactosTelefono_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = "";
            lblMensaje.Text = "";

            List<Contactos> listaContactos = gestion.ContactosAlfabeticamente(out string errores);
            if (errores != "")
            {
                MessageBox.Show(errores);

                return;
            }



            var lista = listaContactos.Where(contacto => contacto.Telefonos.Any(telf => telf.Numero == txtNumeroTelefono.Text)).Select(cont => new {cont.Nombre,CantTelefono=cont.Telefonos.Count,cont.IdGrupo });

            if (lista.Count() == 0)
            {
                lblMensaje.Text = $"NO HAY CONTACTOS DEL TELEFONO {txtNumeroTelefono.Text}";
                return;
            }
            lblMensaje.Text = $"CONTACTOS DEL NUMERO DE TELEFONO {txtNumeroTelefono.Text}";

            dgvContactos.DataSource = lista.ToList();

        }

        // NO BORRAR
        private void btnAltaContactos_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta al ejecutable de tu proyecto de consola
                string miRuta = Application.StartupPath;
                string rutaConsola = miRuta.Replace("CapaPresentacion", "CapaPresentacionConsola");
                string rutaEjecutableConsola = rutaConsola + @"\CapaPresentacionConsola.exe";
                // Crear un nuevo proceso
                Process procesoConsola = new Process();
                procesoConsola.StartInfo.FileName = rutaEjecutableConsola;

                // Estas opciones permiten que la consola se muestre
                procesoConsola.StartInfo.UseShellExecute = true;
                procesoConsola.StartInfo.CreateNoWindow = false;

                // Iniciar el proceso
                procesoConsola.Start();

                // Esperar a que el proceso termine (opcional)
                // consoleProcess.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el proceso de consola: {ex.Message}");
            }
        }

        private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
