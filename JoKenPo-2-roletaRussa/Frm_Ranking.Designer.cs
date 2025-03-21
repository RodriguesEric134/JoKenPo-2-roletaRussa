namespace JoKenPo_2_roletaRussa
{
    partial class Frm_Ranking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_Venc1 = new System.Windows.Forms.Label();
            this.Txt_Venc3 = new System.Windows.Forms.Label();
            this.Txt_Venc2 = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.RankingPTextoCerto;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_Venc1
            // 
            this.Txt_Venc1.Location = new System.Drawing.Point(175, 131);
            this.Txt_Venc1.Name = "Txt_Venc1";
            this.Txt_Venc1.Size = new System.Drawing.Size(118, 66);
            this.Txt_Venc1.TabIndex = 1;
            this.Txt_Venc1.Text = "Vencedor 1";
            this.Txt_Venc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Venc3
            // 
            this.Txt_Venc3.Location = new System.Drawing.Point(299, 157);
            this.Txt_Venc3.Name = "Txt_Venc3";
            this.Txt_Venc3.Size = new System.Drawing.Size(130, 66);
            this.Txt_Venc3.TabIndex = 2;
            this.Txt_Venc3.Text = "Terceiro";
            this.Txt_Venc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Venc2
            // 
            this.Txt_Venc2.Location = new System.Drawing.Point(44, 157);
            this.Txt_Venc2.Name = "Txt_Venc2";
            this.Txt_Venc2.Size = new System.Drawing.Size(125, 66);
            this.Txt_Venc2.TabIndex = 3;
            this.Txt_Venc2.Text = "Primeiro perdedor";
            this.Txt_Venc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(394, 278);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(62, 26);
            this.Btn_Sair.TabIndex = 4;
            this.Btn_Sair.Text = "Fechar";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Frm_Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 316);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Txt_Venc2);
            this.Controls.Add(this.Txt_Venc3);
            this.Controls.Add(this.Txt_Venc1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top 3 jogadores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Txt_Venc1;
        private System.Windows.Forms.Label Txt_Venc3;
        private System.Windows.Forms.Label Txt_Venc2;
        private System.Windows.Forms.Button Btn_Sair;
    }
}