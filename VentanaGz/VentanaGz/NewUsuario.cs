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
    public partial class NewUsuario : Form
    {
        DbVentanaGzEntities dbVentana = new DbVentanaGzEntities();
        public NewUsuario()
        {
            InitializeComponent();
        }
        private void newUsuario()
        {
            string sexo1 = "";
            string contrase = NewContrasenatextBox.Text;



                if (MasculinocheckBox.Checked)
                {
                    sexo1 = "M";
                }
                else if (FemeninocheckBox.Checked)
                {
                    sexo1 = "F";
                }


                Usuario newUsuario = new Usuario()
                {
                    nombre = NewNombretextBox.Text,
                    apellido = NewApellidotextBox.Text,
                    sexo = sexo1,
                    userName = NewUserNametextBox.Text,
                    contrasena = NewContrasenatextBox.Text


                };
                if (contrase != RepitaContrasenatextBox.Text)
                  {
                     MessageBox.Show("Contraseanas no Coinciden");
                     NewContrasenatextBox.Text = "";
                     RepitaContrasenatextBox.Text = "";
                  }
            else
            {
                 dbVentana.Usuario.Add(newUsuario);
                dbVentana.SaveChanges();
                MessageBox.Show("Creado Exitoso");
                NewNombretextBox.Text = "";
                NewApellidotextBox.Text = "";
                NewUserNametextBox.Text = "";
                NewContrasenatextBox.Text = "";
                MasculinocheckBox.Checked = false;
                FemeninocheckBox.Checked = false;
                RepitaContrasenatextBox.Text = "";
                
            }

              
        }

        private void NewUsuario_Load(object sender, EventArgs e)
        {

        }

        private void NewUsuariobutton_Click(object sender, EventArgs e)
        {
            newUsuario();
            
        }
    }
}
