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

namespace Shoprite_Inventory_Management_System
{
    public partial class Screens : Form
    {

        const string connectionString = "Server = localhost; Database=inventorysystem;User id=root;Password=Eselase12/.;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlDataReader reader;

        public Screens()
        {
            InitializeComponent();
        }

        private void catCancelBut(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void createProductButton(object sender, EventArgs e)
        {

        }

        private void cancelProductButton(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void productButtonClick(object sender, EventArgs e)
        {
            Generators generator = new Generators();
            try
            {
                const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
                //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
                MySqlConnection sqlConnection = new MySqlConnection(connectionString);
                sqlConnection.Open();

                string sqlStatement =
                    $"INSERT INTO `Product`(`Product_Name`, `Unit_Price`,`Product_Code`, `Discription`, `Quantity`) VALUES ('{nametextBox.Text}', '{pricetextBox.Text}', '{generator.randomProductcode(5)}', '{distextBox.Text}',{quantityTextBox.Text})";

                System.Console.WriteLine(sqlStatement);

                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show($"{this.nametextBox.Text} has been added successfully");
                nametextBox.Clear();
                pricetextBox.Clear();
                distextBox.Clear();
                quantityTextBox.Clear();
                Admin_Screen admin = new Admin_Screen();
                admin.productButton();



            }
            catch (Exception eb)
            {
                MessageBox.Show($"An error occured {eb.StackTrace}");
                throw;
            }
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void catComboBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            const string connectionString = "server = localhost; Initial Catalog=inventorysystem;User id=root;Password=Eselase12/.;";
            //const String connection = "server = localhost; database=inventorysystem; uid=root; pwd=Eselase12/.;";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            String statement = $"SELECT Category_Name FROM Category";
            MySqlCommand cmd = new MySqlCommand(statement, sqlConnection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                catComboBox.Items.Add(name);
            }
        }
    }
}
