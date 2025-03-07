using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{

    public partial class Frm_Roleta : Form
    {
        private string jogador;
        private PictureBox opcaoImagem;
        private Random random = new Random();

        public Frm_Roleta(string jogador, PictureBox opcaoImagem)
        {
            InitializeComponent();
            this.jogador = jogador;
            this.opcaoImagem = opcaoImagem;
        }

        public void JogarRoletaRussa(string jogador)
        {
            // Exibe o jogador ou bot na label
            Lbl_ExibeResultado.Text = $"{jogador} Perdeu!";
            Lbl_ExibeRoleta.Text = $"{jogador} joga a roleta russa";

            // Simula a roleta russa com um número aleatório entre 1 e 6
            int resultadoRoleta = random.Next(1, 7);  // 1 a 6

            // A munição está na posição 1
            if (resultadoRoleta == 1)
            {
                // Se a roleta disparar
                if (jogador == "Jogador")
                {
                    Lbl_ExibeRoleta.Text = "O Jogador foi derrotado!";
                    // Exibe a imagem de tiro
                    opcaoImagem.Image = Properties.Resources.roleta_russa_tiro;
                    MessageBox.Show("A roleta russa disparou! Você perdeu!");
                }
                else
                {
                    Lbl_ExibeRoleta.Text = "O Bot foi derrotado!";
                    // Exibe a imagem de tiro
                    opcaoImagem.Image = Properties.Resources.roleta_russa_tiro;
                    MessageBox.Show("A roleta russa disparou! O Bot perdeu!");
                }
            }
            else
            {
                // Se a roleta não disparar
                if (jogador == "Jogador")
                {
                    Lbl_ExibeRoleta.Text = "A roleta russa não disparou. Você volta a jogar!";
                    // Exibe a imagem sem tiro
                    opcaoImagem.Image = Properties.Resources.roleta_russa_sem_tiro;
                    // O jogador volta para o jogo de jokenpo
                }
                else
                {
                    Lbl_ExibeRoleta.Text = "A roleta russa não disparou. O Bot volta a jogar!";
                    // Exibe a imagem sem tiro
                    opcaoImagem.Image = Properties.Resources.roleta_russa_sem_tiro;
                    // O bot volta para o jogo de jokenpo
                }
            }
        }
    }
}    
