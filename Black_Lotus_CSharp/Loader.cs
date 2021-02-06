using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_Lotus_CSharp
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            this.ControlBox = false;
            timer1.Start();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 631)
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
