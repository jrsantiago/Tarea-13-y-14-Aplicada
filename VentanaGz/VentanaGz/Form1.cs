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
    public partial class VentanaGz : Form
    {

        
       public string nombre;
       public  string contrasena;
       public string lognombre;
       public  string logcontra;
        public VentanaGz()
        {
           
            this.nombre = "";
            this.contrasena = "";
            logcontra = "";
            lognombre = "";
            InitializeComponent();
        }
        public void cerrar()
        {
            this.Close();
        }
        private void VentanaGz_Load(object sender, EventArgs e)
        {

        }

        private void logbutton_Click(object sender, EventArgs e)
        {
           
            lognombre = logNombretextBox.Text;
            logcontra = logContrasenatextBox.Text;
           


            try
            {
                using (DbVentanaGzEntities dbUsuario = new DbVentanaGzEntities())
                {
                    nombre = dbUsuario.Usuario.FirstOrDefault(x => x.userName == lognombre).userName.ToString();
                    contrasena = dbUsuario.Usuario.FirstOrDefault(x => x.contrasena == logcontra).contrasena.ToString();
                }
            }
            catch (NullReferenceException) { MessageBox.Show("La contraseña O Nombre de Usuario son Incorrectos"); } 
     
            if (lognombre == nombre && logcontra == contrasena && lognombre != "" && logcontra!="")
            {
                MenuGz menu = new MenuGz();
                this.Visible = false;
                menu.Show();
            }
                

          
           
      
           
        }
    }
}
