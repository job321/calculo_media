using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_media
{    
   

    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            media = (n1 + n2 + n3) / 3;
          
            txtMedia.Text = media.ToString();

            if (media < 5)
                MessageBox.Show("REPROVADO");
            else if (media >= 7)
                MessageBox.Show("APROVADO");
            else
                MessageBox.Show("RECUPERAÇÃO");





        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
                e.KeyChar = ',';
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {  
            if (e.KeyChar == ',' || e.KeyChar == '.')
                e.KeyChar = ',';
           else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {//  aceitando apenas numeros e ponto ou virgula.
            if (e.KeyChar == ',' || e.KeyChar == '.')
                e.KeyChar = ',';
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }
    }
}
