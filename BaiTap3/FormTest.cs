using BasicControl.Enitiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    
    public partial class FormTest : Form
    {
        Students student;
        public FormTest(string idStudent="2")
        {
            InitializeComponent();

            student = Students.Get(idStudent);
            
            if(student == null)
            {
                MessageBox.Show($"Không tìm thấy student có mã là {idStudent}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtHoTen.Text = student.FullName;
                txtNoiSinh.Text = student.POB;
                txtQueQuan.Text = student.HomeTown;
                dtpNgaySinh.Value = student.DOB;

                if (student.Gender == EGender.Nam)
                {
                    rdNam.Checked = true;
                }
                else if (student.Gender == EGender.Nu)
                {
                    rdbNu.Checked = true;
                }
                else
                    rdbKhac.Checked = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtQueQuan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
