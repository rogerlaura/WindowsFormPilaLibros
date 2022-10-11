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
    public partial class Form1 : Form
    {
        Pila pila;
        Libro libro;
        public Form1(int maxpila)
        {
            pila = new Pila(maxpila);
            InitializeComponent();
        }

        private void btnapilar_Click(object sender, EventArgs e)
        {
            if (this.txttitulo.Text != "" && this.txtautor.Text != ""&& this.txtcantidad.Text != "")
            {
                libro = new Libro();
                libro.Id = int.Parse(this.txtid.Text);
                libro.Titulo = txttitulo.Text;
                libro.Autor = txtautor.Text;
                libro.Cantidadpagina = int.Parse(txtcantidad.Text.ToString());
                
                pila.ApilarPila(libro);

                listarpila();

            }
            else
            {
                MessageBox.Show("DIGITE UN VALOR EN LA CAJA DE TEXTO");
            }

            this.txttitulo.Text = "";
            this.txtautor.Text = "";
            this.txtcantidad.Text = "";
            this.txtid.Text = generarIdentificador().ToString();
        }

        private void btndesapilar_Click(object sender, EventArgs e)
        {
            pila.DesapilarPila();
            listarpila();
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            pila.VaciarPila();
            this.listalibros.Items.Clear();
        }
        public void listarpila()
        {
            Libro[] elementos = pila.LibrosPila();
            this.listalibros.Items.Clear();
            ListViewItem lista;
            for (int i = elementos.Length - 1; i >= 0; i--)
            {
                if (elementos[i] != null)
                {
                    lista = new ListViewItem(elementos[i].Id.ToString());
                    lista.SubItems.Add(elementos[i].Titulo);
                    lista.SubItems.Add(elementos[i].Autor);
                    lista.SubItems.Add(elementos[i].Cantidadpagina.ToString());

                    listalibros.Items.Add(lista);



                }

            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtid.Text = generarIdentificador().ToString();
        }
        public int generarIdentificador()
        {
            Random randon = new Random();
            int valor=randon.Next(0, 10000);
            return valor;
        }
    }
}
