namespace Pizza
{
    partial class Form1
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
            this.cmbSabores = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.rbPequena = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.cbMaionese = new System.Windows.Forms.CheckBox();
            this.cbMolhos = new System.Windows.Forms.CheckBox();
            this.cbBorda = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblSabores = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblOpicionais = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBifrost = new System.Windows.Forms.Label();
            this.lblPizzaria = new System.Windows.Forms.Label();
            this.lblReinos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSabores
            // 
            this.cmbSabores.FormattingEnabled = true;
            this.cmbSabores.Items.AddRange(new object[] {
            "Calabresa",
            "Muzzarela",
            "Portuguesa"});
            this.cmbSabores.Location = new System.Drawing.Point(329, 166);
            this.cmbSabores.Name = "cmbSabores";
            this.cmbSabores.Size = new System.Drawing.Size(134, 21);
            this.cmbSabores.TabIndex = 0;
            this.cmbSabores.SelectedIndexChanged += new System.EventHandler(this.cmbSabores_SelectedIndexChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(329, 215);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(134, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // rbPequena
            // 
            this.rbPequena.AutoSize = true;
            this.rbPequena.Checked = true;
            this.rbPequena.Location = new System.Drawing.Point(302, 285);
            this.rbPequena.Name = "rbPequena";
            this.rbPequena.Size = new System.Drawing.Size(68, 17);
            this.rbPequena.TabIndex = 2;
            this.rbPequena.TabStop = true;
            this.rbPequena.Text = "Pequena";
            this.rbPequena.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(376, 285);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(54, 17);
            this.rbMedia.TabIndex = 3;
            this.rbMedia.Text = "Média";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(436, 285);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 4;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // cbMaionese
            // 
            this.cbMaionese.AutoSize = true;
            this.cbMaionese.Location = new System.Drawing.Point(442, 363);
            this.cbMaionese.Name = "cbMaionese";
            this.cbMaionese.Size = new System.Drawing.Size(72, 17);
            this.cbMaionese.TabIndex = 5;
            this.cbMaionese.Text = "Maionese";
            this.cbMaionese.UseVisualStyleBackColor = true;
            // 
            // cbMolhos
            // 
            this.cbMolhos.AutoSize = true;
            this.cbMolhos.Location = new System.Drawing.Point(376, 363);
            this.cbMolhos.Name = "cbMolhos";
            this.cbMolhos.Size = new System.Drawing.Size(60, 17);
            this.cbMolhos.TabIndex = 6;
            this.cbMolhos.Text = "Molhos";
            this.cbMolhos.UseVisualStyleBackColor = true;
            // 
            // cbBorda
            // 
            this.cbBorda.AutoSize = true;
            this.cbBorda.Location = new System.Drawing.Point(268, 363);
            this.cbBorda.Name = "cbBorda";
            this.cbBorda.Size = new System.Drawing.Size(102, 17);
            this.cbBorda.TabIndex = 7;
            this.cbBorda.Text = "Borda recheada";
            this.cbBorda.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalcular.Location = new System.Drawing.Point(329, 396);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 38);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(375, 440);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoEllipsis = true;
            this.lblPedido.AutoSize = true;
            this.lblPedido.BackColor = System.Drawing.SystemColors.Control;
            this.lblPedido.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPedido.Location = new System.Drawing.Point(330, 103);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(139, 28);
            this.lblPedido.TabIndex = 10;
            this.lblPedido.Text = "Faça seu Pedido";
            this.lblPedido.Click += new System.EventHandler(this.lblPedido_Click);
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabores.Location = new System.Drawing.Point(344, 148);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(99, 15);
            this.lblSabores.TabIndex = 11;
            this.lblSabores.Text = "Escolha o Sabor";
            this.lblSabores.Click += new System.EventHandler(this.lblSabores_Click);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(332, 198);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(129, 15);
            this.lblQtd.TabIndex = 12;
            this.lblQtd.Text = "Informe a Quantidade";
            this.lblQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(333, 255);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(128, 15);
            this.lblTamanho.TabIndex = 13;
            this.lblTamanho.Text = "Selecione o Tamanho";
            // 
            // lblOpicionais
            // 
            this.lblOpicionais.AutoSize = true;
            this.lblOpicionais.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpicionais.Location = new System.Drawing.Point(332, 329);
            this.lblOpicionais.Name = "lblOpicionais";
            this.lblOpicionais.Size = new System.Drawing.Size(132, 15);
            this.lblOpicionais.TabIndex = 14;
            this.lblOpicionais.Text = "Escolha os Opicionais";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(299, 443);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Valor total ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblBifrost
            // 
            this.lblBifrost.AutoSize = true;
            this.lblBifrost.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBifrost.Location = new System.Drawing.Point(313, 46);
            this.lblBifrost.Name = "lblBifrost";
            this.lblBifrost.Size = new System.Drawing.Size(77, 26);
            this.lblBifrost.TabIndex = 17;
            this.lblBifrost.Text = "Bifröst";
            // 
            // lblPizzaria
            // 
            this.lblPizzaria.AutoSize = true;
            this.lblPizzaria.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaria.Location = new System.Drawing.Point(396, 46);
            this.lblPizzaria.Name = "lblPizzaria";
            this.lblPizzaria.Size = new System.Drawing.Size(91, 26);
            this.lblPizzaria.TabIndex = 18;
            this.lblPizzaria.Text = "Pizzaria";
            // 
            // lblReinos
            // 
            this.lblReinos.AutoSize = true;
            this.lblReinos.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReinos.Location = new System.Drawing.Point(263, 485);
            this.lblReinos.Name = "lblReinos";
            this.lblReinos.Size = new System.Drawing.Size(281, 26);
            this.lblReinos.TabIndex = 19;
            this.lblReinos.Text = "A melhor pizza dos 9 reinos";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.lblReinos);
            this.Controls.Add(this.lblPizzaria);
            this.Controls.Add(this.lblBifrost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOpicionais);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblSabores);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbBorda);
            this.Controls.Add(this.cbMolhos);
            this.Controls.Add(this.cbMaionese);
            this.Controls.Add(this.rbGrande);
            this.Controls.Add(this.rbMedia);
            this.Controls.Add(this.rbPequena);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.cmbSabores);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSabores;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.RadioButton rbPequena;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.CheckBox cbMaionese;
        private System.Windows.Forms.CheckBox cbMolhos;
        private System.Windows.Forms.CheckBox cbBorda;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblOpicionais;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBifrost;
        private System.Windows.Forms.Label lblPizzaria;
        private System.Windows.Forms.Label lblReinos;
    }
}

