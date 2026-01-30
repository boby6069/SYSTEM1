using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTracksystem
{
    public partial class Kiosk : Form
    {
        public Kiosk()
        {
            InitializeComponent();
        }

       
      
        private void label1_Click_1(object sender, EventArgs e)
        {
             Menu menuForm = new Menu();
            menuForm.Show();
            this.Hide();
        }
    }
}
