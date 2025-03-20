using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    public partial class Frm_Ranking : Form
    {
        private Dictionary<string, (int vitorias, int empates, int derrotas)> jogadores;

        public Frm_Ranking(Dictionary<string, (int vitorias, int empates, int derrotas)> jogadores)
        {
            InitializeComponent();
            this.jogadores = jogadores;
            ExibirRanking();
        }

        // Ordena jogadores por vitórias e ranqueia pelo índice
        private void ExibirRanking()
        {
            
            var ranking = jogadores.OrderByDescending(j => j.Value.vitorias).Take(3).ToList();

            
            Txt_Venc1.Text = ranking.Count > 0 ? $"1º {ranking[0].Key}: {ranking[0].Value.vitorias} vitórias" : "1º - Nenhum jogador";
            Txt_Venc2.Text = ranking.Count > 1 ? $"2º {ranking[1].Key}: {ranking[1].Value.vitorias} vitórias" : "2º - Nenhum jogador";
            Txt_Venc3.Text = ranking.Count > 2 ? $"3º {ranking[2].Key}: {ranking[2].Value.vitorias} vitórias" : "3º - Nenhum jogador";
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
