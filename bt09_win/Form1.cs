using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT8
{
    public partial class Form1 : Form
    {
        List<LopHoc> lOPHOCs;
        List<Học_Viên> hocViens;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Khoitaodulieu();
        }

        private void Khoitaodulieu()
        {
            lOPHOCs = new List<LopHoc>
         {
             new LopHoc {MaLH="L01",TenLopHoc=" Công Nghệ Thông Tin"},
                 new LopHoc {MaLH="L02",TenLopHoc="Trí Tuệ AI"},
              new LopHoc {MaLH="L03",TenLopHoc="Lập Trinh OOP"},
           new LopHoc {MaLH="L04",TenLopHoc="Kỹ Thuật Lập Trình"},
           new LopHoc {MaLH="L05",TenLopHoc="Tin Học"},

         };
            hocViens = new List<Học_Viên>
            {
         // thêm mã học viên
         new Học_Viên{MaHV=9,TenHocVien="Trần Thanh A ",MaLH="L01"},
                 new Học_Viên{MaHV=9,TenHocVien="Trần Thanh B",MaLH="L01"},
                  new Học_Viên{MaHV=0,TenHocVien="Trần Thanh C",MaLH="L01"},
                   new Học_Viên{MaHV=2,TenHocVien="Trần Thanh D",MaLH="L02"},
                    new Học_Viên{MaHV=3,TenHocVien="Trần Thanh E",MaLH="L04"},
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
