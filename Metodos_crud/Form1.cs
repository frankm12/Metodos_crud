using System;
using CapaNegocios;

namespace Metodos_crud
{
    public partial class Form1 : Form
    {
        CN_Productos objectoCN = new CN_Productos();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }
        private void MostrarProdctos()
        {
            dataGridView1.DataSource = objectoCN.MostrarProd();
        }
    }
}
