using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            string thongdiep = txtThongdiep.Text;
            string luachon = cbbLuaChon.Text;
            MessageBox.Show(thongdiep + luachon);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cbbLuaChon.Items.Add("Con Hổ");
            cbbLuaChon.Items.Add("Con Báo");
            cbbLuaChon.Items.Add("Con Mèo");
            cbbLuaChon.Items.Add("Con Cáo");
            cbbLuaChon.Items.Add("Con Lợn");
        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            try
            {
                string read = "D:\\data.txt";
                StreamReader sr = new StreamReader(read);
                string noidung = sr.ReadToEnd();
                txtCau2.Text = noidung;
                sr.Close();
                MessageBox.Show("Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại"); 
            }


        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                string write = "D:\\data.txt";
                StreamWriter sw = new StreamWriter(write);
                sw.WriteLine(txtCau2.Text);
                sw.Close();
                MessageBox.Show("Thành Công");
            }
            catch (Exception)
            {

                MessageBox.Show("Thất bại");
            }
        }
    }
}
