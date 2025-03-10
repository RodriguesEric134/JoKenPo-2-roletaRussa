using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace JoKenPo_2_roletaRussa
{
    public partial class Frm_Identificacao : Form
    {
        private Dictionary<string, (int vitórias, int empates, int derrotas)> jogadores =
            new Dictionary<string, (int, int, int)>();

        public Frm_Identificacao()
        {
            InitializeComponent();
            this.AcceptButton = Btn_Entrar;
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            string nomeJogador = Txb_Nome.Text;

            if (string.IsNullOrEmpty(nomeJogador))
            {
                MessageBox.Show("Você precisa digitar o seu nome.");
                return;
            }

            if (!jogadores.ContainsKey(nomeJogador))
            {
                jogadores[nomeJogador] = (0, 0, 0);
            }

            // Criar o formulário Frm_Principal passando o dicionário e o nome do jogador
            Frm_Principal f = new Frm_Principal(jogadores, nomeJogador);

            f.ShowDialog();
        }

    }
}
