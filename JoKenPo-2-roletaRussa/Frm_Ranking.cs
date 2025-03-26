using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    public partial class Frm_Ranking : Form
    {
        //instancia o dicionário
        private Dictionary<string, (int vitórias, int empates, int derrotas)> jogadores;

        //
        public Frm_Ranking(Dictionary<string, (int vitórias, int empates, int derrotas)> jogadores)
        {
            InitializeComponent();
            this.jogadores = jogadores;
            ExibirRanking();
        }

        // Obtém nome dos jogadores pelo {ranking[0].Key} e exibe o número de vitórias
        private void ExibirRanking()
        {
            
            var ranking = jogadores.OrderByDescending(j => j.Value.vitórias).Take(3).ToList();

            
            Txt_Venc1.Text = ranking.Count > 0 ? $"{ranking[0].Key}: {ranking[0].Value.vitórias} vitórias" : "1º - Nenhum jogador";
            Txt_Venc2.Text = ranking.Count > 1 ? $"{ranking[1].Key}: {ranking[1].Value.vitórias} vitórias" : "2º - Nenhum jogador";
            Txt_Venc3.Text = ranking.Count > 2 ? $"{ranking[2].Key}: {ranking[2].Value.vitórias} vitórias" : "3º - Nenhum jogador";
        }

        //fecha a janela
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
