using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_12_con_giap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string can = "";

            switch (Convert.ToInt32(txtnam.Text) % 10)
            {
                case 0:
                    can = "canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "Ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỷ";
                    break;
            }
            string chi = "";
            switch (Convert.ToInt32(txtnam.Text) % 12) 
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Đậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "SỬU";
                    break;
                case 6:
                    chi = "DẦN";
                    break;
                case 7:
                    chi = "Mão";
                    break;
                case 8:
                    chi = "Thình";
                    break;
                case 9:
                    chi = "Tỵ";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            txtKQ.Text = can + " " + chi;
        }
    }
}
