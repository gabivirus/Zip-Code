
namespace CEP
{
    partial class CEPVerifier
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
            this.CepLebel = new System.Windows.Forms.Label();
            this.CEPTaker = new System.Windows.Forms.TextBox();
            this.EndDisplay = new System.Windows.Forms.TextBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.NumInput = new System.Windows.Forms.TextBox();
            this.NumLabel = new System.Windows.Forms.Label();
            this.BairroDisplay = new System.Windows.Forms.TextBox();
            this.BairroLabel = new System.Windows.Forms.Label();
            this.CompLabel = new System.Windows.Forms.Label();
            this.CompInput = new System.Windows.Forms.TextBox();
            this.CidadeDisplay = new System.Windows.Forms.TextBox();
            this.CidaLabel = new System.Windows.Forms.Label();
            this.EstadoDisplay = new System.Windows.Forms.TextBox();
            this.EstaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CepLebel
            // 
            this.CepLebel.AutoSize = true;
            this.CepLebel.Location = new System.Drawing.Point(14, 35);
            this.CepLebel.Name = "CepLebel";
            this.CepLebel.Size = new System.Drawing.Size(70, 13);
            this.CepLebel.TabIndex = 0;
            this.CepLebel.Text = "Digite o CEP:";
            // 
            // CEPTaker
            // 
            this.CEPTaker.Location = new System.Drawing.Point(17, 52);
            this.CEPTaker.Name = "CEPTaker";
            this.CEPTaker.Size = new System.Drawing.Size(115, 20);
            this.CEPTaker.TabIndex = 1;
            // 
            // EndDisplay
            // 
            this.EndDisplay.Location = new System.Drawing.Point(19, 153);
            this.EndDisplay.Name = "EndDisplay";
            this.EndDisplay.Size = new System.Drawing.Size(343, 20);
            this.EndDisplay.TabIndex = 3;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(16, 136);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(56, 13);
            this.EndLabel.TabIndex = 2;
            this.EndLabel.Text = "Endereço:";
            // 
            // NumInput
            // 
            this.NumInput.Location = new System.Drawing.Point(378, 153);
            this.NumInput.Name = "NumInput";
            this.NumInput.Size = new System.Drawing.Size(69, 20);
            this.NumInput.TabIndex = 5;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(375, 136);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(47, 13);
            this.NumLabel.TabIndex = 4;
            this.NumLabel.Text = "Número:";
            // 
            // BairroDisplay
            // 
            this.BairroDisplay.Location = new System.Drawing.Point(20, 223);
            this.BairroDisplay.Name = "BairroDisplay";
            this.BairroDisplay.Size = new System.Drawing.Size(240, 20);
            this.BairroDisplay.TabIndex = 9;
            // 
            // BairroLabel
            // 
            this.BairroLabel.AutoSize = true;
            this.BairroLabel.Location = new System.Drawing.Point(17, 206);
            this.BairroLabel.Name = "BairroLabel";
            this.BairroLabel.Size = new System.Drawing.Size(37, 13);
            this.BairroLabel.TabIndex = 8;
            this.BairroLabel.Text = "Bairro:";
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Location = new System.Drawing.Point(460, 136);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(74, 13);
            this.CompLabel.TabIndex = 6;
            this.CompLabel.Text = "Complemento:";
            // 
            // CompInput
            // 
            this.CompInput.Location = new System.Drawing.Point(463, 153);
            this.CompInput.Name = "CompInput";
            this.CompInput.Size = new System.Drawing.Size(100, 20);
            this.CompInput.TabIndex = 7;
            // 
            // CidadeDisplay
            // 
            this.CidadeDisplay.Location = new System.Drawing.Point(275, 223);
            this.CidadeDisplay.Name = "CidadeDisplay";
            this.CidadeDisplay.Size = new System.Drawing.Size(192, 20);
            this.CidadeDisplay.TabIndex = 11;
            // 
            // CidaLabel
            // 
            this.CidaLabel.AutoSize = true;
            this.CidaLabel.Location = new System.Drawing.Point(272, 206);
            this.CidaLabel.Name = "CidaLabel";
            this.CidaLabel.Size = new System.Drawing.Size(43, 13);
            this.CidaLabel.TabIndex = 10;
            this.CidaLabel.Text = "Cidade:";
            // 
            // EstadoDisplay
            // 
            this.EstadoDisplay.Location = new System.Drawing.Point(483, 223);
            this.EstadoDisplay.Name = "EstadoDisplay";
            this.EstadoDisplay.Size = new System.Drawing.Size(80, 20);
            this.EstadoDisplay.TabIndex = 13;
            // 
            // EstaLabel
            // 
            this.EstaLabel.AutoSize = true;
            this.EstaLabel.Location = new System.Drawing.Point(480, 206);
            this.EstaLabel.Name = "EstaLabel";
            this.EstaLabel.Size = new System.Drawing.Size(43, 13);
            this.EstaLabel.TabIndex = 12;
            this.EstaLabel.Text = "Estado:";
            // 
            // CEPVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 332);
            this.Controls.Add(this.EstadoDisplay);
            this.Controls.Add(this.EstaLabel);
            this.Controls.Add(this.CidadeDisplay);
            this.Controls.Add(this.CidaLabel);
            this.Controls.Add(this.BairroDisplay);
            this.Controls.Add(this.BairroLabel);
            this.Controls.Add(this.CompInput);
            this.Controls.Add(this.CompLabel);
            this.Controls.Add(this.NumInput);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.EndDisplay);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.CEPTaker);
            this.Controls.Add(this.CepLebel);
            this.Name = "CEPVerifier";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CepLebel;
        private System.Windows.Forms.TextBox CEPTaker;
        private System.Windows.Forms.TextBox EndDisplay;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox NumInput;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.TextBox BairroDisplay;
        private System.Windows.Forms.Label BairroLabel;
        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.TextBox CompInput;
        private System.Windows.Forms.TextBox CidadeDisplay;
        private System.Windows.Forms.Label CidaLabel;
        private System.Windows.Forms.TextBox EstadoDisplay;
        private System.Windows.Forms.Label EstaLabel;
    }
}

