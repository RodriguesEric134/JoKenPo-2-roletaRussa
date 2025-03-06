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
            SelecionarOpcao("pedra");
        }

        private void Opc_Papel_Click(object sender, EventArgs e)
        {
            SelecionarOpcao("papel");
        }

        private void Opc_Tesoura_Click(object sender, EventArgs e)
        {
            SelecionarOpcao("tesoura");
        }

        private void SelecionarOpcao(string nome)
        {
            // Impede a seleção da mesma opção várias vezes
            if (opcoesSelecionadas.Contains(nome)) return;

            opcoesSelecionadas.Add(nome);

            // Exibe a imagem da opção selecionada
            switch (nome)
            {
                case "pedra":
                    Opc_Pedra.Image = Properties.Resources.mao_circulada;
                    break;
                case "papel":
                    Opc_Papel.Image = Properties.Resources.papel_de_mao_circulada;
                    break;
                case "tesoura":
                    Opc_Tesoura.Image = Properties.Resources.tesouras_circulada;
                    break;
            }

            // Se o jogador selecionou duas opções, o bot faz sua jogada
            if (opcoesSelecionadas.Count == 2)
            {
                DefinirImagemExcluida();
                JogadaBot(); // O Bot joga logo após a seleção do jogador
            }
        }

        private void DefinirImagemExcluida()
        {
            // Verifica e exclui as imagens das opções não selecionadas
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

            // Definir imagens para as opções selecionadas pelo bot
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

            // Definir a imagem "X" para a opção excluída pelo bot
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

            // Comparar as escolhas do jogador e do bot
            CompararEscolhas();
        }

        private void CompararEscolhas()
        {
            string jogadorEscolha = opcoesSelecionadas.First(); // Como temos apenas uma escolha final por jogador
            string botEscolha = string.Empty;

            // Identificar a opção escolhida pelo bot
            if (Opc_Pedra_Bot.Image != null) botEscolha = "pedra";
            else if (Opc_Papel_Bot.Image != null) botEscolha = "papel";
            else if (Opc_Tesoura_Bot.Image != null) botEscolha = "tesoura";

            // Comparar as escolhas e definir o resultado
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

            // Mostrar o resultado em uma caixa de mensagem
            MessageBox.Show(resultado);

            // Resetar as seleções para o próximo round
            ResetarSelecoes();
        }

        private void ResetarSelecoes()
        {
            opcoesSelecionadas.Clear();
            Opc_Pedra.Image = Properties.Resources.mao;
            Opc_Papel.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura.Image = Properties.Resources.tesouras;
            Opc_Pedra_Bot.Image = Properties.Resources.mao;
            Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura_Bot.Image = Properties.Resources.tesouras;
        }
    }
}