using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    //branch main
    public partial class Frm_Principal : Form
    {
        //instancia dicionário
        private Dictionary<string, (int vitórias, int empates, int derrotas)> jogadores;
        //instancia o método randômico
        private static Random random = new Random();
        //vários nomes de bot
        private static List<string> nomesBots = new List<string> { "Bot Jorje", "Bot 20comer", "Bot 70correr", "Bot Zé", "Bot Turbo", "Bot Flash" };
        // Escolher um nome aleatoriamente
        string nomeBot = nomesBots[random.Next(nomesBots.Count)];
        //instancia nome do jogador
        public string NomeJogador { get; set; }
        //instancia opções selecionadas como uma lista
        private List<string> opcoesSelecionadas = new List<string>();
        //instancia opções selecionadas do bot como uma lista
        private List<string> opcoesBot = new List<string>();
        
        //declara inicialmente a fase final como falso
        private bool faseFinal = false;

        //lista das possíveis opções 
        List<string> opcoes = new List<string> { "pedra", "papel", "tesoura" };

        //inicializa formulário com o argumento do dicionário
        public Frm_Principal(Dictionary<string, (int, int, int)> jogadoresRecebido, string nomeJogador)
        {
            InitializeComponent();
            this.jogadores = jogadoresRecebido;
            this.NomeJogador = nomeJogador;
            AtualizarNome();
        }

        // Atualiza o nome do jogador e sua pontuação na interface
        public void AtualizarNome()
        {
            if (jogadores.ContainsKey(NomeJogador))
            {
                var (vitorias, empates, derrotas) = jogadores[NomeJogador];
                Lbl_ExibeNome.Text = $"Jogador: {NomeJogador} \n| Vitórias: {vitorias} | Empates: {empates} | Derrotas: {derrotas}";
                Lbl_NomeBot.Text = $"{nomeBot}";
            }
            else
            {
                Lbl_ExibeNome.Text = $"Jogador: {NomeJogador} | Sem registros";
            }
        }

        // Atualiza a pontuação do jogador com base no resultado
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
            AtualizarNome(); // Atualiza a exibição do nome e pontuação
        }

        //Clique das jogadas disponíveis
        private void Opc_Pedra_Click(object sender, EventArgs e) => SelecionarOpcao("pedra");
        private void Opc_Papel_Click(object sender, EventArgs e) => SelecionarOpcao("papel");
        private void Opc_Tesoura_Click(object sender, EventArgs e) => SelecionarOpcao("tesoura");

        //método para selecionar opção
        private void SelecionarOpcao(string nome)
        {
            if (!faseFinal)
            {
                // Fase 1: Selecionar 2 mãos
                if (opcoesSelecionadas.Contains(nome)) return;
                opcoesSelecionadas.Add(nome);
                ExibirImagemEscolha(nome, true);

                if (opcoesSelecionadas.Count == 2)
                {
                    JogadaBotInicial();
                    faseFinal = true; // Avança para a fase final
                    MessageBox.Show("Agora escolha sua jogada final!");
                }
            }
            else
            {
                // Fase 2: Escolher 1 mão entre as 2 selecionadas
                if (!opcoesSelecionadas.Contains(nome)) return;
                DefinirEscolhaFinal(nome, true);
                EscolhaFinalBot();
            }
        }

        private void JogadaBotInicial()
        {
            // Bot seleciona 2 mãos aleatoriamente
            opcoesBot = opcoes.OrderBy(x => random.Next()).Take(2).ToList();
            foreach (string opcao in opcoesBot)
            {
                ExibirImagemEscolha(opcao, false);
            }
        }

        private void EscolhaFinalBot()
        {
            // Bot escolhe 1 mão entre as 2 selecionadas
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

            // Atualiza as imagens para a fase final
            ExibirImagemEscolha(escolha, jogador);
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

            // Atualiza a pontuação
            AtualizarPontuacao(resultado);
            MessageBox.Show(resultado);

            // Chama a roleta russa se o jogador ou bot perder
            if (resultado == "Você Perdeu!")
            {
                Frm_Roleta roleta = new Frm_Roleta("Jogador");
                roleta.ShowDialog(); // Exibe o formulário da roleta russa

                // Verifica o resultado da roleta russa
                if (roleta.ResultadoRoleta == "Derrota")
                {                    
                    jogadores[NomeJogador] = (0, 0, 0); // Zera vitórias, empates e derrotas
                    AtualizarNome(); // Atualiza a exibição na interface
                }
                
            }
            else if (resultado == "Você Ganhou!")
            {
                Frm_Roleta roleta = new Frm_Roleta("Bot");
                roleta.ShowDialog(); // Exibe o formulário da roleta russa
              
            }

            // Reseta as seleções para uma nova rodada
            ResetarSelecoes();
        }

        private void ExibirImagemEscolha(string escolha, bool jogador)
        {
            // Define o dicionário de imagens com base na escolha
            var imagens = new Dictionary<string, PictureBox>
    {
        { "pedra", jogador ? Opc_Pedra : Opc_Pedra_Bot },
        { "papel", jogador ? Opc_Papel : Opc_Papel_Bot },
        { "tesoura", jogador ? Opc_Tesoura : Opc_Tesoura_Bot }
    };

            // Define a imagem com base na escolha
            switch (escolha)
            {
                case "pedra":
                    imagens[escolha].Image = Properties.Resources.mao_circulada;
                    break;
                case "papel":
                    imagens[escolha].Image = Properties.Resources.papel_de_mao_circulada;
                    break;
                case "tesoura":
                    imagens[escolha].Image = Properties.Resources.tesouras_circulada;
                    break;
            }

            // Aplica o "X" nas mãos não selecionadas
            var opcoesSelecionadasAtuais = jogador ? opcoesSelecionadas : opcoesBot;
            foreach (var opcao in opcoes)
            {
                if (!opcoesSelecionadasAtuais.Contains(opcao))
                {
                    PictureBox imagemNaoSelecionada = null;
                    if (opcao == "pedra")
                        imagemNaoSelecionada = jogador ? Opc_Pedra : Opc_Pedra_Bot;
                    else if (opcao == "papel")
                        imagemNaoSelecionada = jogador ? Opc_Papel : Opc_Papel_Bot;
                    else if (opcao == "tesoura")
                        imagemNaoSelecionada = jogador ? Opc_Tesoura : Opc_Tesoura_Bot;

                    if (imagemNaoSelecionada != null)
                    {
                        // Aplica a imagem do "X"
                        switch (opcao)
                        {
                            case "pedra":
                                imagemNaoSelecionada.Image = Properties.Resources.mao_cx;
                                break;
                            case "papel":
                                imagemNaoSelecionada.Image = Properties.Resources.papel_de_mao_cx;
                                break;
                            case "tesoura":
                                imagemNaoSelecionada.Image = Properties.Resources.tesouras_cx;
                                break;
                        }

                        imagemNaoSelecionada.Refresh(); // Atualiza o PictureBox
                    }
                }
            }
        }
        private void ResetarSelecoes()
        {
            faseFinal = false;
            opcoesSelecionadas.Clear();
            opcoesBot.Clear();

            // Redefine as imagens para o estado inicial
            Opc_Pedra.Image = Properties.Resources.mao;
            Opc_Papel.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura.Image = Properties.Resources.tesouras;
            Opc_Pedra_Bot.Image = Properties.Resources.mao;
            Opc_Papel_Bot.Image = Properties.Resources.papel_de_mao;
            Opc_Tesoura_Bot.Image = Properties.Resources.tesouras;
        }
    }
}