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
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=cinema_database;Uid=root;Pwd='SQL1234';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        void VeriGetir()
        {
            dt = new DataTable();
            conn.Open();
            //adapter = new MySqlDataAdapter("SELECT * FROM movies,director,actor,movie_actor WHERE director.id = movies.Director_id and movies.id = movie_actor.Movie_id and movie_actor.Actor_id = actor.id", conn);
            adapter = new MySqlDataAdapter("SELECT * FROM categories", conn);
            adapter.Fill(dt);
            dgwlist.DataSource = dt;
            conn.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO categories(Category_name,Description)" +
               "VALUES(@CName,@Description)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CName", txtname.Text);
            cmd.Parameters.AddWithValue("@Description", txtsurname.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            VeriGetir();
            MessageBox.Show("kayıt eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM categories WHERE id=@id";
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
            string sql = "UPDATE categories SET Category_name =@Name, Description=@Description WHERE id=@id";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Description", txtsurname.Text);
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
               
            }
            catch
            {


            }
        }
    }
}
