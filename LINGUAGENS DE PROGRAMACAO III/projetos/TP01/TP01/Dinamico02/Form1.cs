using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamico02
{
    public partial class Form1 : Form
    {
        Button[,] b = new Button[10, 20];
        char letra = 'A'; // 0100 0001 em decimal 65 e em hexa 41

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            int linha = 20;
            int coluna = 20;

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 20; ++j)
                {
                    b[i, j] = new Button();
                    b[i, j].BackColor = Color.Green;
                    b[i, j].Name = "Botão " + (i + 1);
                    b[i, j].Text = "Botão " + letra + (i + 1);
                    b[i, j].Location = new Point(coluna, linha);
                    coluna += 80;


                    Controls.Add(b[i, j]);
                }
                linha += 30;
                coluna = 20;
                ++letra;
            }
        } 
    }
}