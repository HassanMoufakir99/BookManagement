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
    public partial class Form1 : Form
    {
        // var for move form
        int p0;
        int x;
        int y;
        // var for sqlcon
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                 WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            p0 = 1;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            p0 = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (p0 == 1)
            { 
            this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString =( @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
            var sql = "select Id,Title,Auther,Price,Cat from Books";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "العنوان";
            dataGridView1.Columns[2].HeaderText = "المؤلف";
            dataGridView1.Columns[3].HeaderText = "السعر";
            dataGridView1.Columns[4].HeaderText = "الصنف";

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form_Add frm_add = new Form_Add();
            frm_add.btn_add.ButtonText = "الاضافة";
            frm_add.state = 0;
            bunifuTransition1.ShowSync(frm_add);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Form_Detailes frm_add = new Form_Detailes();
            bunifuTransition1.ShowSync(frm_add);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select Title,Auther,Price,Cat,Date,Rate from Books where Id=@id";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }
                frm_add.txt_books.Text = List[0];
                frm_add.txt_auther.Text = List[1];
                frm_add.txt_price.Text = List[2];
                frm_add.bunifuMaterialTextbox1.Text = List[3];
                frm_add.Datepicker1.Text = List[4];
                frm_add.Rating1.Value = Convert.ToInt16(List[5]);
                con.Close();
                // read image from database
                con.Open();
                cmd.CommandText = "select cover from Books where Id=@idimage";
                cmd.Parameters.AddWithValue("@idimage", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_add.pictureBox1.Image = Image.FromStream(ma);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Delete from Books Where Id=@id";
            cmd.Parameters.AddWithValue("@id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            cmd.ExecuteNonQuery();
            con.Close();
            Form_DailogeDelete f = new Form_DailogeDelete();
            f.Show();
            cmd.Parameters.Clear();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Form_Add frm_add = new Form_Add();
            frm_add.btn_add.ButtonText = "التعديل";
            frm_add.state =Convert.ToInt16( dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_add);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hassan\Desktop\c sharp jeux\Book management\Book management\DbBook.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "select Title,Auther,Price,Cat,Date,Rate from Books where Id=@id";
                cmd.Parameters.AddWithValue("@id", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                }
                frm_add.txt_books.Text = List[0];
                frm_add.txt_auther.Text = List[1];
                frm_add.txt_price.Text = List[2];
                frm_add.comboBox1.Text = List[3];
                frm_add.Datepicker1.Text = List[4];
                frm_add.Rating1.Value =Convert.ToInt16( List[5]);
                con.Close();
                // read image from database
                con.Open();
                cmd.CommandText = "select cover from Books where Id=@idimage";
                cmd.Parameters.AddWithValue("@idimage", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ma = new MemoryStream();
                ma.Write(img, 0, img.Length);
                frm_add.pictureBox1.Image = Image.FromStream(ma);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }
    }
}
