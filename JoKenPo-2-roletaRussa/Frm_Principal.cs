using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    
    public partial class Frm_Principal : Form
    {
        private Dictionary<string, (int vitórias, int empates, int derrotas)> jogadores;
        public string NomeJogador { get; set; }

        // Construtor que recebe o dicionário e o nome do jogador
        public Frm_Principal(Dictionary<string, (int, int, int)> jogadoresRecebido, string nomeJogador)
        {
            InitializeComponent();
            this.jogadores = jogadoresRecebido;
            this.NomeJogador = nomeJogador;
            AtualizarNome(); // Atualiza a label ao abrir o formulário
        }

        public void AtualizarNome()
        {
            if (jogadores.ContainsKey(NomeJogador))
            {
                var (vitorias, empates, derrotas) = jogadores[NomeJogador];
                Lbl_ExibeNome.Text = $"Jogador: {NomeJogador} \n| Vitórias: {vitorias} | Empates: {empates} | Derrotas: {derrotas}";
            }
            else
            {
                Lbl_ExibeNome.Text = $"Jogador: {NomeJogador} | Sem registros";
            }
        }


        List<string> opcoesSelecionadas = new List<string>();
        Random random = new Random();

        // Lista de opções possíveis (pedra, papel, tesoura)
        List<string> opcoes = new List<string> { "pedra", "papel", "tesoura" };

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
                DefinirImagemExcluida();  // Definir as imagens excluídas
                JogadaBot(); // O Bot joga logo após a seleção do jogador
            }
        }

        private void DefinirImagemExcluida()
        {
            // Definir a imagem "X" para a opção excluída pelo bot
            string excluida = opcoes.Except(opcoesSelecionadas).First();
            switch (excluida)
            {
                case "pedra":
                    Opc_Pedra_Bot.Image = Properties.Resources.mao_cx;  // Imagem de "X" na pedra
                    break;
                case "papel":
                    Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao_cx;  // Imagem de "X" no papel
                    break;
                case "tesoura":
                    Opc_Tesoura_Bot.Image = Properties.Resources.tesouras_cx;  // Imagem de "X" na tesoura
                    break;
            }
        }

        private void JogadaBot()
        {
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
            AtualizarPontuacao(resultado);

            // Mostrar o resultado em uma caixa de mensagem
            MessageBox.Show(resultado);

            // Resetar as seleções para o próximo round
            ResetarSelecoes();
        }
        private void AtualizarPontuacao(string resultado)
        {
            if (jogadores.ContainsKey(NomeJogador))
            {
                var (vitorias, empates, derrotas) = jogadores[NomeJogador];

                if (resultado == "Você Ganhou!") vitorias++;
                else if (resultado == "Empate!") empates++;
                else if (resultado == "Você Perdeu!") derrotas++;

                // Atualiza os valores no dicionário
                jogadores[NomeJogador] = (vitorias, empates, derrotas);
            }

            // Atualiza a exibição
            AtualizarNome();
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
