using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        int[,] m;

        Random n = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);
            m = new int[f, c];
            dgv.RowCount = f;
            dgv.ColumnCount = c;
            llenar();
            imprimir();
            imprimir2();

        }

        void llenar()
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i,j]=n.Next(1,10);
                }
            }
        }

        void llenar2()
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero"));
                }
            }
        }

        void imprimir()
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    textBox3.AppendText(" " + m[i, j]);
                }
                textBox3.AppendText("\r\n");
            }
        }

        void imprimir2() //datagrid
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    dgv[j,i].Value = m[i, j];
                }
               
            }
        }
    }
}
