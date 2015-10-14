using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo24_09_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Dividir(TextBox a, TextBox b)//pasa como parametros las cajas de texto
        {
            //si cambiamos el nombre de la clase y aceptamos los cambios cuando marque el error se cambiara el nombre en todo el codigo que se use 
            double n1, n2 =0.0 , resultado = 0.0;
            try
            {
                 n1 = Convert.ToDouble(a.Text);
                 n1 = Convert.ToDouble(b.Text);
                 resultado = n1+n2;
 
            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message,"Parametros en C#",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return resultado;  //n1 + n2;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dividir(txt1,txt2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dividir(txt2,txt1).ToString());
        }
    }
}
