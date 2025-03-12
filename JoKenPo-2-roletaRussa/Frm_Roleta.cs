using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{

    public partial class Frm_Roleta : Form
    {
        private string jogador;
       
        private Random random = new Random();

        // Propriedade para armazenar o resultado da roleta russa
        public string ResultadoRoleta { get; private set; }

        public Frm_Roleta(string jogador)
        {
            InitializeComponent();
            this.jogador = jogador;
            InicializarInterface();
            JogarRoletaRussa();
        }

        private void InicializarInterface()
        {
            // Configura as labels e a imagem inicial
            Lbl_ExibeResultado.Text = $"{jogador} Perdeu!";
            Lbl_ExibeRoleta.Text = $"{jogador} joga a roleta russa";
            pictureBox1.Image = Properties.Resources.roleta_russa; // Imagem padrão da roleta
        }

        private async void JogarRoletaRussa()
        {
            // Simula a roleta russa com uma chance fixa de 1 em 6
            int resultadoRoleta = random.Next(1, 7); // Número aleatório entre 1 e 6

            if (resultadoRoleta == 1)
            {
                // Se a roleta disparar
                Lbl_ExibeRoleta.Text = $"A roleta russa disparou! {jogador} foi derrotado!";
                pictureBox1.Image = Properties.Resources.roleta_russa_tiro; // Imagem do tiro
                ResultadoRoleta = "Derrota"; // Define o resultado como derrota

                // Aguarda 3 segundos antes de exibir o formulário de resultado
                await Task.Delay(3000); // Delay de 3 segundos
                
                // Verifica quem morreu (jogador ou bot)
                if (jogador == "Jogador")
                {
                    // Jogador morreu
                    Frm_Resultado resultadoForm = new Frm_Resultado("morreu", $"{jogador} foi derrotado! 💀");
                    resultadoForm.ShowDialog();
                    
                }
                else
                {
                    // Bot morreu
                    Frm_Resultado resultadoForm = new Frm_Resultado("ganhou", $"Bot derrotado! Jogador sobrevive! 🎉");
                    resultadoForm.ShowDialog();
                    
                }
            }
            else
            {
                // Se a roleta não disparar
                Lbl_ExibeRoleta.Text = $"A roleta russa não disparou. {jogador} volta a jogar!";
                pictureBox1.Image = Properties.Resources.roleta_russa_sem_tiro; // Imagem sem tiro
                ResultadoRoleta = "Sobreviveu"; // Define o resultado como sobrevivência

                // Aguarda 3 segundos antes de fechar o formulário
                await Task.Delay(3000); // Delay de 3 segundos
                
            }
        }
        private void Frm_Roleta_Load(object sender, EventArgs e)
        {
            // Executa a roleta russa quando o formulário é carregado
            JogarRoletaRussa();
        }
    }
}