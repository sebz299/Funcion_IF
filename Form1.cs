using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcion_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            //Obligar al ususario a que ingrese una edad valida
            if (int.TryParse(textBox1.Text, out int edad))
            {
                if  (edad > 0)
                {

                }
                if (edad > 17)
                {
                    MessageBox.Show("Eres mayor de edad");
                }
                else
                {
                    MessageBox.Show("Es menor de edad");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una edad valida");
            }
        }
    }
}
