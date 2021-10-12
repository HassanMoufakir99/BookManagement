using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Book_management
{
    public partial class Form_Add : Form
    {
        // var for con sql
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
        public int state;
        public Form_Add()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cat f = new Form_Cat();
            bunifuTransition1.ShowSync(f);
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select Cat from TbCat";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i<List.LongCount())
                {
                    comboBox1.Items.Add(List[i]);
                    i++;
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_books.Text=="" || txt_auther.Text=="")
            {
                MessageBox.Show("اكمل معلومات الكتاب اولا");
            }
            else
            {
                if (state==0)
                {
                    // Insert
             // for convert image to binary
            MemoryStream ma = new MemoryStream();
            pictureBox1.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
            var _cover = ma.ToArray();
            // sql commande
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert into Books(Title,Auther,Price,Cat,Date,Rate,Cover) values (@Title,@Auther,@Price,@Cat,@Date,@Rate,@Cover)";
            cmd.Parameters.AddWithValue("@Title", txt_books.Text);
            cmd.Parameters.AddWithValue("@Auther", txt_auther.Text);
            cmd.Parameters.AddWithValue("@Price", txt_price.Text);
            cmd.Parameters.AddWithValue("@Cat", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Date", Datepicker1.Value);
            cmd.Parameters.AddWithValue("@Rate", Rating1.Value);
            cmd.Parameters.AddWithValue("@Cover", _cover);
            cmd.ExecuteNonQuery();
            con.Close();
            Form_DailogeAdd frm_add = new Form_DailogeAdd();
            frm_add.Show();
                    this.Close();
                }
                else
                {
                    // Update
                    // for convert image to binary
                    MemoryStream ma = new MemoryStream();
                    pictureBox1.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();
                    // sql commande
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE  Books SET Title=@Title,Auther=@Auther,Price=@Price,Cat=@Cat,Date=@Date,Rate=@Rate,Cover=@Cover where Id=@id";
                    cmd.Parameters.AddWithValue("@Title", txt_books.Text);
                    cmd.Parameters.AddWithValue("@Auther", txt_auther.Text);
                    cmd.Parameters.AddWithValue("@Price", txt_price.Text);
                    cmd.Parameters.AddWithValue("@Cat", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Date", Datepicker1.Value);
                    cmd.Parameters.AddWithValue("@Rate", Rating1.Value);
                    cmd.Parameters.AddWithValue("@Cover", _cover);
                    cmd.Parameters.AddWithValue("@id",state);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form_DailogeEdit frm_add = new Form_DailogeEdit();
                    frm_add.Show();
                    this.Close();
                }
         
            }
            cmd.Parameters.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var res = dia.ShowDialog();
            if (res==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dia.FileName);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_books_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_auther_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_price_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
