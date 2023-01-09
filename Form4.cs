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
    public partial class Form4 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=cinema_database;Uid=root;Pwd='SQL1234';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        string cinsiyet;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            //adapter = new MySqlDataAdapter("SELECT * FROM movies,director,actor,movie_actor WHERE director.id = movies.Director_id and movies.id = movie_actor.Movie_id and movie_actor.Actor_id = actor.id", conn);
            adapter = new MySqlDataAdapter("SELECT * FROM director", conn);
            adapter.Fill(dt);
            dgwlist.DataSource = dt;
            conn.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO director(Name,Surname,Birth_date,Gender,Country)" +
               "VALUES(@Name,@Surname,@Birth_date,@Gender,@Country)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Surname", txtsurname.Text);
            cmd.Parameters.AddWithValue("@Birth_date", txtbirth.Text);
            cmd.Parameters.AddWithValue("@Gender", cinsiyet);
            cmd.Parameters.AddWithValue("@Country", txtcountry.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("kayıt eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM director WHERE id=@id";
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
            string sql = "UPDATE director SET Name =@Name, Surname=@Surname," +
                "Birth_date=@Birth_date, Gender=@Gender, Country=@Country WHERE id=@id";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Surname", txtsurname.Text);
            cmd.Parameters.AddWithValue("@Birth_date", txtbirth.Text);
            cmd.Parameters.AddWithValue("@Gender", cinsiyet);
            cmd.Parameters.AddWithValue("@Country", txtcountry.Text);
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
                string cins = dgwlist.CurrentRow.Cells[4].Value.ToString();
                if (cins == "M")
                {
                    rbM.Checked = true;
                }
                else
                {
                    rbF.Checked = true;
                }
                txtcountry.Text = dgwlist.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {


            }
        }

        private void rbM_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "M";
        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "F";
        }
    }
}
