namespace Ponto.Telas
{
    partial class TelaDepartamentos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewDepartamentos = new System.Windows.Forms.DataGridView();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartamentos
            // 
            this.dataGridViewDepartamentos.AllowUserToAddRows = false;
            this.dataGridViewDepartamentos.AllowUserToDeleteRows = false;
            this.dataGridViewDepartamentos.AutoGenerateColumns = false;
            this.dataGridViewDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.funcionariosDataGridViewTextBoxColumn,
            this.funcoesDataGridViewTextBoxColumn});
            this.dataGridViewDepartamentos.DataSource = this.departamentoBindingSource;
            this.dataGridViewDepartamentos.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewDepartamentos.Name = "dataGridViewDepartamentos";
            this.dataGridViewDepartamentos.ReadOnly = true;
            this.dataGridViewDepartamentos.Size = new System.Drawing.Size(511, 208);
            this.dataGridViewDepartamentos.TabIndex = 0;
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(12, 12);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(75, 23);
            this.buttonIncluir.TabIndex = 1;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(93, 12);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(174, 12);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataSource = typeof(Ponto.Entidades.Departamento);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionariosDataGridViewTextBoxColumn
            // 
            this.funcionariosDataGridViewTextBoxColumn.DataPropertyName = "Funcionarios";
            this.funcionariosDataGridViewTextBoxColumn.HeaderText = "Funcionarios";
            this.funcionariosDataGridViewTextBoxColumn.Name = "funcionariosDataGridViewTextBoxColumn";
            this.funcionariosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcoesDataGridViewTextBoxColumn
            // 
            this.funcoesDataGridViewTextBoxColumn.DataPropertyName = "Funcoes";
            this.funcoesDataGridViewTextBoxColumn.HeaderText = "Funcoes";
            this.funcoesDataGridViewTextBoxColumn.Name = "funcoesDataGridViewTextBoxColumn";
            this.funcoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TelaDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.dataGridViewDepartamentos);
            this.Name = "TelaDepartamentos";
            this.Text = "TelaDepartamntos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartamentos;
        private System.Windows.Forms.Button buttonIncluir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
    }
}