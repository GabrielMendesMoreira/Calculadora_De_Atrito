using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02_181828
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

     


  

        private void coeficienteatrito_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Massa_TextChanged(object sender, EventArgs e)
        {

        }

        private void deslocamentto_TextChanged(object sender, EventArgs e)
        {

        }

        private void coeficiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULAR_Click(object sender, EventArgs e)
        {
            double Sin, Cos, resultado,anR;

            double ma = double.Parse(Massa.Text);
            double fo = double.Parse(ForcaF.Text);
            double co = double.Parse(coeficiente.Text);
            double an = double.Parse(angulo.Text);
            double de = double.Parse(deslocamentto.Text);

            anR = an * (Math.PI / 180);
            Sin = Math.Sin(anR);
            Cos = Math.Cos(anR);

            resultado = ((co * ((ma * 9.8) - (fo * Sin)) * de )* Cos);
            forcaA.Text = Convert.ToString(resultado);
        }

        private void LIMPAR_Click(object sender, EventArgs e)
        {
            string pergunta = "Deseja limpar o programa?";
            string sair = "LIMPAR O PROGRAMA";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes)
            {
                Massa.Clear();
                ForcaF.Clear();
                coeficiente.Clear();
                deslocamentto.Clear();
                angulo.Clear();
                forcaA.Clear();


            
            }
        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            string pergunta = "Deseja sair do programa?";
            string sair = "SAIR DO PROGRAMA";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
            if(MessageBox.Show(pergunta,sair,botao,icon,Default) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void forcaA_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void ForcaF_TextChanged(object sender, EventArgs e)
        {

        }

        private void angulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

       
    }
}
