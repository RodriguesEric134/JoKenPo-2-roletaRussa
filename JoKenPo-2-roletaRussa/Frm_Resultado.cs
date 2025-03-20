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
        //inicializa resultado com parâmetros nomeImagem e mensagem para possível alteração
        public Frm_Resultado(string nomeImagem, string mensagem)
        {
            InitializeComponent();
            Image MyImage = (Image)global::JoKenPo_2_roletaRussa.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Resultado.Image = MyImage;
            Lbl_Resultado.Text = mensagem;
        }

        //fecha todos os menus menos o de identificação para possibilidade de novos usuários
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            // Fecha todos os formulários abertos
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != "Frm_Identificacao")
                {
                    form.Close();
                }
            }        
        }
    }
}
