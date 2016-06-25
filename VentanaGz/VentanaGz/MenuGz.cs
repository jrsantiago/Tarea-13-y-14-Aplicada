using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaGz
{
     
    public partial class MenuGz : Form
    {
          string contra="";
        public MenuGz()
        {
        
            InitializeComponent();
        }

        VentanaGz v = new VentanaGz();

        private DbVentanaGzEntities dbVentana = new DbVentanaGzEntities();
     
        private void eliminarUsuario(string contrasena)
        {
 
            Usuario usuario = (from a in dbVentana.Usuario
                               where a.contrasena == contrasena
                               select a).FirstOrDefault();

            dbVentana.Usuario.Remove(usuario);
            dbVentana.SaveChanges();
        }
         private void BotonBuscarContrasenActuralizar_Click(object sender, EventArgs e)
        {
            ListaractualizarUsuario();

        }
        public void actualizarUsuario()
        {
            Usuario usuario = (from u in dbVentana.Usuario
                               where u.contrasena == contra
                               select u).FirstOrDefault();

            try {
                usuario.nombre = NombreActuralizartextBox.Text;
                usuario.apellido = ApellidoActualizartextBox.Text;
                string sexo = "";
                if (MasculinoActualizarcheckBox.Checked)
                {
                    sexo = "M";

                }
                else if (FemeninoActualizarcheckBox.Checked)
                {
                    sexo = "F";
                }
                usuario.sexo = sexo;
                usuario.userName = userNameActuatextBox.Text;
                usuario.contrasena = ContrasenaActualizartextBox.Text;
            }
            catch (NullReferenceException) { MessageBox.Show("Uno de los Campos Esta Bacio.!!"); }

            if(NombreActuralizartextBox.Text !="" && ApellidoActualizartextBox.Text!=""&&userNameActuatextBox.Text!=""&&ContrasenaActualizartextBox.Text!="")
                 dbVentana.SaveChanges();

            }
        
        public void ListaractualizarUsuario()
        {
            contra = logContraActuatextBox.Text;

            string sexo = "";
            if(MasculinoActualizarcheckBox.Checked)
            {
                sexo = "M";

            }
            else if(FemeninoActualizarcheckBox.Checked)
            {
                sexo = "F";
            }
            using(DbVentanaGzEntities dbven = new DbVentanaGzEntities())
                {

               string nombr =dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).nombre.ToString();
                string apellido = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).apellido.ToString();
                sexo = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).sexo.ToString();
                string userName = dbven.Usuario.FirstOrDefault(x => x.contrasena ==contra).userName.ToString();
                string contrasena = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).contrasena.ToString();

                NombreActuralizartextBox.Text = nombr;
                ApellidoActualizartextBox.Text = apellido;
                if(sexo=="M")
                {
                    MasculinoActualizarcheckBox.Checked=true;
                }
                else if(sexo=="F")
                {
                    FemeninoActualizarcheckBox.Checked = true;
                }
                userNameActuatextBox.Text = userName;
                ContrasenaActualizartextBox.Text = contrasena;
                }
               
        }
       
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewUsuario usuario = new NewUsuario();
            usuario.Show();
        }

        private void MenuGz_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void MenuGz_FormClosed(object sender, FormClosedEventArgs e)
        {
            VentanaGz v = new VentanaGz();
            v.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizarUsuario();
            ActualizarUsuariopanel.Visible = false;
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActualizarUsuariopanel.Show();
        }

        private void BotonbackActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuariopanel.Visible = false;
        }

        private void EliminarUsuariobutton_Click(object sender, EventArgs e)
        {
            string contra = EliminarUsuariotextBox.Text;
            if(contra=="")
            {
                MessageBox.Show("Introdusca su Contrasena");
            }
            else if(contra!="")
            {
                  eliminarUsuario(contra);
                MessageBox.Show("Su Cuenta se a Borrado");
            }
                panelEliminar.Visible = false;
                
               

        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ActualizarUsuariopanel.Visible = false;
            panelEliminar.Show();
        }

        private void AtrasEliminarbutton_Click(object sender, EventArgs e)
        {
            panelEliminar.Visible = false;
        }
    }
}
