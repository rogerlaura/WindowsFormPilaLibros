using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPilaLibros
{
    internal class Pila
    {
        private int tope, maxpila;
        private Libro[] contenedorpila;
        public Pila(int maxpila)
        {
            this.tope = -1;
            this.maxpila = maxpila;
            this.contenedorpila = new Libro[maxpila];
        }
        public bool Pilavacia()
        {
            if (this.tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Pilallena()
        {
            if (this.tope == maxpila - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ApilarPila(Libro dato)
        {
            if (this.Pilallena() == false)
            {
                this.tope++;
                this.contenedorpila[tope] = dato;
                MessageBox.Show("SE APILO EL ELEMENTO " + this.contenedorpila[tope].Titulo + " EN LA PILA");
            }
            else
            {
                MessageBox.Show("LA PILA ESTA LLENA");
            }
        }
        public void DesapilarPila()
        {
            if (this.Pilavacia() == false)
            {
                MessageBox.Show("SE DASAPILO EL ELEMENTO " + this.contenedorpila[tope].Titulo + " DE LA PILA ");
                this.contenedorpila[tope] = null;
                this.tope--;
            }
            else
            {

                MessageBox.Show("LA PILA ESTA VACIA");
            }
        }
        public void VaciarPila()
        {
            if (this.Pilavacia() == false)
            {
                for (int i = 0; i <= this.tope; i++)
                {
                    this.contenedorpila[i] = null;
                }
                this.tope = -1;
                MessageBox.Show("SE VACIO LA PILA SATISFACTORIAMENTE");
            }
            else
            {
                MessageBox.Show("LA PILA ESTA VACIA");
            }
        }
        public Libro[] LibrosPila()
        {
            return this.contenedorpila;
        }
        public void mostrarsoloautoresX()
        {
            Libro[] libroautores = new Libro[10];
            for (int i = 0; i <= tope; i++)
            {
                if (this.contenedorpila[i].Autor == "Pepito")
                {
                    libroautores[0] = this.contenedorpila[i];
                }
            }
        }
    }
}
