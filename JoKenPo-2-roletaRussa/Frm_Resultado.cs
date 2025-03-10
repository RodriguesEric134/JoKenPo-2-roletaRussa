using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo_2_roletaRussa
{
    public partial class Frm_Resultado : Form
    {
        public Frm_Resultado(string nomeImagem, string mensagem)
        {
            InitializeComponent();
            Image MyImage = (Image)global::JoKenPo_2_roletaRussa.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Resultado.Image = MyImage;
            Lbl_Resultado.Text = mensagem;
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            // Fecha todos os formulários abertos
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "Frm_Identificacao") // Não fecha o Frm_Identificacao ainda
                {
                    form.Close();
                }
            }        
        }
    }
}
