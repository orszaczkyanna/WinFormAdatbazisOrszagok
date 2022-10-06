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

namespace WinFormAdatbazis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AdatbazisFeltoltese();
        }

        private void AdatbazisFeltoltese()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost"; //adatbázis helye
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "orszagok"; //adatbázis neve
            sb.CharacterSet = "utf8";
            MySqlConnection connection = new MySqlConnection(sb.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand sql = connection.CreateCommand();

                //lekérdezés futtatása:
                sql.CommandText = "SELECT `id`,`orszag`,`fovaros`,`terulet`,`allamforma` FROM `orszagok`;";

                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int beId = dr.GetInt32("id");
                        string beOrszag = dr.GetString("orszag");
                        string beFovaros = dr.GetString("fovaros");
                        decimal beTerulet = dr.GetDecimal("terulet");
                        string beAllamforma = dr.GetString("allamforma");                        
                        Orszagok ujOrszag = new Orszagok(beId, beOrszag, beFovaros, beTerulet, beAllamforma);
                        listBoxOrszagok.Items.Add(ujOrszag);
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void listBoxOrszagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrszagok.SelectedIndex < 0) //ha nincs elem kiválasztva
            {
                return; //ne csináljon semmit
            }
            else
            {
                Orszagok kivalasztott = (Orszagok)listBoxOrszagok.SelectedItem;
                tbId.Text = kivalasztott.Id.ToString();
                tbFovaros.Text = kivalasztott.Fovaros.ToString();
                tbTerulet.Text = kivalasztott.Terulet.ToString();
                tbAllamforma.Text = kivalasztott.Allamforma.ToString();

            }
        }
    }
}
