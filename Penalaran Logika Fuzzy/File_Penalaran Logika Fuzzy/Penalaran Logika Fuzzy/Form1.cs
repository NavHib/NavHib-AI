using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penalaran_Logika_Fuzzy
{
    public partial class Form1 : Form
    {
        double a, b, c, x, MT, MS, MR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            miuT();
            miuS();
            miuR();
            Tb_miuT.Text = MT.ToString(); 
            Tb_miuS.Text = MS.ToString();
            Tb_miuR.Text = MR.ToString();
        }

        private void Hs_Scroll(object sender, ScrollEventArgs e)
        {
            Baca();
            Tampil();
        }
        void Baca()
        {
            x = Hs.Value;
            a = double.Parse(Tb_A.Text);
            b = double.Parse(Tb_B.Text);
            c = double.Parse(Tb_C.Text);        
        }
        void Tampil()
        {
            Tb_X.Text = x.ToString();
        }
        void miuS()
        {
            if (x > a & x < b)              
                MS = (x - a) / (b - a);              
            else if (x > b & x < c)        
                MS = (c - x) / (c - b);                
            else if (x <= a)                
                MS = 0;              
            else if (x >= c)              
                MS = 0;              
            else if (x == b)         
                MS = 1;               
        }
       void miuR()
        {
            if (x > a & x < b)
                MR = (b - x) / (b - a);           
            else if (x > b & x < c)
                MR = 0;           
            else if (x <= a)
                MR = 1;           
            else if (x >= c)
                MR = 0;           
            else if (x == b)
                MR = 0;           
        }
        void miuT()
        {
            if (x > a & x < b)
                MT = 0;
            else if (x > b & x < c)
                MT = (x - b) / (c - b);
            else if (x <= a)
                MT = 0;
            else if (x >= c)
                MT = 1;
            else if (x == b)
                MT = 0;
        }
    }
}
    

