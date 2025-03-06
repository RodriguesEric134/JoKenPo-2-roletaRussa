using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        List<string> opcoesSelecionadas = new List<string>();
        Random random = new Random();

        private void Opc_Pedra_Click(object sender, EventArgs e)
        {
            SelecionarOpcao(Opc_Pedra, "pedra");
        }

        private void Opc_Papel_Click(object sender, EventArgs e)
        {
            SelecionarOpcao(Opc_Papel, "papel");
        }

        private void Opc_Tesoura_Click(object sender, EventArgs e)
        {
            SelecionarOpcao(Opc_Tesoura, "tesoura");
        }

        private void SelecionarOpcao(PictureBox opcao, string nome)
        {
            if (opcoesSelecionadas.Contains(nome)) return;

            opcoesSelecionadas.Add(nome);

            switch (nome)
            {
                case "pedra":
                    opcao.Image = Properties.Resources.mao_circulada;
                    break;
                case "papel":
                    opcao.Image = Properties.Resources.papel_de_mao_circulada;
                    break;
                case "tesoura":
                    opcao.Image = Properties.Resources.tesouras_circulada;
                    break;
            }

            if (opcoesSelecionadas.Count == 2)
            {
                DefinirImagemExcluida();
                JogadaBot(); // O Bot joga logo após a seleção do jogador
            }

            if (opcoesSelecionadas.Count > 2)
            {
                ResetarSelecoes();
            }
        }

        private void DefinirImagemExcluida()
        {
            if (!opcoesSelecionadas.Contains("pedra"))
                Opc_Pedra.Image = Properties.Resources.mao_cx;
            if (!opcoesSelecionadas.Contains("papel"))
                Opc_Papel.Image = Properties.Resources.papel_de_mao_cx;
            if (!opcoesSelecionadas.Contains("tesoura"))
                Opc_Tesoura.Image = Properties.Resources.tesouras_cx;
        }

        private void JogadaBot()
        {
            string[] opcoes = { "pedra", "papel", "tesoura" };

            // Escolher duas opções aleatórias para o Bot
            List<string> opcoesBot = opcoes.OrderBy(x => random.Next()).Take(2).ToList();

            // Definir imagens para as opções selecionadas
            foreach (string opcao in opcoesBot)
            {
                switch (opcao)
                {
                    case "pedra":
                        Opc_Pedra_Bot.Image = Properties.Resources.mao_circulada;
                        break;
                    case "papel":
                        Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao_circulada;
                        break;
                    case "tesoura":
                        Opc_Tesoura_Bot.Image = Properties.Resources.tesouras_circulada;
                        break;
                }
            }

            // Definir imagem "X" para a opção excluída
            string excluida = opcoes.Except(opcoesBot).First();
            switch (excluida)
            {
                case "pedra":
                    Opc_Pedra_Bot.Image = Properties.Resources.mao_cx;
                    break;
                case "papel":
                    Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao_cx;
                    break;
                case "tesoura":
                    Opc_Tesoura_Bot.Image = Properties.Resources.tesouras_cx;
                    break;
            }
        }

        private void ResetarSelecoes()
        {
            opcoesSelecionadas.Clear();
            Opc_Pedra.Image = null;
            Opc_Papel.Image = null;
            Opc_Tesoura.Image = null;
            Opc_Pedra_Bot.Image = null;
            Opc_Papel_Bot.Image = null;
            Opc_Tesoura_Bot.Image = null;
        }

        // Função para fazer o jogador escolher uma das duas opções selecionadas
        private void EscolherOpcaoFinal(PictureBox opcao, string nome)
        {
            // Remover as imagens das opções não escolhidas
            if (nome == "pedra")
            {
                Opc_Pedra.Image = Properties.Resources.mao;
                Opc_Papel.Image = null;
                Opc_Tesoura.Image = null;
            }
            else if (nome == "papel")
            {
                Opc_Papel.Image = Properties.Resources.papel_de_mao;
                Opc_Pedra.Image = null;
                Opc_Tesoura.Image = null;
            }
            else if (nome == "tesoura")
            {
                Opc_Tesoura.Image = Properties.Resources.tesouras;
                Opc_Pedra.Image = null;
                Opc_Papel.Image = null;
            }

            // Agora, o bot escolhe aleatoriamente uma opção final entre as opções que ele selecionou
            EscolherOpcaoFinalBot();
        }

        // Função para o bot escolher aleatoriamente uma das opções finais
        private void EscolherOpcaoFinalBot()
        {
            string[] opcoes = { "pedra", "papel", "tesoura" };

            // O bot vai escolher aleatoriamente uma das opções que ele selecionou
            string opcaoEscolhida = opcoes.OrderBy(x => random.Next()).First();

            // Exibir a imagem do bot conforme a escolha final
            if (opcaoEscolhida == "pedra")
            {
                Opc_Pedra_Bot.Image = Properties.Resources.mao;
                Opc_Papel_Bot.Image = null;
                Opc_Tesoura_Bot.Image = null;
            }
            else if (opcaoEscolhida == "papel")
            {
                Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao;
                Opc_Pedra_Bot.Image = null;
                Opc_Tesoura_Bot.Image = null;
            }
            else if (opcaoEscolhida == "tesoura")
            {
                Opc_Tesoura_Bot.Image = Properties.Resources.tesouras;
                Opc_Pedra_Bot.Image = null;
                Opc_Papel_Bot.Image = null;
            }

            // Após a escolha, podemos fazer a comparação
            CompararEscolhas();
        }

        private void CompararEscolhas()
        {
            // Aqui você compara as opções do jogador e do bot
            string jogadorEscolha = opcoesSelecionadas.First(); // Como temos apenas uma escolha final por jogador
            string botEscolha = string.Empty;

            if (Opc_Pedra_Bot.Image != null) botEscolha = "pedra";
            else if (Opc_Papel_Bot.Image != null) botEscolha = "papel";
            else if (Opc_Tesoura_Bot.Image != null) botEscolha = "tesoura";

            string resultado = string.Empty;

            if (jogadorEscolha == botEscolha)
            {
                resultado = "Empate!";
            }
            else if ((jogadorEscolha == "pedra" && botEscolha == "tesoura") ||
                     (jogadorEscolha == "tesoura" && botEscolha == "papel") ||
                     (jogadorEscolha == "papel" && botEscolha == "pedra"))
            {
                resultado = "Você Ganhou!";
            }
            else
            {
                resultado = "Você Perdeu!";
            }

            MessageBox.Show(resultado);
        }
    }
}
