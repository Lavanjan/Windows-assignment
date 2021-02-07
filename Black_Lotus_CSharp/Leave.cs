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

namespace Black_Lotus_CSharp
{
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
            
        }
        DataTable table;
        MySqlConnection Connection = new MySqlConnection(@"Data Source = localhost;port = 3305;Initial Catalog = wfm-cms;User Id = root;password='root'");
        MySqlCommand command;
        MySqlDataReader mdr;
        private void bunifuMetroTextbox_scusid_OnValueChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Connection.Open();
            String query = "SELECT * FROM employee WHERE id =" + int.Parse(bunifuMetroTextbox_clientId.Text);
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                bunifuMetroTextbox_ClientName.Text = mdr.GetString("Name");
              //  bunifuMetroTextbox_ProjectName.Text = mdr.GetString("Lastname");


            }
            else
            {
                MessageBox.Show("No Data Found");

            }
            Connection.Close();
        }

      /*  private void button6_Click(object sender, EventArgs e)
        {
            Connection.Open();
            String query = "SELECT * FROM product WHERE id =" + int.Parse(bunifuMetroTextbox1.Text);
            command = new MySqlCommand(query, Connection);
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                bunifuMetroTextbox3.Text = mdr.GetString("Name");
                bunifuMetroTextbox2.Text = mdr.GetString("Color");
                bunifuMetroTextbox_price.Text = mdr.GetString("Price");


            }
            else
            {
                MessageBox.Show("No Data Found");

            }
            Connection.Close();
        }*/
        public void viewdata()
        {
           
            String select = "select * from attendance";
            MySqlCommand comd = new MySqlCommand(select, Connection);
            MySqlDataAdapter da = new MySqlDataAdapter(comd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.AutoGenerateColumns = false;
            bunifuCustomDataGrid1.DataSource = dt;
            Connection.Close();
        }
        private void Sale_Load(object sender, EventArgs e)
        {
            

            String time = DateTime.Now.ToString("HH:mm:ss");
            String date = DateTime.Now.ToString("yyyy:mm:dd");
            viewdata();
        }

        private void button_addprod_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox_ClientName.Text.Length==0|| bunifuMetroTextbox_clientId.Text.Length==0|| bunifuMetroTextbox_ProjectName.Text.Length==0 || bunifuMetroTextbox3_OrgName.Text.Length==0 || bunifuMetroTextbox2_Budjet.Text.Length==0)
            {
                MessageBox.Show("Please Fill All Boxes");
            }
            else
            {
                //String select = "select * from project where ID='"+ bunifuMetroTextbox1.Text+ "'and Quantity > '"+bunifuMetroTextbox_Status.Text+"' ";
                //MySqlCommand comd = new MySqlCommand(select, Connection);
                //MySqlDataAdapter da = new MySqlDataAdapter(comd);
                //DataTable dt = new DataTable();
                //da.Fill(dt);

                Connection.Open();
                //if (dt.Rows.Count>=1)
                //{
                    string insert = "INSERT INTO `attendance`(`EmployeeName`, `Date`, `Days`, `Reason`) VALUES ('" + bunifuMetroTextbox_ClientName.Text+ "','" + bunifuMetroTextbox_ProjectName.Text + "','" + bunifuMetroTextbox3_OrgName.Text + "','" + bunifuMetroTextbox2_Budjet.Text + "')";
                    //string decress = "update product set Quantity=Quantity-'" + bunifuMetroTextbox_Status.Text + "'where ID ='"+bunifuMetroTextbox1.Text+"'";
                    MySqlCommand comd1 = new MySqlCommand(insert, Connection);
                    //MySqlCommand comd2 = new MySqlCommand(decress, Connection);
                    
                    if (comd1.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Successfull !!!");
                    //comd2.ExecuteNonQuery();
                    viewdata();
                        bunifuMetroTextbox_clientId.Text = "";
                        //bunifuMetroTextbox_Duraiton.Text = "";
                        //bunifuMetroTextbox_Status.Text = "";
                       // bunifuMetroTextbox1.Text = "";
                        bunifuMetroTextbox2_Budjet.Text = "";
                        bunifuMetroTextbox3_OrgName.Text = "";
                       // bunifuMetroTextbox4.Text = "";
                        bunifuMetroTextbox_ClientName.Text = "";
                        bunifuMetroTextbox_ProjectName.Text = "";



                    }
                //}
                else
                {
                    MessageBox.Show("Item Not Available Here");
                }
                Connection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_Cus cus = new add_Cus();
            cus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale sal = new Sale();
            sal.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox_search_OnValueChanged(object sender, EventArgs e)
        {
            DataView view = new DataView(table);
            view.RowFilter = string.Format("Name LIKE '%{0}%'", bunifuMetroTextbox_search.Text);
            bunifuCustomDataGrid1.DataSource = view;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Details sd = new Sales_Details();
            sd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Employee prod = new Employee();
            prod.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox_Duraiton_OnValueChanged(object sender, EventArgs e)
        {

        }
        //private void bunifuCustomDataGrid1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    bunifuMetroTextbox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
        //    bunifuMetroTextbox_ClientName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
        //    bunifuMetroTextbox_ProjectName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
        //    bunifuMetroTextbox3_OrgName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
        //    bunifuMetroTextbox2_Budjet.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
        //    bunifuMetroTextbox_Duraiton.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
        //    bunifuMetroTextbox_Status.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
        //}

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMetroTextbox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            bunifuMetroTextbox_ClientName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            bunifuMetroTextbox_ProjectName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            bunifuMetroTextbox3_OrgName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            bunifuMetroTextbox2_Budjet.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            //bunifuMetroTextbox_Duraiton.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            //bunifuMetroTextbox_Status.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
        }
        public void openConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();

            }
        }
        public void closeConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public void Populate()
        {
            string selectQuery = "SELECT * FROM attendance";
            table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Connection);
            adapter.Fill(table);
            bunifuCustomDataGrid1.DataSource = table;
        }

        public void executeQuery(string query)
        {
            try
            {

                openConnection();
                command = new MySqlCommand(query, Connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    Popup pp = new Popup();
                    pp.ShowDialog();
                    // MessageBox.Show("Query Executed");

                }
                else
                {
                    popupNon pnon = new popupNon();
                    pnon.ShowDialog();
                    //  MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void button_updateprod_Click(object sender, EventArgs e)
          //  "INSERT INTO `project`(`Date`, `ClientName`, `ProjectName`, `OrgName`, `Budget`, `Duration`,`Status`) VALUES ('" + DateTime.Now.ToString("yyyy:mm:dd")+ "','"+ bunifuMetroTextbox_ClientName.Text+ "','" + bunifuMetroTextbox_ProjectName.Text + "','" + bunifuMetroTextbox3_OrgName.Text + "','" + bunifuMetroTextbox2_Budjet.Text + "','" + bunifuMetroTextbox_Duraiton.Text + "','" + bunifuMetroTextbox_Status.Text + "')";
        {
            // Update Query
            string updateQuery = "UPDATE attendance SET  EmployeeName = '" + bunifuMetroTextbox_ClientName.Text + "',Date = '" + bunifuMetroTextbox_ProjectName.Text + "',Days = '" + bunifuMetroTextbox3_OrgName.Text + "',Reason = '" + bunifuMetroTextbox2_Budjet.Text + "' WHERE ID = " + int.Parse(bunifuMetroTextbox1.Text);
            executeQuery(updateQuery);
            // Popup pp = new Popup();
            //pp.ShowDialog();
            // System.Windows.Forms.MessageBox.Show("Details Updated");
            Populate();

            // For Empty textbox after update
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox_ClientName.Text = "";
            bunifuMetroTextbox_ProjectName.Text = "";
            bunifuMetroTextbox3_OrgName.Text = "";
            bunifuMetroTextbox2_Budjet.Text = "";
            //bunifuMetroTextbox_Duraiton.Text = "";
            //bunifuMetroTextbox_Status.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee product = new Employee();
            product.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Client client = new Client();
            client.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Project project = new Project();
            project.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Leave leave = new Leave();
            leave.Show();
        }
    }
}
