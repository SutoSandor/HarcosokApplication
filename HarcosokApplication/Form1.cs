using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            Kapcsolat();
            KepessegHasznaloja_feltolt();
            HarcosokListaja();
        }
        private void Kapcsolat()
        {
            const string Adatbazis_letrehozas_SQL = @"CREATE TABLE IF NOT EXISTS harcosok 
                                                    (
                                                        id INTEGER AUTO_INCREMENT PRIMARY KEY,
                                                        nev VARCHAR(80) NOT NULL UNIQUE,
                                                        letrehozas DATE NOT NULL
                                                    );
                                                  CREATE TABLE IF NOT EXISTS kepessegek 
                                                    (
                                                        id INTEGER AUTO_INCREMENT PRIMARY KEY,
                                                        nev VARCHAR(80) NOT NULL UNIQUE,
                                                        leiras TEXT NOT NULL,
                                                        harcos_id INTEGER NOT NULL,
                                                        FOREIGN KEY(harcos_id) REFERENCES harcosok(id)
                                                    );";
           
            try
            {
                using (conn)
                {
                    conn = new MySqlConnection("Server=localhost;Database=cs_harcosok;Uid=root;Pwd=;");
                    conn.Open();
                    var letrehozas = conn.CreateCommand();
                    letrehozas.CommandText = Adatbazis_letrehozas_SQL;
                    letrehozas.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Adatbázis hiba: " + ex.Message);
                this.Close();
            }
        }
        private void letrehoz_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text.Length>0)
                {
                    string datum = DateTime.Now.Date.ToString("yyyy'-'MM'-'dd");
                    var insert = conn.CreateCommand();
                    insert.CommandText = "INSERT INTO harcosok (id, nev, letrehozas) VALUES (NULL, '" + name.Text + "', '" + datum + "');";
                    insert.ExecuteNonQuery();
                    HarcosokListaja();
                    KepessegHasznaloja_feltolt();
                }
                else
                {
                    MessageBox.Show("Add meg a harcos nevét!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Létezik már ilyen nevű harcos! ("+ ex.Message+ ")");
                this.Close();
            }
        }
        private void KepessegHasznaloja_feltolt()
        {
            KepessegHasznaloja.Items.Clear();
            try
            {
                MySqlDataReader reader = null;
                string select = "SELECT nev FROM harcosok";
                MySqlCommand command = new MySqlCommand(select,conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nev = (string)reader["nev"];
                    KepessegHasznaloja.Items.Add(nev);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        private void HarcosokListaja()
        {
            HarcosokLista.Items.Clear();
            try
            {
                MySqlDataReader reader = null;
                string select = "SELECT nev,letrehozas FROM harcosok";
                MySqlCommand command = new MySqlCommand(select, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nev = (string)reader["nev"];
                    DateTime datum = (DateTime)reader["letrehozas"];
                    string add = nev + " " + Convert.ToString(datum.ToString("yyyy'-'MM'-'dd"));
                    HarcosokLista.Items.Add(add);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void KepessegekListaja()
        {
            KepessegekLista.Items.Clear();
            try
            {
                string[] item_nev = HarcosokLista.GetItemText(HarcosokLista.SelectedItem).Split(' ');
                MySqlDataReader reader = null;
                string select = @"SELECT nev 
                                FROM kepessegek 
                                WHERE harcos_id = 
                                    (SELECT harcos_id 
                                    FROM kepessegek 
                                    LEFT JOIN harcosok 
                                    ON harcosok.id = kepessegek.harcos_id 
                                    WHERE harcosok.nev = '"+ item_nev[0] + "' " +
                                    "GROUP BY harcosok.id)";
                MySqlCommand command = new MySqlCommand(select, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nev = (string)reader["nev"];
                    KepessegekLista.Items.Add(nev);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LeirasMegjelenit()
        {
            KepessegText.Text = "";
            try
            {
                string kepesseg_nev = KepessegekLista.GetItemText(KepessegekLista.SelectedItem);
                MySqlDataReader reader = null;
                string select = @"SELECT leiras 
                                FROM kepessegek 
                                WHERE nev = '" + kepesseg_nev + "'";
                MySqlCommand command = new MySqlCommand(select, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string leiras = (string)reader["leiras"];
                    KepessegText.Text = leiras;
                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void hozzaad_Click(object sender, EventArgs e)  //Képesség felvétele gomb
        {
            if (KepessegNev.Text.Length > 0 && KepessegLeiras.Text.Length > 0)
            {
                MySqlDataReader reader = null;
                string select = "SELECT id FROM harcosok WHERE nev = '" + KepessegHasznaloja.GetItemText(KepessegHasznaloja.SelectedItem)+ "'";
                MySqlCommand command = new MySqlCommand(select, conn);
                reader = command.ExecuteReader();
                var insert = conn.CreateCommand();
                int id = 0;
                while (reader.Read())
                {
                     id = (int)reader["id"];
                }
                insert.CommandText = "INSERT INTO kepessegek (id, nev, leiras, harcos_id) VALUES (NULL, '" + KepessegNev.Text + "', '" + KepessegLeiras.Text + "', '" + id + "');";
                reader.Close();
                insert.ExecuteNonQuery();
                KepessegekListaja();
            }
            else
            {
                MessageBox.Show("A képesség neve és leírása nem lehet üres!");
            }
            
        }
        private void HarcosokLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            KepessegekListaja();
        }
        private void KepessegekLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeirasMegjelenit();
        }
        private void Torles_Click(object sender, EventArgs e)
        {
            try
            {
                string kepesseg_neve = KepessegekLista.GetItemText(KepessegekLista.SelectedItem);
                if (kepesseg_neve.Length > 0)
                {
                    string delete = "DELETE FROM kepessegek WHERE nev = '" + kepesseg_neve + "'";
                    var delete_command = conn.CreateCommand();
                    delete_command.CommandText = delete;
                    delete_command.ExecuteNonQuery();
                    KepessegekListaja();
                    KepessegText.Text = "";

                }
                else
                {
                    MessageBox.Show("Nincs kiválasztva képesség!");
                }
            }
            catch (MySqlException ex)
            {
                throw;
            }
           
        }
        private void modositas_Click(object sender, EventArgs e)
        {
            try
            {
                string kepesseg_nev = KepessegekLista.GetItemText(KepessegekLista.SelectedItem);
                if (kepesseg_nev.Length>0)
                {
                    string tartalom = KepessegText.Text;
                    var Update = conn.CreateCommand();
                    Update.CommandText = "UPDATE kepessegek SET leiras = @leiras WHERE nev = @nev";
                    Update.Parameters.AddWithValue("@leiras", tartalom);
                    Update.Parameters.AddWithValue("@nev", kepesseg_nev);
                    int erintettSorok = Update.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Nincs kiválasztva képesség!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
