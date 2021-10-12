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

namespace Book_management
{
    public partial class Form_Cat : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form_Cat()
        {
            InitializeComponent();
        }

        private void Form_Cat_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Cat_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
            Form_Add f = new Form_Add();
            f.Show();
            */
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txt_Cat.Text != "")
            {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert into TbCat(Cat) values (@Cat)";
            cmd.Parameters.AddWithValue("@Cat",txt_Cat.Text);
            cmd.ExecuteNonQuery();
            con.Close();
                Form_DailogeAdd frm_add = new Form_DailogeAdd();
                frm_add.Show();
                this.Close();
            }
            else
            {
                Form_MessageBox f = new Form_MessageBox();
                f.Show();
                
            }
            
        }
    }
}
