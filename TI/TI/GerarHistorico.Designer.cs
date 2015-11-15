namespace TI
{
    partial class GerarHistorico
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
            this.btnGeralResult = new System.Windows.Forms.Button();
            this.btnImportCSV = new System.Windows.Forms.Button();
            this.btnGeralReport = new System.Windows.Forms.Button();
            this.btnClientReport = new System.Windows.Forms.Button();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDtE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHrE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDtS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHrS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTipoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTipoCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCodEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeralResult);
            this.panel1.Controls.Add(this.btnImportCSV);
            this.panel1.Controls.Add(this.btnGeralReport);
            this.panel1.Controls.Add(this.btnClientReport);
            this.panel1.Controls.Add(this.btBuscarCliente);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbCliente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 501);
            this.panel1.TabIndex = 1;
            // 
            // btnGeralResult
            // 
            this.btnGeralResult.Location = new System.Drawing.Point(546, 18);
            this.btnGeralResult.Name = "btnGeralResult";
            this.btnGeralResult.Size = new System.Drawing.Size(202, 28);
            this.btnGeralResult.TabIndex = 10;
            this.btnGeralResult.Text = "Resultados gerais";
            this.btnGeralResult.UseVisualStyleBackColor = true;
            // 
            // btnImportCSV
            // 
            this.btnImportCSV.Location = new System.Drawing.Point(754, 52);
            this.btnImportCSV.Name = "btnImportCSV";
            this.btnImportCSV.Size = new System.Drawing.Size(178, 28);
            this.btnImportCSV.TabIndex = 10;
            this.btnImportCSV.Text = "Importar CSV";
            this.btnImportCSV.UseVisualStyleBackColor = true;
            // 
            // btnGeralReport
            // 
            this.btnGeralReport.Location = new System.Drawing.Point(754, 18);
            this.btnGeralReport.Name = "btnGeralReport";
            this.btnGeralReport.Size = new System.Drawing.Size(178, 28);
            this.btnGeralReport.TabIndex = 9;
            this.btnGeralReport.Text = "Gerar relatório geral";
            this.btnGeralReport.UseVisualStyleBackColor = true;
            // 
            // btnClientReport
            // 
            this.btnClientReport.Location = new System.Drawing.Point(546, 52);
            this.btnClientReport.Name = "btnClientReport";
            this.btnClientReport.Size = new System.Drawing.Size(202, 28);
            this.btnClientReport.TabIndex = 9;
            this.btnClientReport.Text = "Gerar relatório do cliente";
            this.btnClientReport.UseVisualStyleBackColor = true;
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Location = new System.Drawing.Point(379, 19);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(144, 28);
            this.btBuscarCliente.TabIndex = 9;
            this.btBuscarCliente.Text = "Buscar cliente";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 352);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbCliente,
            this.tbDtE,
            this.tbHrE,
            this.tbDtS,
            this.tbHrS,
            this.tbPlaca,
            this.tbTipoV,
            this.tbTipoCl,
            this.tbCodEst});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(916, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbCliente
            // 
            this.tbCliente.HeaderText = "Cliente";
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Width = 150;
            // 
            // tbDtE
            // 
            this.tbDtE.HeaderText = "Data entrada";
            this.tbDtE.Name = "tbDtE";
            this.tbDtE.ReadOnly = true;
            this.tbDtE.Width = 75;
            // 
            // tbHrE
            // 
            this.tbHrE.HeaderText = "Hora entrada";
            this.tbHrE.Name = "tbHrE";
            this.tbHrE.ReadOnly = true;
            this.tbHrE.Width = 75;
            // 
            // tbDtS
            // 
            this.tbDtS.HeaderText = "Data saída";
            this.tbDtS.Name = "tbDtS";
            this.tbDtS.ReadOnly = true;
            this.tbDtS.Width = 75;
            // 
            // tbHrS
            // 
            this.tbHrS.HeaderText = "Hora saída";
            this.tbHrS.Name = "tbHrS";
            this.tbHrS.ReadOnly = true;
            this.tbHrS.Width = 75;
            // 
            // tbPlaca
            // 
            this.tbPlaca.HeaderText = "Placa";
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.ReadOnly = true;
            this.tbPlaca.Width = 75;
            // 
            // tbTipoV
            // 
            this.tbTipoV.HeaderText = "Tipo do veículo";
            this.tbTipoV.Name = "tbTipoV";
            this.tbTipoV.ReadOnly = true;
            this.tbTipoV.Width = 115;
            // 
            // tbTipoCl
            // 
            this.tbTipoCl.HeaderText = "Tipo do cliente";
            this.tbTipoCl.Name = "tbTipoCl";
            this.tbTipoCl.ReadOnly = true;
            this.tbTipoCl.Width = 115;
            // 
            // tbCodEst
            // 
            this.tbCodEst.HeaderText = "Código do estacionamento";
            this.tbCodEst.Name = "tbCodEst";
            this.tbCodEst.ReadOnly = true;
            this.tbCodEst.Width = 115;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(76, 19);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(297, 28);
            this.cbCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // GerarHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.panel1);
            this.Name = "GerarHistorico";
            this.Text = "Gerar Historico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeralReport;
        private System.Windows.Forms.Button btnClientReport;
        private System.Windows.Forms.Button btnGeralResult;
        private System.Windows.Forms.Button btnImportCSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDtE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbHrE;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbDtS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbHrS;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbTipoV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbTipoCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCodEst;
    }
}