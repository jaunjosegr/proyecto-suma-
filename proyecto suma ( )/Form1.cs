using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_suma____
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Class_suma osuma = new Class_suma();

            osuma.N1 = int.Parse(textBox2.Text);
            osuma.N2 = int.Parse(textBox4.Text);

            textBox3.Text = osuma.PV().ToString();

            Class_suma OPV = new Class_suma(int.Parse(textBox2.Text),
            int.Parse(textBox4.Text)); textBox3.Text = OPV.PV().ToString();
        }
    }
}
