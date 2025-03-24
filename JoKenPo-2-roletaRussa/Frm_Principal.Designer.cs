namespace JoKenPo_2_roletaRussa
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_ExibeNome = new System.Windows.Forms.Label();
            this.Lbl_NomeBot = new System.Windows.Forms.Label();
            this.Opc_Tesoura_Bot = new System.Windows.Forms.PictureBox();
            this.Opc_Papel_Bot = new System.Windows.Forms.PictureBox();
            this.Opc_Pedra_Bot = new System.Windows.Forms.PictureBox();
            this.Opc_Tesoura = new System.Windows.Forms.PictureBox();
            this.Opc_Papel = new System.Windows.Forms.PictureBox();
            this.Opc_Pedra = new System.Windows.Forms.PictureBox();
            this.Lbl_X = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Tesoura_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Papel_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Pedra_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Tesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Papel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Pedra)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ExibeNome
            // 
            this.Lbl_ExibeNome.AutoSize = true;
            this.Lbl_ExibeNome.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ExibeNome.Location = new System.Drawing.Point(12, 13);
            this.Lbl_ExibeNome.Name = "Lbl_ExibeNome";
            this.Lbl_ExibeNome.Size = new System.Drawing.Size(64, 20);
            this.Lbl_ExibeNome.TabIndex = 3;
            this.Lbl_ExibeNome.Text = "Jogador:";
            // 
            // Lbl_NomeBot
            // 
            this.Lbl_NomeBot.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NomeBot.Location = new System.Drawing.Point(330, 13);
            this.Lbl_NomeBot.Name = "Lbl_NomeBot";
            this.Lbl_NomeBot.Size = new System.Drawing.Size(108, 21);
            this.Lbl_NomeBot.TabIndex = 7;
            this.Lbl_NomeBot.Text = "Bot";
            // 
            // Opc_Tesoura_Bot
            // 
            this.Opc_Tesoura_Bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Opc_Tesoura_Bot.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.tesouras;
            this.Opc_Tesoura_Bot.Location = new System.Drawing.Point(348, 279);
            this.Opc_Tesoura_Bot.Name = "Opc_Tesoura_Bot";
            this.Opc_Tesoura_Bot.Size = new System.Drawing.Size(90, 90);
            this.Opc_Tesoura_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Tesoura_Bot.TabIndex = 6;
            this.Opc_Tesoura_Bot.TabStop = false;
            // 
            // Opc_Papel_Bot
            // 
            this.Opc_Papel_Bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Opc_Papel_Bot.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.papel_de_mao;
            this.Opc_Papel_Bot.Location = new System.Drawing.Point(348, 183);
            this.Opc_Papel_Bot.Name = "Opc_Papel_Bot";
            this.Opc_Papel_Bot.Size = new System.Drawing.Size(90, 90);
            this.Opc_Papel_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Papel_Bot.TabIndex = 5;
            this.Opc_Papel_Bot.TabStop = false;
            // 
            // Opc_Pedra_Bot
            // 
            this.Opc_Pedra_Bot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Opc_Pedra_Bot.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.mao;
            this.Opc_Pedra_Bot.Location = new System.Drawing.Point(348, 87);
            this.Opc_Pedra_Bot.Name = "Opc_Pedra_Bot";
            this.Opc_Pedra_Bot.Size = new System.Drawing.Size(90, 90);
            this.Opc_Pedra_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Pedra_Bot.TabIndex = 4;
            this.Opc_Pedra_Bot.TabStop = false;
            // 
            // Opc_Tesoura
            // 
            this.Opc_Tesoura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Opc_Tesoura.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.tesouras;
            this.Opc_Tesoura.Location = new System.Drawing.Point(12, 279);
            this.Opc_Tesoura.Name = "Opc_Tesoura";
            this.Opc_Tesoura.Size = new System.Drawing.Size(90, 90);
            this.Opc_Tesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Tesoura.TabIndex = 2;
            this.Opc_Tesoura.TabStop = false;
            this.Opc_Tesoura.Click += new System.EventHandler(this.Opc_Tesoura_Click);
            // 
            // Opc_Papel
            // 
            this.Opc_Papel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Opc_Papel.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.papel_de_mao;
            this.Opc_Papel.Location = new System.Drawing.Point(12, 183);
            this.Opc_Papel.Name = "Opc_Papel";
            this.Opc_Papel.Size = new System.Drawing.Size(90, 90);
            this.Opc_Papel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Papel.TabIndex = 1;
            this.Opc_Papel.TabStop = false;
            this.Opc_Papel.Click += new System.EventHandler(this.Opc_Papel_Click);
            // 
            // Opc_Pedra
            // 
            this.Opc_Pedra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Opc_Pedra.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.mao;
            this.Opc_Pedra.Location = new System.Drawing.Point(12, 87);
            this.Opc_Pedra.Name = "Opc_Pedra";
            this.Opc_Pedra.Size = new System.Drawing.Size(90, 90);
            this.Opc_Pedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Opc_Pedra.TabIndex = 0;
            this.Opc_Pedra.TabStop = false;
            this.Opc_Pedra.Click += new System.EventHandler(this.Opc_Pedra_Click);
            // 
            // Lbl_X
            // 
            this.Lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_X.ForeColor = System.Drawing.Color.Red;
            this.Lbl_X.Location = new System.Drawing.Point(187, 200);
            this.Lbl_X.Name = "Lbl_X";
            this.Lbl_X.Size = new System.Drawing.Size(68, 73);
            this.Lbl_X.TabIndex = 8;
            this.Lbl_X.Text = "X";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 397);
            this.Controls.Add(this.Lbl_X);
            this.Controls.Add(this.Lbl_NomeBot);
            this.Controls.Add(this.Opc_Tesoura_Bot);
            this.Controls.Add(this.Opc_Papel_Bot);
            this.Controls.Add(this.Opc_Pedra_Bot);
            this.Controls.Add(this.Lbl_ExibeNome);
            this.Controls.Add(this.Opc_Tesoura);
            this.Controls.Add(this.Opc_Papel);
            this.Controls.Add(this.Opc_Pedra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo 2.0 com Roleta Russa";
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Tesoura_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Papel_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Pedra_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Tesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Papel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Opc_Pedra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Opc_Pedra;
        private System.Windows.Forms.PictureBox Opc_Papel;
        private System.Windows.Forms.PictureBox Opc_Tesoura;
        private System.Windows.Forms.Label Lbl_ExibeNome;
        private System.Windows.Forms.PictureBox Opc_Tesoura_Bot;
        private System.Windows.Forms.PictureBox Opc_Papel_Bot;
        private System.Windows.Forms.PictureBox Opc_Pedra_Bot;
        private System.Windows.Forms.Label Lbl_NomeBot;
        private System.Windows.Forms.Label Lbl_X;
    }
}

