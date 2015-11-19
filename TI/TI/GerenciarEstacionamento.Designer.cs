namespace TI
{
    partial class GerenciarEstacionamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEstacionamentoID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEstacionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaEstacionados = new System.Windows.Forms.ListBox();
            this.btnSelecionarEstacionamento = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vagasPreenchidas = new System.Windows.Forms.Label();
            this.numeroVagas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbEstacionamentoID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnEstacionar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSelecionarEstacionamento);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vagasPreenchidas);
            this.panel1.Controls.Add(this.numeroVagas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 659);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbEstacionamentoID
            // 
            this.cbEstacionamentoID.FormattingEnabled = true;
            this.cbEstacionamentoID.Items.AddRange(new object[] {
            "Barro Preto",
            "Centro",
            "Venda Nova"});
            this.cbEstacionamentoID.Location = new System.Drawing.Point(38, 46);
            this.cbEstacionamentoID.Name = "cbEstacionamentoID";
            this.cbEstacionamentoID.Size = new System.Drawing.Size(186, 28);
            this.cbEstacionamentoID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estacionamento";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(244, 131);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(200, 29);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Saída veículo";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnEstacionar
            // 
            this.btnEstacionar.Location = new System.Drawing.Point(38, 132);
            this.btnEstacionar.Name = "btnEstacionar";
            this.btnEstacionar.Size = new System.Drawing.Size(200, 26);
            this.btnEstacionar.TabIndex = 10;
            this.btnEstacionar.Text = "Entrada veículo";
            this.btnEstacionar.UseVisualStyleBackColor = true;
            this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaEstacionados);
            this.groupBox1.Location = new System.Drawing.Point(33, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 481);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veículos estacionados";
            // 
            // listaEstacionados
            // 
            this.listaEstacionados.FormattingEnabled = true;
            this.listaEstacionados.ItemHeight = 20;
            this.listaEstacionados.Items.AddRange(new object[] {
            "placa, cliente, hora chegada, tipo veiculo, tipo cliente"});
            this.listaEstacionados.Location = new System.Drawing.Point(6, 34);
            this.listaEstacionados.Name = "listaEstacionados";
            this.listaEstacionados.Size = new System.Drawing.Size(549, 444);
            this.listaEstacionados.TabIndex = 0;
            // 
            // btnSelecionarEstacionamento
            // 
            this.btnSelecionarEstacionamento.Location = new System.Drawing.Point(230, 46);
            this.btnSelecionarEstacionamento.Name = "btnSelecionarEstacionamento";
            this.btnSelecionarEstacionamento.Size = new System.Drawing.Size(101, 26);
            this.btnSelecionarEstacionamento.TabIndex = 8;
            this.btnSelecionarEstacionamento.Text = "Selecionar";
            this.btnSelecionarEstacionamento.UseVisualStyleBackColor = true;
            this.btnSelecionarEstacionamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(38, 100);
            this.txtPlaca.Mask = "AAA-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(79, 26);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vagas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // vagasPreenchidas
            // 
            this.vagasPreenchidas.AutoSize = true;
            this.vagasPreenchidas.Location = new System.Drawing.Point(533, 32);
            this.vagasPreenchidas.Name = "vagasPreenchidas";
            this.vagasPreenchidas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vagasPreenchidas.Size = new System.Drawing.Size(18, 20);
            this.vagasPreenchidas.TabIndex = 3;
            this.vagasPreenchidas.Text = "0";
            // 
            // numeroVagas
            // 
            this.numeroVagas.AutoSize = true;
            this.numeroVagas.Location = new System.Drawing.Point(576, 32);
            this.numeroVagas.Name = "numeroVagas";
            this.numeroVagas.Size = new System.Drawing.Size(18, 20);
            this.numeroVagas.TabIndex = 2;
            this.numeroVagas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // GerenciarEstacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 659);
            this.Controls.Add(this.panel1);
            this.Name = "GerenciarEstacionamento";
            this.Text = "Gerenciar Estacionamento";
            this.Load += new System.EventHandler(this.GerenciarEstacionamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vagasPreenchidas;
        private System.Windows.Forms.Label numeroVagas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstacionamentoID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEstacionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listaEstacionados;
        private System.Windows.Forms.Button btnSelecionarEstacionamento;
    }
}