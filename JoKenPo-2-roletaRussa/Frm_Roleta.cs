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

        //Sim, ele inicializa a interface, como advinhou?
        private void InicializarInterface()
        {
            // Configura as labels e a imagem inicial
            Lbl_ExibeResultado.Text = $"{jogador} Perdeu!";
            Lbl_ExibeRoleta.Text = $"{jogador} joga a roleta russa";
            pictureBox1.Image = Properties.Resources.roleta_russa; // Imagem padrão da roleta
        }

        // Simula a roleta russa com uma chance fixa de 1 em 6
        private async void JogarRoletaRussa()
        {
            
            int resultadoRoleta = random.Next(1, 7);

            if (resultadoRoleta == 1)
            {
                // Se a roleta disparar
                Lbl_ExibeRoleta.Text = $"A roleta russa disparou! {jogador} foi derrotado!";
                pictureBox1.Image = Properties.Resources.roleta_russa_tiro;
                ResultadoRoleta = "Derrota";

                // Espera 3 segundos para o usuário entender o que aconteceu
                await Task.Delay(3000); 
                
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
                pictureBox1.Image = Properties.Resources.roleta_russa_sem_tiro; 
                ResultadoRoleta = "Sobreviveu"; 

                // Espera 3 segundos para o usuário entender o que aconteceu
                await Task.Delay(3000); 
                
            }
        }
        private void Frm_Roleta_Load(object sender, EventArgs e)
        {
            // Executa a roleta russa quando o formulário é carregado
            JogarRoletaRussa();
        }
    }
}