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
        public VentanaGz()
        {
            InitializeComponent();
        }

        private void VentanaGz_Load(object sender, EventArgs e)
        {

        }

        private void logbutton_Click(object sender, EventArgs e)
        {
            VentanaGzMenu menu = new VentanaGzMenu();
            menu.Show();
            
      
           
        }
    }
}
