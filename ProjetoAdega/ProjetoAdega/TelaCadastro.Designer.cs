namespace ProjetoAdega
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.btCadBebidas = new System.Windows.Forms.Button();
            this.btCadForn = new System.Windows.Forms.Button();
            this.brVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadBebidas
            // 
            this.btCadBebidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadBebidas.BackgroundImage")));
            this.btCadBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadBebidas.Location = new System.Drawing.Point(12, 78);
            this.btCadBebidas.Name = "btCadBebidas";
            this.btCadBebidas.Size = new System.Drawing.Size(81, 162);
            this.btCadBebidas.TabIndex = 0;
            this.btCadBebidas.Text = "Bebidas";
            this.btCadBebidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadBebidas.UseVisualStyleBackColor = true;
            this.btCadBebidas.Click += new System.EventHandler(this.btCadBebidas_Click);
            // 
            // btCadForn
            // 
            this.btCadForn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadForn.BackgroundImage")));
            this.btCadForn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCadForn.Location = new System.Drawing.Point(158, 78);
            this.btCadForn.Name = "btCadForn";
            this.btCadForn.Size = new System.Drawing.Size(81, 162);
            this.btCadForn.TabIndex = 1;
            this.btCadForn.Text = "Fornecedores";
            this.btCadForn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadForn.UseVisualStyleBackColor = true;
            // 
            // brVoltar
            // 
            this.brVoltar.Location = new System.Drawing.Point(237, 275);
            this.brVoltar.Name = "brVoltar";
            this.brVoltar.Size = new System.Drawing.Size(98, 48);
            this.brVoltar.TabIndex = 2;
            this.brVoltar.Text = "Voltar";
            this.brVoltar.UseVisualStyleBackColor = true;
            this.brVoltar.Click += new System.EventHandler(this.brVoltar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 335);
            this.Controls.Add(this.brVoltar);
            this.Controls.Add(this.btCadForn);
            this.Controls.Add(this.btCadBebidas);
            this.Name = "TelaCadastro";
            this.Text = "Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadBebidas;
        private System.Windows.Forms.Button btCadForn;
        private System.Windows.Forms.Button brVoltar;
    }
}