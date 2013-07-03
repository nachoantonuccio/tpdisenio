using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VentasDeEntradas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLugar_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            seleccionarFecha.Items.Add("15 de Julio");
            seleccionarFecha.Items.Add("16 de Julio");
            seleccionarFecha.Items.Add("17 de Julio");
            seleccionarFecha.Items.Add("18 de Julio");
            seleccionarFecha.Items.Add("19 de Julio");
            seleccionarFecha.Items.Insert(0, "--Selecione una Fecha--");
            
            seleccionarTipo.Items.Add("Menor");
            seleccionarTipo.Items.Add("Mayor");
            seleccionarTipo.Items.Add("Jubilado");
            seleccionarTipo.Items.Add("Anticipada");
            seleccionarTipo.Items.Add("Devolución");
            seleccionarTipo.Items.Insert(0, "--Seleccione Tipo de Entrada--");

            seleccionarFecha.SelectedIndex = 0;
            seleccionarTipo.SelectedIndex = 0;
        }

        
        
    }
}
