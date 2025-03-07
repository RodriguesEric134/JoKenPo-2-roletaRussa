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
        private List<string> opcoesSelecionadas = new List<string>();
        private List<string> opcoesBot = new List<string>();
        private Random random = new Random();
        private bool escolhaFinalJogador = false;

        List<string> opcoes = new List<string> { "pedra", "papel", "tesoura" };
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


        public Frm_Principal(Dictionary<string, (int, int, int)> jogadoresRecebido, string nomeJogador)
        {
            InitializeComponent();
            this.jogadores = jogadoresRecebido;
            this.NomeJogador = nomeJogador;
            AtualizarNome();
        }

        private void Opc_Pedra_Click(object sender, EventArgs e) => SelecionarOpcao("pedra");
        private void Opc_Papel_Click(object sender, EventArgs e) => SelecionarOpcao("papel");
        private void Opc_Tesoura_Click(object sender, EventArgs e) => SelecionarOpcao("tesoura");

        private void SelecionarOpcao(string nome)
        {
            if (!escolhaFinalJogador)
            {
                if (opcoesSelecionadas.Contains(nome)) return;
                opcoesSelecionadas.Add(nome);
                ExibirImagemEscolha(nome, true);

                if (opcoesSelecionadas.Count == 2)
                {
                    JogadaBotInicial();
                }
            }
            else
            {
                escolhaFinalJogador = false;
                DefinirEscolhaFinal(nome, true);
                EscolhaFinalBot();
            }
        }

        private void JogadaBotInicial()
        {
            opcoesBot = opcoes.OrderBy(x => random.Next()).Take(2).ToList();
            foreach (string opcao in opcoesBot)
            {
                ExibirImagemEscolha(opcao, false);
            }
            MessageBox.Show("Agora escolha sua jogada final!");
            escolhaFinalJogador = true;
        }

        private void EscolhaFinalBot()
        {
            string escolhaFinal = opcoesBot[random.Next(opcoesBot.Count)];
            DefinirEscolhaFinal(escolhaFinal, false);
            CompararEscolhas();
        }

        private void DefinirEscolhaFinal(string escolha, bool jogador)
        {
            if (jogador)
            {
                opcoesSelecionadas = new List<string> { escolha };
            }
            else
            {
                opcoesBot = new List<string> { escolha };
            }
        }

        private void CompararEscolhas()
        {
            string jogadorEscolha = opcoesSelecionadas.First();
            string botEscolha = opcoesBot.First();

            string resultado;
            if (jogadorEscolha == botEscolha)
                resultado = "Empate!";
            else if ((jogadorEscolha == "pedra" && botEscolha == "tesoura") ||
                     (jogadorEscolha == "tesoura" && botEscolha == "papel") ||
                     (jogadorEscolha == "papel" && botEscolha == "pedra"))
                resultado = "Você Ganhou!";
            else
                resultado = "Você Perdeu!";

            AtualizarPontuacao(resultado);
            MessageBox.Show(resultado);
            ResetarSelecoes();
        }

        private void AtualizarPontuacao(string resultado)
        {
            if (jogadores.ContainsKey(NomeJogador))
            {
                var (vitorias, empates, derrotas) = jogadores[NomeJogador];
                if (resultado == "Você Ganhou!") vitorias++;
                else if (resultado == "Empate!") empates++;
                else derrotas++;
                jogadores[NomeJogador] = (vitorias, empates, derrotas);
            }
            AtualizarNome();
        }

        private void ExibirImagemEscolha(string escolha, bool jogador)
        {
            var imagens = new Dictionary<string, PictureBox>
            {
                { "pedra", jogador ? Opc_Pedra : Opc_Pedra_Bot },
                { "papel", jogador ? Opc_Papel : Opc_Papel_Bot },
                { "tesoura", jogador ? Opc_Tesoura : Opc_Tesoura_Bot }
            };
            imagens[escolha].Image = Properties.Resources.mao_circulada;
        }

        private void ResetarSelecoes()
        {
            escolhaFinalJogador = false;
            opcoesSelecionadas.Clear();
            opcoesBot.Clear();
            Opc_Pedra.Image = Properties.Resources.mao;
            Opc_Papel.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura.Image = Properties.Resources.tesouras;
            Opc_Pedra_Bot.Image = Properties.Resources.mao;
            Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura_Bot.Image = Properties.Resources.tesouras;
        }
    }
}
