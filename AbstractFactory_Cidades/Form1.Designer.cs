namespace AbstractFactory_Cidades
{
    partial class Form1
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
            this.CB_Pais = new System.Windows.Forms.ComboBox();
            this.CB_Cidade = new System.Windows.Forms.ComboBox();
            this.TB_Painel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Pais
            // 
            this.CB_Pais.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CB_Pais.FormattingEnabled = true;
            this.CB_Pais.Location = new System.Drawing.Point(141, 101);
            this.CB_Pais.Name = "CB_Pais";
            this.CB_Pais.Size = new System.Drawing.Size(121, 21);
            this.CB_Pais.TabIndex = 0;
            this.CB_Pais.SelectedIndexChanged += new System.EventHandler(this.CB_Pais_SelectedIndexChanged);
            // 
            // CB_Cidade
            // 
            this.CB_Cidade.FormattingEnabled = true;
            this.CB_Cidade.Location = new System.Drawing.Point(141, 149);
            this.CB_Cidade.Name = "CB_Cidade";
            this.CB_Cidade.Size = new System.Drawing.Size(121, 21);
            this.CB_Cidade.TabIndex = 1;
            this.CB_Cidade.SelectedIndexChanged += new System.EventHandler(this.CB_Cidade_SelectedIndexChanged);
            // 
            // TB_Painel
            // 
            this.TB_Painel.Location = new System.Drawing.Point(341, 65);
            this.TB_Painel.Multiline = true;
            this.TB_Painel.Name = "TB_Painel";
            this.TB_Painel.Size = new System.Drawing.Size(257, 137);
            this.TB_Painel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 249);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Painel);
            this.Controls.Add(this.CB_Cidade);
            this.Controls.Add(this.CB_Pais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Pais;
        private System.Windows.Forms.ComboBox CB_Cidade;
        private System.Windows.Forms.TextBox TB_Painel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

