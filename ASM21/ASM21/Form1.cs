using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM21
{
    public partial class Form1 : Form
    {
        public bool IsLoggedIn { get; private set; } = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtTaikhoan.Text == "") || (txtMatkhau.Text == ""))
            {
                MessageBox.Show("Please enter information", "Thông báo");

            }
            else
            {
                if ((txtTaikhoan.Text == "vanduypro1") && (txtMatkhau.Text == "Duy123"))
                {
                    IsLoggedIn = true;
                    MessageBox.Show("Successful login!");
                    this.Hide(); // Ẩn FormLogin nhưng không đóng hoàn toàn
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close(); // Đóng FormLogin sau khi Form2 được đóng
                }
                else
                {
                    MessageBox.Show("Login Failed!", "Thông báo");
                }
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
