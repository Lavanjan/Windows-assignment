using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Black_Lotus_CSharp
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source = localhost;port = 3306;Initial Catalog = black_lotus;User Id = root;password=''");
        int x;
        public Login()
        {
            InitializeComponent();
        //    bunifuTextbox2.PasswordChar = '';
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //private void txtUser(object sender, EventArgs e)
        //{
        //    bunifuTextbox1.text = "";
        //}

        //private void txtLeave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(bunifuTextbox1.text))
        //    {
        //        bunifuTextbox1.text = "User Name";
        //    }
        //}

        //private void txtPass(object sender, EventArgs e)
        //{
        //    bunifuTextbox2.text = "";
        //}

       

        //private void leavepass(object sender, EventArgs e)
        //{
        //    if(string.IsNullOrEmpty(bunifuTextbox2.text))
        //    {
        //        bunifuTextbox2.text = "Password";
        //    }
        //}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            x = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Admin where username = '" + bunifuMetroTextbox1.Text + "' and password = '" + bunifuMetroTextbox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            x = Convert.ToInt32(dt.Rows.Count.ToString());

            if(x == 0)
            {
                label6.Text = "Invalid Details !!!";
            }
            else
            {
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
            con.Close();
            
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox1.Text))
            {
                bunifuMetroTextbox1.Text = "Username";
            }
        }

        private void bunifuMetroTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox2.Text = "";
        }

        private void bunifuMetroTextbox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bunifuMetroTextbox2.Text))
            {
                bunifuMetroTextbox2.Text = "Password";
            }
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
