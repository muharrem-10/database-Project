using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form5 : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=cinema_database;Uid=root;Pwd='SQL1234';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            //adapter = new MySqlDataAdapter("SELECT * FROM movies,director,actor,movie_actor WHERE director.id = movies.Director_id and movies.id = movie_actor.Movie_id and movie_actor.Actor_id = actor.id", conn);
            adapter = new MySqlDataAdapter("SELECT * FROM movies", conn);
            adapter.Fill(dt);
            dgwlist.DataSource = dt;
            conn.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO movies(Film_name,Description,Time,Publish_date, Imdb_rate,Popularity,Director_id)" +
               "VALUES(@Name,@Dcs,@Time,@Publish,@Rate ,@Popularity,@Directorid)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Dcs", txtsurname.Text);
            cmd.Parameters.AddWithValue("@Time", txtbirth.Text);
            cmd.Parameters.AddWithValue("@Publish", txtpublish.Text);
            cmd.Parameters.AddWithValue("@Rate", txtrates.Text);
            cmd.Parameters.AddWithValue("@Popularity", txtpopularity.Text);
            cmd.Parameters.AddWithValue("@Directorid", txtcountry.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("kayıt eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM movies WHERE id=@id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("kayıt silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE movies SET Film_name=@name, Description= @Dcs, Time=@Time, Publish_date=@Publish," +
                "Imdb_rate=@Rate, Popularity=@Popularity, Director_id=@Directorid WHERE id=@id";

                                            
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Dcs", txtsurname.Text);
            cmd.Parameters.AddWithValue("@Time", txtbirth.Text);
            cmd.Parameters.AddWithValue("@Publish", txtpublish.Text);
            cmd.Parameters.AddWithValue("@Rate", txtrates.Text);
            cmd.Parameters.AddWithValue("@Popularity", txtpopularity.Text);
            cmd.Parameters.AddWithValue("@Directorid", txtcountry.Text);
            cmd.Parameters.AddWithValue("@id", txtid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("kayıt güncellendi");
        }

        private void dgwlist_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgwlist.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dgwlist.CurrentRow.Cells[1].Value.ToString();
                txtsurname.Text = dgwlist.CurrentRow.Cells[2].Value.ToString();
                txtbirth.Text = dgwlist.CurrentRow.Cells[3].Value.ToString();
                txtpublish.Text = dgwlist.CurrentRow.Cells[4].Value.ToString();
                txtrates.Text = dgwlist.CurrentRow.Cells[5].Value.ToString();
                txtpopularity.Text = dgwlist.CurrentRow.Cells[6].Value.ToString();
                txtcountry.Text = dgwlist.CurrentRow.Cells[7].Value.ToString();
            }
            catch
            {


            }
        }
    }
}
