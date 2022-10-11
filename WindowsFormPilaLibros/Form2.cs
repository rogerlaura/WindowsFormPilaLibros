using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPilaLibros
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncomenzar_Click(object sender, EventArgs e)
        {
            if (txtcapacidad.Text != "")
            {
                int dato = int.Parse(txtcapacidad.Text);
                Form1 f1 = new Form1(dato);
                f1.ShowDialog();
            }
            else{
                MessageBox.Show("Digite un valor");
            }
            
        }
    }
}
