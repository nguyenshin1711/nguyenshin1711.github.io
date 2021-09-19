using System;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sothuhai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_click_Click(object sender, EventArgs e)
        {
            var sothunhat = txtsothunhat.Text;
            double nSoThuNhat = Convert.ToDouble(sothunhat);

            var sothuhai = txtsothuhai.Text;
            double nSoThuHai = Convert.ToDouble(sothuhai);

            var ketqua = nSoThuNhat + nSoThuHai;

            lblKetQua.Text = ketqua.ToString("N2");
        }

        private void btnTru_CLick_Click(object sender, EventArgs e)
        {
            var sothunhat = txtsothunhat.Text;
            double nSoThuNhat = Convert.ToDouble(sothunhat);

            var sothuhai = txtsothuhai.Text;
            double nSoThuHai = Convert.ToDouble(sothuhai);

            var ketqua = nSoThuNhat - nSoThuHai;

            lblKetQua.Text = ketqua.ToString();
        }

        private void btnChia_Click_Click(object sender, EventArgs e)
        {
            var sothunhat = txtsothunhat.Text;
            double nSoThuNhat = Convert.ToDouble(sothunhat);

            var sothuhai = txtsothuhai.Text;
            double nSoThuHai = Convert.ToDouble(sothuhai);

            var ketqua = nSoThuNhat / nSoThuHai;

            lblKetQua.Text = ketqua.ToString("N2");
        }
    }
}
