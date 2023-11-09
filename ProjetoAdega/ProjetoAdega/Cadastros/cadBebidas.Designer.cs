namespace ProjetoAdega
{
    partial class cadBebidas
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
            this.lbNomeBebida = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbTipobebida = new System.Windows.Forms.Label();
            this.comboBoxTipoBebida = new System.Windows.Forms.ComboBox();
            this.preco = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btCadastrarbebida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNomeBebida
            // 
            this.lbNomeBebida.AutoSize = true;
            this.lbNomeBebida.Location = new System.Drawing.Point(38, 45);
            this.lbNomeBebida.Name = "lbNomeBebida";
            this.lbNomeBebida.Size = new System.Drawing.Size(88, 13);
            this.lbNomeBebida.TabIndex = 0;
            this.lbNomeBebida.Text = "Nome da bebida:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(132, 42);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // lbTipobebida
            // 
            this.lbTipobebida.AutoSize = true;
            this.lbTipobebida.Location = new System.Drawing.Point(45, 73);
            this.lbTipobebida.Name = "lbTipobebida";
            this.lbTipobebida.Size = new System.Drawing.Size(81, 13);
            this.lbTipobebida.TabIndex = 2;
            this.lbTipobebida.Text = "Tipo da bebida:";
            // 
            // comboBoxTipoBebida
            // 
            this.comboBoxTipoBebida.FormattingEnabled = true;
            this.comboBoxTipoBebida.Items.AddRange(new object[] {
            "Destilada",
            "Cerveja",
            "Energetico"});
            this.comboBoxTipoBebida.Location = new System.Drawing.Point(132, 70);
            this.comboBoxTipoBebida.Name = "comboBoxTipoBebida";
            this.comboBoxTipoBebida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoBebida.TabIndex = 4;
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(88, 100);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(38, 13);
            this.preco.TabIndex = 5;
            this.preco.Text = "Preço:";
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(132, 97);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(52, 20);
            this.txtpreco.TabIndex = 6;          
            this.txtpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkeypress);
            // 
            // btCadastrarbebida
            // 
            this.btCadastrarbebida.Location = new System.Drawing.Point(62, 182);
            this.btCadastrarbebida.Name = "btCadastrarbebida";
            this.btCadastrarbebida.Size = new System.Drawing.Size(83, 40);
            this.btCadastrarbebida.TabIndex = 7;
            this.btCadastrarbebida.Text = "cadastrar";
            this.btCadastrarbebida.UseVisualStyleBackColor = true;
            this.btCadastrarbebida.Click += new System.EventHandler(this.btCadastrarbebida_Click);
            // 
            // cadBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 234);
            this.Controls.Add(this.btCadastrarbebida);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.comboBoxTipoBebida);
            this.Controls.Add(this.lbTipobebida);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbNomeBebida);
            this.Name = "cadBebidas";
            this.Text = "cadBebidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeBebida;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lbTipobebida;
        private System.Windows.Forms.ComboBox comboBoxTipoBebida;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button btCadastrarbebida;
    }
}