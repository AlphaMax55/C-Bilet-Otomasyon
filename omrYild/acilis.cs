using omrYild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace omryild
{
    public partial class acilis : Form
    {
        public acilis()
        {
          InitializeComponent();
             sayac.Enabled = true;
            sayac.Interval = 5000; 
        }

        private void acilis_Load(object sender, EventArgs e)
        {

        }

      

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
                sayac.Stop();
                this.Close();
               
            }
           
           
        }
    
}
