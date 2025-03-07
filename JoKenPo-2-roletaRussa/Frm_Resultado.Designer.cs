namespace JoKenPo_2_roletaRussa
{
    partial class Frm_Resultado
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
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Location = new System.Drawing.Point(205, 80);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(117, 13);
            this.Lbl_Resultado.TabIndex = 0;
            this.Lbl_Resultado.Text = "Você Morreu!/Ganhou!";
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.morreu;
            this.Pic_Imagem.Location = new System.Drawing.Point(13, 12);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(171, 157);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Imagem.TabIndex = 1;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Lbl_Resultado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Resultado";
            this.Text = "Frm_Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.PictureBox Pic_Imagem;
    }
}